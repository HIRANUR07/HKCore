using ikYonetimNYPProjesi.BLL;
using System;
using System.Windows.Forms;

namespace ikYonetimNYPProjesi.UI
{
    public partial class SifreDegistirFormu : Form
    {
        public SifreDegistirFormu()
        {
            InitializeComponent();

            txtEskiSifre.UseSystemPasswordChar = true;
            txtYeniSifre.UseSystemPasswordChar = true;
            txtYeniSifreTekrar.UseSystemPasswordChar = true;

            // Eğer Designer'dan Click bağlanmadıysa bunu aç:
            // btnDegistir.Click += btnDegistir_Click;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                int personelId = OturumYoneticisi.PersonelId;

                SifreYoneticisi yonetici = new SifreYoneticisi();

                yonetici.SifreDegistir(
                    personelId,
                    txtEskiSifre.Text,
                    txtYeniSifre.Text,
                    txtYeniSifreTekrar.Text
                );

                MessageBox.Show(
                    "Şifre başarıyla değiştirildi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtEskiSifre.Clear();
                txtYeniSifre.Clear();
                txtYeniSifreTekrar.Clear();
                txtEskiSifre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
