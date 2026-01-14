
using ikYonetimNYPProjesi.BLL;
using ikYonetimNYPProjesi.UI;
using System;
using System.Windows.Forms;

namespace ikYonetimNYPProjesi.UI
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string hata;

            string kullanici_adi = (txtKullaniciAdi.Text ?? "").Trim();
            string sifre = (txtParola.Text ?? "").Trim();

            if (!OturumYoneticisi.GirisYap(kullanici_adi, sifre, out hata))
            {
                MessageBox.Show(hata);
                return;
            }

            // Debug için istersen:
            // MessageBox.Show("Rol: " + OturumYoneticisi.Rol + " | PersonelId: " + OturumYoneticisi.PersonelId);

            new AnaMenu().Show();
            this.Hide();
        }
    }
}