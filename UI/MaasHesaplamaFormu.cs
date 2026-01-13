
using ikYonetimNYPProjesi.BLL;
using ikYonetimNYPProjesi.ENTITY;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ikYonetimNYPProjesi.UI
{
    public partial class MaasHesaplamaFormu : Form
    {
        private readonly PersonelYoneticisi _personelYoneticisi = new PersonelYoneticisi();
        private List<Personel> _aktifPersoneller = new List<Personel>();

        public MaasHesaplamaFormu()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(255, 228, 225);
            this.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);
        }

        private void MaasHesaplamaFormu_Load(object sender, EventArgs e)
        {
            // Grid Stilleri
            dgvMaaslar.BackgroundColor = System.Drawing.Color.White;
            dgvMaaslar.EnableHeadersVisualStyles = false;
            dgvMaaslar.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            dgvMaaslar.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvMaaslar.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            dgvMaaslar.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DeepPink;
            dgvMaaslar.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // Yıl
            cmbYil.Items.Clear();
            for (int yil = 2020; yil <= 2030; yil++)
                cmbYil.Items.Add(yil);

            // Ay
            cmbAy.Items.Clear();
            for (int ay = 1; ay <= 12; ay++)
                cmbAy.Items.Add(ay);

            if (cmbYil.Items.Count > 0) cmbYil.SelectedIndex = 0;
            if (cmbAy.Items.Count > 0) cmbAy.SelectedIndex = 0;

            // Personel combobox doldur
            PersonelComboDoldur();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                decimal brut = decimal.Parse(txtBrut.Text);
                decimal prim = decimal.Parse(txtPrim.Text);
                decimal mesai = decimal.Parse(txtMesai.Text);
                decimal kesinti = decimal.Parse(txtKesinti.Text);

                decimal net = brut + prim + mesai - kesinti;
                lblNetMaas.Text = net.ToString("N2") + " ₺";
            }
            catch
            {
                MessageBox.Show("Lütfen maaş alanlarını doğru giriniz.");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!OturumYoneticisi.GirisYapildiMi)
            {
                MessageBox.Show("Oturum bulunamadı. Lütfen tekrar giriş yapın.");
                return;
            }

            try
            {
                if (cmbPersonel.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen personel seçiniz.");
                    return;
                }

                if (cmbYil.SelectedItem == null || cmbAy.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen yıl ve ay seçiniz.");
                    return;
                }

                Maas maas = new Maas
                {
                    // Artık txtPersonelId yok: seçili personelden alıyoruz
                    PersonelId = Convert.ToInt32(cmbPersonel.SelectedValue),
                    Yil = Convert.ToInt32(cmbYil.SelectedItem),
                    Ay = Convert.ToInt32(cmbAy.SelectedItem),

                    BrutMaas = decimal.Parse(txtBrut.Text),
                    Prim = decimal.Parse(txtPrim.Text),
                    Mesai = decimal.Parse(txtMesai.Text),
                    KesintiToplam = decimal.Parse(txtKesinti.Text),

                    HesaplamaTarihi = DateTime.Now,
                    Aciklama = (txtAciklama.Text ?? "").Trim()
                };

                MaasYoneticisi yonetici = new MaasYoneticisi();
                yonetici.Kaydet(maas);

                MessageBox.Show("Maaş kaydedildi.");

                // Kaydettikten sonra seçili personelin geçmişini yenile
                dgvMaaslar.DataSource = yonetici.PersonelGecmisi(maas.PersonelId);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen Brüt/Prim/Mesai/Kesinti alanlarına sayısal değer giriniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPersonel.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen personel seçiniz.");
                    return;
                }

                int personelId = Convert.ToInt32(cmbPersonel.SelectedValue);

                MaasYoneticisi yonetici = new MaasYoneticisi();
                dgvMaaslar.DataSource = yonetici.PersonelGecmisi(personelId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PersonelComboDoldur()
        {
            _aktifPersoneller = _personelYoneticisi.AktifPersonelleriGetir();

            var kaynak = new List<PersonelComboItem>();
            foreach (var p in _aktifPersoneller)
            {
                kaynak.Add(new PersonelComboItem
                {
                    Id = p.Id,
                    Gosterim = (p.Ad + " " + p.Soyad + " | " + p.Departman)
                });
            }

            cmbPersonel.DataSource = null;
            cmbPersonel.DisplayMember = "Gosterim";
            cmbPersonel.ValueMember = "Id";
            cmbPersonel.DataSource = kaynak;

            if (cmbPersonel.Items.Count > 0)
                cmbPersonel.SelectedIndex = 0;
        }

        private class PersonelComboItem
        {
            public int Id { get; set; }
            public string Gosterim { get; set; }
        }
    }
}