using ikYonetimNYPProjesi.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikYonetimNYPProjesi.UI
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            lblKullaniciBilgi.Text =
 $"Hoş geldin: {OturumYoneticisi.KullaniciAdi} ({OturumYoneticisi.Rol})";


          
            btnPersonel.Visible = false;
            btnDepartman.Visible = false;
            btnIzin.Visible = false;
            btnMaas.Visible = false;
            btnPerformans.Visible = false;
            btnRapor.Visible = false;
            btnSifreDegistir.Enabled = true; // herkes şifre değiştirebilir

            // Rol bazlı yetkilendirme
            if (OturumYoneticisi.Rol == "admin")
            {
                btnPersonel.Visible = true;
                btnDepartman.Visible = true;
                btnIzin.Visible = true;
                btnMaas.Visible = true;
                btnPerformans.Visible = true;
                btnRapor.Visible = true;
            }
            else if (OturumYoneticisi.Rol == "IK")
            {
                btnPersonel.Visible = true;
                btnDepartman.Visible = true;
                btnIzin.Visible = true;
                btnPerformans.Visible = true;
            }
            else if (OturumYoneticisi.Rol == "users")
            {
                btnIzin.Visible = true;
            }
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {

            new PersonelYonetimiFormu().ShowDialog();
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            new DepartmanYonetimi().ShowDialog();
        }

        private void btnIzin_Click(object sender, EventArgs e)
        {
            new IzinFormu().ShowDialog();
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            new MaasHesaplamaFormu().ShowDialog();
        }

        private void btnPerformans_Click(object sender, EventArgs e)
        {
            new PerformansFormu().ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            new RaporFormu().ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            OturumYoneticisi.CikisYap();
            new GirisFormu().Show();
            this.Close();
        }

        private void btnSifreDegis_Click(object sender, EventArgs e)
        {
            using (var frm = new ikYonetimNYPProjesi.UI.SifreDegistirFormu())
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this); 
            }
        }
    }
}
