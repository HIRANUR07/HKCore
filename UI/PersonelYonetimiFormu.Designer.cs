namespace ikYonetimNYPProjesi.UI
{
    partial class PersonelYonetimiFormu
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
            dgvPersonel = new DataGridView();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtPozisyon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbDepartman = new ComboBox();
            chkPasifleriGoster = new CheckBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            txtKullaniciAdi = new TextBox();
            label4 = new Label();
            cmbRol = new ComboBox();
            btnAktifeAl = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonel
            // 
            dgvPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonel.Location = new Point(14, 245);
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.ReadOnly = true;
            dgvPersonel.RowHeadersWidth = 51;
            dgvPersonel.Size = new Size(695, 188);
            dgvPersonel.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(12, 49);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(12, 108);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtPozisyon
            // 
            txtPozisyon.Location = new Point(12, 163);
            txtPozisyon.Name = "txtPozisyon";
            txtPozisyon.Size = new Size(125, 27);
            txtPozisyon.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 53);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 4;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 115);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 166);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Poizsyon";
            // 
            // cmbDepartman
            // 
            cmbDepartman.FormattingEnabled = true;
            cmbDepartman.Location = new Point(479, 51);
            cmbDepartman.Name = "cmbDepartman";
            cmbDepartman.Size = new Size(151, 28);
            cmbDepartman.TabIndex = 7;
            // 
            // chkPasifleriGoster
            // 
            chkPasifleriGoster.AutoSize = true;
            chkPasifleriGoster.Location = new Point(488, 128);
            chkPasifleriGoster.Name = "chkPasifleriGoster";
            chkPasifleriGoster.Size = new Size(182, 24);
            chkPasifleriGoster.TabIndex = 8;
            chkPasifleriGoster.Text = "Sadece Aktifleri Göster";
            chkPasifleriGoster.UseVisualStyleBackColor = true;
            chkPasifleriGoster.CheckedChanged += chkPasifleriGoster_CheckedChanged;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(428, 165);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(567, 166);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(499, 210);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(283, 118);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 80);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 13;
            label4.Text = "Kullanıcı Adı";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(257, 179);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(151, 28);
            cmbRol.TabIndex = 14;
            // 
            // btnAktifeAl
            // 
            btnAktifeAl.Location = new Point(615, 210);
            btnAktifeAl.Name = "btnAktifeAl";
            btnAktifeAl.Size = new Size(94, 29);
            btnAktifeAl.TabIndex = 15;
            btnAktifeAl.Text = "Geri Yükle";
            btnAktifeAl.UseVisualStyleBackColor = true;
            btnAktifeAl.Click += btnAktifeAl_Click;
            // 
            // PersonelYonetimiFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAktifeAl);
            Controls.Add(cmbRol);
            Controls.Add(label4);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(chkPasifleriGoster);
            Controls.Add(cmbDepartman);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPozisyon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(dgvPersonel);
            Name = "PersonelYonetimiFormu";
            Text = "PersonelYonetimiFormu";
            Load += PersonelYonetimiFormu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonel;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtPozisyon;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbDepartman;
        private CheckBox chkPasifleriGoster;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private TextBox txtKullaniciAdi;
        private Label label4;
        private ComboBox cmbRol;
        private Button btnAktifeAl;
    }
}