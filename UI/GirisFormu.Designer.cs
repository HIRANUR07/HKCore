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
            lblGiris = new Label();
            lbl2Parola = new Label();
            lbl1KullaniciAdi = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(txtParola);
            panel1.Controls.Add(txtKullaniciAdi);
            panel1.Controls.Add(lblGiris);
            panel1.Controls.Add(lbl2Parola);
            panel1.Controls.Add(lbl1KullaniciAdi);
            panel1.Location = new Point(113, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 294);
            panel1.TabIndex = 0;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(124, 190);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(94, 29);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btngiris_Click;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(140, 132);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.Size = new Size(125, 27);
            txtParola.TabIndex = 4;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(140, 63);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // lblGiris
            // 
            lblGiris.AutoSize = true;
            lblGiris.Location = new Point(42, 194);
            lblGiris.Name = "lblGiris";
            lblGiris.Size = new Size(38, 20);
            lblGiris.TabIndex = 2;
            lblGiris.Text = "Giriş";
            // 
            // lbl2Parola
            // 
            lbl2Parola.AutoSize = true;
            lbl2Parola.Location = new Point(42, 132);
            lbl2Parola.Name = "lbl2Parola";
            lbl2Parola.Size = new Size(50, 20);
            lbl2Parola.TabIndex = 1;
            lbl2Parola.Text = "Parola";
            // 
            // lbl1KullaniciAdi
            // 
            lbl1KullaniciAdi.AutoSize = true;
            lbl1KullaniciAdi.Location = new Point(42, 66);
            lbl1KullaniciAdi.Name = "lbl1KullaniciAdi";
            lbl1KullaniciAdi.Size = new Size(92, 20);
            lbl1KullaniciAdi.TabIndex = 0;
            lbl1KullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // GirisFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "GirisFormu";
            Text = "GirisFormu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGiris;
        private TextBox txtParola;
        private TextBox txtKullaniciAdi;
        private Label lblGiris;
        private Label lbl2Parola;
        private Label lbl1KullaniciAdi;
    }
}