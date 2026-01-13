using ikYonetimNYPProjesi.BLL;
using ikYonetimNYPProjesi.ENTITY;
using System;
using System.Windows.Forms;

namespace ikYonetimNYPProjesi.UI
{

    public partial class IzinFormu : Form
    {
        private readonly IzinYoneticisi _izinYoneticisi = new IzinYoneticisi();

        public IzinFormu()
        {
            InitializeComponent();
            // Load event designer'da bağlı değilse buradan garantiye al:
            this.Load += IzinFormu_Load;
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            // boş olabilir
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            // boş olabilir
        }


        private void IzinFormu_Load(object sender, EventArgs e)
        {
            // ComboBox örnek değerler (istersen DB'den çekersin)
            if (cmbIzinTuru.Items.Count == 0)
            {
                cmbIzinTuru.Items.AddRange(new object[]
                {
                    "Yıllık İzin",
                    "Raporlu",
                    "Mazeret İzni",
                   
                });
                cmbIzinTuru.SelectedIndex = 0;
            }

            YetkilereGoreEkran();
            ListeyiYenile();
        }

        // Rol normalize: "Admin" / "admin" / " ADMIN " gibi durumları toparlar
        private string RolGetir()
        {
            return (OturumYoneticisi.Rol ?? string.Empty).Trim();
        }

        private bool RolAdminMi(string rol)
            => rol.Equals("admin", StringComparison.OrdinalIgnoreCase);

        private bool RolIKMi(string rol)
            => rol.Equals("IK", StringComparison.OrdinalIgnoreCase);

        private bool RolPersonelMi(string rol)
            => rol.Equals("User", StringComparison.OrdinalIgnoreCase)
               || rol.Equals("Personel", StringComparison.OrdinalIgnoreCase);

        private void YetkilereGoreEkran()
        {
            var rol = RolGetir(); // Trim + null korumalı
            lblMod.Text = $"Mod: {rol} (PersonelId: {OturumYoneticisi.PersonelId})";

            // Varsayılan
            grpTalep.Visible = false;
            grpAdminOnay.Visible = false;

            // Rol normalize (tek noktadan karar)
            bool isAdmin = rol.Equals("admin", StringComparison.OrdinalIgnoreCase);
            bool isIK = rol.Equals("IK", StringComparison.OrdinalIgnoreCase);

            // Personel rolleri: User / users / Personel
            bool isPersonel =
                rol.Equals("User", StringComparison.OrdinalIgnoreCase) ||
                rol.Equals("users", StringComparison.OrdinalIgnoreCase) ||
                rol.Equals("Personel", StringComparison.OrdinalIgnoreCase);

            if (isAdmin)
            {
                chkBeklemedeOnly.Visible = true;
                chkBeklemedeOnly.Checked = true; // Admin açınca varsayılan filtre açık (istersen false yap)


                chkTumIzinler.Visible = false;
                chkTumIzinler.Checked = false;

                // Admin: Onay/Red açık
                grpTalep.Visible = false;       // admin talep açmasın (istersen true yaparsın)
                grpAdminOnay.Visible = true;
                return;
            }

            if (isIK)
            {
                chkBeklemedeOnly.Visible = false;
                chkBeklemedeOnly.Checked = false;


                chkTumIzinler.Visible = true;
                chkTumIzinler.Checked = true; // IK için varsayılan: tüm izinler

                // IK: Talep oluşturabilsin, onay yok
                grpTalep.Visible = true;
                grpAdminOnay.Visible = false;
                return;
            }

            if (isPersonel)
            {
                chkBeklemedeOnly.Visible = false;
                chkBeklemedeOnly.Checked = false;


                chkTumIzinler.Visible = false;
                chkTumIzinler.Checked = false;

                // User/Personel/users: Talep + onay yok
                grpTalep.Visible = true;
                grpAdminOnay.Visible = false;
                return;
            }

            // Tanınmayan rol: güvenli varsayılan (personel gibi)
            grpTalep.Visible = true;
            grpAdminOnay.Visible = false;
            MessageBox.Show($"Rol tanınmadı: '{rol}'. Varsayılan olarak Personel ekranı açıldı.");
        }

        private void ListeyiYenile()
        {
            var rol = RolGetir();

            dgvIzinler.DataSource = null;

            if (rol.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                // Admin: tüm izinleri çek
                var liste = _izinYoneticisi.Listele();

                // ✅ Beklemede filtresi (checkbox sadece admin'de görünür olsun)
                if (chkBeklemedeOnly.Visible && chkBeklemedeOnly.Checked)
                {
                    liste = liste.FindAll(x =>
                        (x.Durum ?? "").Trim().Equals("Beklemede", StringComparison.OrdinalIgnoreCase));
                }

                dgvIzinler.DataSource = liste;
            }
            else if (rol.Equals("IK", StringComparison.OrdinalIgnoreCase))
            {
                // IK toggle
                if (chkTumIzinler.Checked)
                    dgvIzinler.DataSource = _izinYoneticisi.TumIzinler();
                else
                    dgvIzinler.DataSource = _izinYoneticisi.KendiIzinlerim();
            }
            else
            {
                // User/Personel/users
                dgvIzinler.DataSource = _izinYoneticisi.KendiIzinlerim();
            }

            dgvIzinler.ReadOnly = true;
            dgvIzinler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIzinler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ✅ Satır renklendirme (liste her yenilenince uygula)
            RenklendirIzinSatirlari();
        }
        private void RenklendirIzinSatirlari()
        {
            foreach (DataGridViewRow row in dgvIzinler.Rows)
            {
                if (row.IsNewRow) continue;

                string durum = "";

                if (dgvIzinler.Columns.Contains("Durum"))
                    durum = Convert.ToString(row.Cells["Durum"].Value);
                else if (dgvIzinler.Columns.Contains("durum"))
                    durum = Convert.ToString(row.Cells["durum"].Value);

                durum = (durum ?? "").Trim();

                row.DefaultCellStyle.BackColor = System.Drawing.Color.White;

                if (durum.Equals("Beklemede", StringComparison.OrdinalIgnoreCase))
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Khaki;
                else if (durum.Equals("Onaylandı", StringComparison.OrdinalIgnoreCase))
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.PaleGreen;
                else if (durum.Equals("Reddedildi", StringComparison.OrdinalIgnoreCase))
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
            }
        }


        private void btnTalepOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                // Tarih kontrolü
                if (dtpBitis.Value.Date < dateTimePicker1.Value.Date)
                    throw new Exception("Bitiş tarihi başlangıç tarihinden küçük olamaz.");

                var izin = new Izin
                {
                    // PersonelId UI'da set edilmese de BLL zaten oturumdan set ediyor.
                    BaslangicTarihi = dateTimePicker1.Value.Date,
                    BitisTarihi = dtpBitis.Value.Date,
                    IzinTuru = cmbIzinTuru.Text,
                    Aciklama = txtAciklama.Text
                };

                _izinYoneticisi.IzinTalepEt(izin);

                MessageBox.Show("İzin talebi oluşturuldu.");
                txtAciklama.Clear();
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int SeciliIzinId()
        {
            if (dgvIzinler.CurrentRow == null)
                throw new Exception("Lütfen listeden bir izin seç.");

            object val;

            // DAL select: "id" alanı var. Yine de güvenli okuyalım.
            if (dgvIzinler.Columns.Contains("id"))
                val = dgvIzinler.CurrentRow.Cells["id"].Value;
            else if (dgvIzinler.Columns.Contains("Id"))
                val = dgvIzinler.CurrentRow.Cells["Id"].Value;
            else
                val = dgvIzinler.CurrentRow.Cells[0].Value;

            return Convert.ToInt32(val);
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int id = SeciliIzinId();
                _izinYoneticisi.DurumGuncelle(id, "Onaylandı");
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            try
            {
                int id = SeciliIzinId();
                _izinYoneticisi.DurumGuncelle(id, "Reddedildi");
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkTumIzinler_CheckedChanged(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void chkBeklemedeOnly_CheckedChanged(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

    }
    
}
