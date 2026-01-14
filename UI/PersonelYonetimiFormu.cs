
using ikYonetimNYPProjesi.BLL;
using ikYonetimNYPProjesi.ENTITY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ikYonetimNYPProjesi.UI
{
    public partial class PersonelYonetimiFormu : Form
    {
        private readonly PersonelYoneticisi _yonetici = new PersonelYoneticisi();

        public PersonelYonetimiFormu()
        {
            InitializeComponent();

            this.Load += PersonelYonetimiFormu_Load;
            dgvPersonel.SelectionChanged += dgvPersonel_SelectionChanged;

         
            chkPasifleriGoster.CheckedChanged += (s, e) => ListeyiYenile();
        }

        private void PersonelYonetimiFormu_Load(object sender, EventArgs e)
        {
            DepartmanlariDoldur();

            
            ListeyiYenile();
            YetkiyeGoreButonlar();

            if (cmbRol.Items.Count == 0)
            {

                cmbRol.Items.Add("IK");
                cmbRol.Items.Add("users");
                cmbRol.SelectedIndex = 1;
            }
        }

        private void YetkiyeGoreButonlar()
        {
            var rol = (OturumYoneticisi.Rol ?? "").Trim();

            bool yetkili =
                rol.Equals("Admin", StringComparison.OrdinalIgnoreCase) ||
                rol.Equals("IK", StringComparison.OrdinalIgnoreCase);

            btnEkle.Enabled = yetkili;
            btnGuncelle.Enabled = yetkili;
            btnSil.Enabled = yetkili;
        }

        private void DepartmanlariDoldur()
        {
            var depts = new List<string> { "İK", "Muhasebe", "Satış", "Üretim", "IT" };
            cmbDepartman.DataSource = depts;
        }

        private void ListeyiYenile()
        {
           
            var liste = _yonetici.TumPersonelleriGetir();

            
            if (chkPasifleriGoster.Checked)
                liste = liste.Where(p => p.Aktif).ToList();

            dgvPersonel.DataSource = null;
            dgvPersonel.DataSource = liste;

            dgvPersonel.ReadOnly = true;
            dgvPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvPersonel.Columns.Contains("Aktif"))
                dgvPersonel.Columns["Aktif"].HeaderText = "Aktif";

            
            if (dgvPersonel.Columns.Contains("Id"))
                dgvPersonel.Columns["Id"].Visible = false;

            if (dgvPersonel.Columns.Contains("UserId"))
                dgvPersonel.Columns["UserId"].Visible = false;

            
            if (!chkPasifleriGoster.Checked && dgvPersonel.Columns.Contains("Aktif"))
            {
                foreach (DataGridViewRow row in dgvPersonel.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool aktif = Convert.ToBoolean(row.Cells["Aktif"].Value);
                    if (!aktif)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                        row.DefaultCellStyle.BackColor = Color.Gainsboro;
                    }
                }
            }
        }

        private void KullaniciAlanlariniSifirla()
        {
          
            txtKullaniciAdi.Text = "";

          
            if (cmbRol.Items.Count > 0)
            {
                var idx = cmbRol.FindStringExact("users");
                if (idx >= 0) cmbRol.SelectedIndex = idx;
            }
        }

        private int SeciliId()
        {
            if (dgvPersonel.CurrentRow == null) return 0;

            if (dgvPersonel.Columns.Contains("Id"))
                return Convert.ToInt32(dgvPersonel.CurrentRow.Cells["Id"].Value);

            if (dgvPersonel.Columns.Contains("id"))
                return Convert.ToInt32(dgvPersonel.CurrentRow.Cells["id"].Value);

            return Convert.ToInt32(dgvPersonel.CurrentRow.Cells[0].Value);
        }

        private void dgvPersonel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonel.CurrentRow == null) return;

            txtAd.Text = Convert.ToString(dgvPersonel.CurrentRow.Cells["Ad"].Value);
            txtSoyad.Text = Convert.ToString(dgvPersonel.CurrentRow.Cells["Soyad"].Value);
            txtPozisyon.Text = Convert.ToString(dgvPersonel.CurrentRow.Cells["Pozisyon"].Value);

            var dep = Convert.ToString(dgvPersonel.CurrentRow.Cells["Departman"].Value);
            if (!string.IsNullOrWhiteSpace(dep))
                cmbDepartman.SelectedItem = dep;


            KullaniciAlanlariniSifirla();


           
        }

        private bool SeciliPersonelAktifMi()
        {
            if (dgvPersonel.CurrentRow == null) return true;
            if (!dgvPersonel.Columns.Contains("Aktif")) return true;

            return Convert.ToBoolean(dgvPersonel.CurrentRow.Cells["Aktif"].Value);
        }
        private int SeciliYillikIzinHakki()
        {
            if (dgvPersonel.CurrentRow == null) return 14;

            if (dgvPersonel.Columns.Contains("YillikIzinHakki"))
                return Convert.ToInt32(dgvPersonel.CurrentRow.Cells["YillikIzinHakki"].Value);

          
            return 14;
        }


        private Personel FormdanOku()
        {
           
            bool mevcutAktif = SeciliPersonelAktifMi();
            int mevcutIzin = SeciliYillikIzinHakki();

            return new Personel
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Departman = Convert.ToString(cmbDepartman.SelectedItem),
                Pozisyon = txtPozisyon.Text,
                Aktif = mevcutAktif,
                 YillikIzinHakki = mevcutIzin
            };
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Personel p = new Personel
                {
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    Departman = cmbDepartman.Text.Trim(),
                    Pozisyon = txtPozisyon.Text.Trim(),
                    Aktif = true,
                    YillikIzinHakki = 14
                };

                string kullanici_adi = txtKullaniciAdi.Text.Trim();
                string rol = cmbRol.Text.Trim();

                _yonetici.PersonelVeKullaniciEkle(p, kullanici_adi, rol);

                ListeyiYenile();
                KullaniciAlanlariniSifirla();



                MessageBox.Show("Personel + kullanıcı oluşturuldu.\nBaşlangıç şifre: 1234");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = SeciliId();
                if (id <= 0) throw new Exception("Güncellenecek personeli seç.");

                var p = FormdanOku();
                p.Id = id;

                _yonetici.PersonelGuncelle(p);

                ListeyiYenile();
                KullaniciAlanlariniSifirla();
                MessageBox.Show("Personel güncellendi.");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = SeciliId();
                if (id <= 0)
                    throw new Exception("Pasife alınacak personeli seç.");

                DialogResult onay = MessageBox.Show(
                    "Bu personeli silmek istiyor musunuz ?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (onay != DialogResult.Yes)
                    return;

                var p = FormdanOku();
                p.Id = id;
                p.Aktif = false;

                _yonetici.PersonelGuncelle(p);

                ListeyiYenile();
                KullaniciAlanlariniSifirla();
                MessageBox.Show("Personel kaydı silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private int SeciliPersonelId()
        {
            if (dgvPersonel.CurrentRow == null) return 0;
            return Convert.ToInt32(dgvPersonel.CurrentRow.Cells["Id"].Value);
        }

        private void btnAktifeAl_Click(object sender, EventArgs e)
        {
            try
            {
                int id = SeciliPersonelId();
                if (id <= 0)
                    throw new Exception("Aktife alınacak personeli seç.");

                _yonetici.PersonelAktiflikDegistir(id, true);

                ListeyiYenile();
                MessageBox.Show("Personel kaydı geri yüklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}