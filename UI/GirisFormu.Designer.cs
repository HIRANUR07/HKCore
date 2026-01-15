namespace ikYonetimNYPProjesi.UI
{
    partial class GirisFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnGiris = new Button();
            txtParola = new TextBox();
            txtKullaniciAdi = new TextBox();
            lbl2Parola = new Label();
            lbl1KullaniciAdi = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(233, 227, 247);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(txtParola);
            panel1.Controls.Add(txtKullaniciAdi);
            panel1.Controls.Add(lbl2Parola);
            panel1.Controls.Add(lbl1KullaniciAdi);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 294);
            panel1.TabIndex = 0;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(182, 163, 234);
            btnGiris.Cursor = Cursors.Hand;
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Location = new Point(150, 216);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(115, 45);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btngiris_Click;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(140, 132);
            txtParola.Multiline = true;
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.Size = new Size(125, 30);
            txtParola.TabIndex = 4;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(140, 63);
            txtKullaniciAdi.Multiline = true;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 30);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // lbl2Parola
            // 
            lbl2Parola.AutoSize = true;
            lbl2Parola.Location = new Point(66, 142);
            lbl2Parola.Name = "lbl2Parola";
            lbl2Parola.Size = new Size(50, 20);
            lbl2Parola.TabIndex = 1;
            lbl2Parola.Text = "Parola";
            // 
            // lbl1KullaniciAdi
            // 
            lbl1KullaniciAdi.AutoSize = true;
            lbl1KullaniciAdi.Location = new Point(29, 73);
            lbl1KullaniciAdi.Name = "lbl1KullaniciAdi";
            lbl1KullaniciAdi.Size = new Size(92, 20);
            lbl1KullaniciAdi.TabIndex = 0;
            lbl1KullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 39);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 1;
            label1.Text = "SİSTEME GİRİŞ YAPINIZ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 68, 88);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(155, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 302);
            panel2.TabIndex = 2;
            // 
            // GirisFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.HKCore;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(label1);
            Name = "GirisFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GirisFormu";
            Load += GirisFormu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnGiris;
        private TextBox txtParola;
        private TextBox txtKullaniciAdi;
        private Label lbl2Parola;
        private Label lbl1KullaniciAdi;
        private Label label1;
        private Panel panel2;
    }
}