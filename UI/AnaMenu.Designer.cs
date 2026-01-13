namespace ikYonetimNYPProjesi.UI
{
    partial class AnaMenu
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
            btnPersonel = new Button();
            btnDepartman = new Button();
            btnIzin = new Button();
            btnMaas = new Button();
            btnPerformans = new Button();
            btnCikis = new Button();
            btnSifreDegistir = new Button();
            btnRapor = new Button();
            panel1 = new Panel();
            lblKullaniciBilgi = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPersonel
            // 
            btnPersonel.Location = new Point(101, 127);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(163, 29);
            btnPersonel.TabIndex = 0;
            btnPersonel.Text = "Personel Yönetimi";
            btnPersonel.UseVisualStyleBackColor = true;
            btnPersonel.Click += btnPersonel_Click;
            // 
            // btnDepartman
            // 
            btnDepartman.Location = new Point(101, 184);
            btnDepartman.Name = "btnDepartman";
            btnDepartman.Size = new Size(163, 29);
            btnDepartman.TabIndex = 1;
            btnDepartman.Text = "Departman Yönetimi";
            btnDepartman.UseVisualStyleBackColor = true;
            btnDepartman.Click += btnDepartman_Click;
            // 
            // btnIzin
            // 
            btnIzin.Location = new Point(101, 244);
            btnIzin.Name = "btnIzin";
            btnIzin.Size = new Size(163, 29);
            btnIzin.TabIndex = 2;
            btnIzin.Text = "İzin Yönetimi";
            btnIzin.UseVisualStyleBackColor = true;
            btnIzin.Click += btnIzin_Click;
            // 
            // btnMaas
            // 
            btnMaas.Location = new Point(101, 301);
            btnMaas.Name = "btnMaas";
            btnMaas.Size = new Size(163, 29);
            btnMaas.TabIndex = 3;
            btnMaas.Text = "Maaş / Hesaplama";
            btnMaas.UseVisualStyleBackColor = true;
            btnMaas.Click += btnMaas_Click;
            // 
            // btnPerformans
            // 
            btnPerformans.Location = new Point(101, 355);
            btnPerformans.Name = "btnPerformans";
            btnPerformans.Size = new Size(163, 29);
            btnPerformans.TabIndex = 4;
            btnPerformans.Text = "Performans";
            btnPerformans.UseVisualStyleBackColor = true;
            btnPerformans.Click += btnPerformans_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(465, 355);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 29);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.Location = new Point(603, 355);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(109, 29);
            btnSifreDegistir.TabIndex = 6;
            btnSifreDegistir.Text = "Şifre Değiştir";
            btnSifreDegistir.UseVisualStyleBackColor = true;
            btnSifreDegistir.Click += btnSifreDegis_Click;
            // 
            // btnRapor
            // 
            btnRapor.Location = new Point(292, 127);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(94, 29);
            btnRapor.TabIndex = 7;
            btnRapor.Text = "Raporlama";
            btnRapor.UseVisualStyleBackColor = true;
            btnRapor.Click += btnRapor_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(lblKullaniciBilgi);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(42, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 79);
            panel1.TabIndex = 8;
            // 
            // lblKullaniciBilgi
            // 
            lblKullaniciBilgi.AutoSize = true;
            lblKullaniciBilgi.Location = new Point(364, 32);
            lblKullaniciBilgi.Name = "lblKullaniciBilgi";
            lblKullaniciBilgi.Size = new Size(50, 20);
            lblKullaniciBilgi.TabIndex = 1;
            lblKullaniciBilgi.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(264, 20);
            label1.TabIndex = 0;
            label1.Text = "İnsan Kaynakları Personel Takip Sistemi";
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnRapor);
            Controls.Add(btnSifreDegistir);
            Controls.Add(btnCikis);
            Controls.Add(btnPerformans);
            Controls.Add(btnMaas);
            Controls.Add(btnIzin);
            Controls.Add(btnDepartman);
            Controls.Add(btnPersonel);
            Name = "AnaMenu";
            Text = "AnaMenu";
            Load += AnaMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPersonel;
        private Button btnDepartman;
        private Button btnIzin;
        private Button btnMaas;
        private Button btnPerformans;
        private Button btnCikis;
        private Button btnSifreDegistir;
        private Button btnRapor;
        private Panel panel1;
        private Label lblKullaniciBilgi;
        private Label label1;
    }
}