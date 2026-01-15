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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonel
            // 
            dgvPersonel.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPersonel.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 231, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPersonel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonel.EnableHeadersVisualStyles = false;
            dgvPersonel.Location = new Point(14, 245);
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.ReadOnly = true;
            dgvPersonel.RowHeadersWidth = 51;
            dgvPersonel.Size = new Size(774, 188);
            dgvPersonel.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(97, 51);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(97, 97);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtPozisyon
            // 
            txtPozisyon.Location = new Point(97, 142);
            txtPozisyon.Name = "txtPozisyon";
            txtPozisyon.Size = new Size(125, 27);
            txtPozisyon.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(124, 100, 176);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(36, 54);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 4;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(124, 100, 176);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(14, 100);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(124, 100, 176);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(-2, 145);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Pozisyon";
            // 
            // cmbDepartman
            // 
            cmbDepartman.FormattingEnabled = true;
            cmbDepartman.Location = new Point(637, 20);
            cmbDepartman.Name = "cmbDepartman";
            cmbDepartman.Size = new Size(151, 28);
            cmbDepartman.TabIndex = 7;
            // 
            // chkPasifleriGoster
            // 
            chkPasifleriGoster.AutoSize = true;
            chkPasifleriGoster.BackColor = Color.FromArgb(241, 236, 250);
            chkPasifleriGoster.Cursor = Cursors.Hand;
            chkPasifleriGoster.Location = new Point(23, 210);
            chkPasifleriGoster.Name = "chkPasifleriGoster";
            chkPasifleriGoster.Size = new Size(182, 24);
            chkPasifleriGoster.TabIndex = 8;
            chkPasifleriGoster.Text = "Sadece Aktifleri Göster";
            chkPasifleriGoster.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(241, 236, 250);
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ForeColor = Color.FromArgb(128, 128, 255);
            btnEkle.Location = new Point(491, 138);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 35);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(241, 236, 250);
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.FromArgb(128, 128, 255);
            btnSil.Location = new Point(491, 188);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 35);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(241, 236, 250);
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.FromArgb(128, 128, 255);
            btnGuncelle.Location = new Point(637, 138);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 35);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(294, 100);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(155, 138, 214);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(294, 66);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 13;
            label4.Text = "Kullanıcı Adı";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(637, 61);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(151, 28);
            cmbRol.TabIndex = 14;
            // 
            // btnAktifeAl
            // 
            btnAktifeAl.BackColor = Color.FromArgb(241, 236, 250);
            btnAktifeAl.Cursor = Cursors.Hand;
            btnAktifeAl.FlatStyle = FlatStyle.Flat;
            btnAktifeAl.ForeColor = Color.FromArgb(128, 128, 255);
            btnAktifeAl.Location = new Point(637, 188);
            btnAktifeAl.Name = "btnAktifeAl";
            btnAktifeAl.Size = new Size(94, 35);
            btnAktifeAl.TabIndex = 15;
            btnAktifeAl.Text = "Geri Yükle";
            btnAktifeAl.UseVisualStyleBackColor = false;
            btnAktifeAl.Click += btnAktifeAl_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(124, 100, 176);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(517, 28);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 16;
            label5.Text = "Departmanlar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(124, 100, 176);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(587, 69);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 17;
            label6.Text = "Rol";
            // 
            // PersonelYonetimiFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.HKCore;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label5;
        private Label label6;
    }
}