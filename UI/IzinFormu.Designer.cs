namespace ikYonetimNYPProjesi.UI
{
    partial class IzinFormu
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
            grpTalep = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            lblMod = new Label();
            dtpBitis = new DateTimePicker();
            btnTalepOlustur = new Button();
            txtAciklama = new TextBox();
            label3 = new Label();
            cmbIzinTuru = new ComboBox();
            label1 = new Label();
            dtpBaslangic = new Label();
            label4 = new Label();
            dgvIzinler = new DataGridView();
            grpAdminOnay = new GroupBox();
            btnReddet = new Button();
            btnOnay = new Button();
            chkTumIzinler = new CheckBox();
            chkBeklemedeOnly = new CheckBox();
            grpTalep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIzinler).BeginInit();
            grpAdminOnay.SuspendLayout();
            SuspendLayout();
            // 
            // grpTalep
            // 
            grpTalep.Controls.Add(dateTimePicker1);
            grpTalep.Controls.Add(lblMod);
            grpTalep.Controls.Add(dtpBitis);
            grpTalep.Controls.Add(btnTalepOlustur);
            grpTalep.Controls.Add(txtAciklama);
            grpTalep.Controls.Add(label3);
            grpTalep.Controls.Add(cmbIzinTuru);
            grpTalep.Controls.Add(label1);
            grpTalep.Controls.Add(dtpBaslangic);
            grpTalep.Location = new Point(7, 12);
            grpTalep.Name = "grpTalep";
            grpTalep.Size = new Size(433, 273);
            grpTalep.TabIndex = 0;
            grpTalep.TabStop = false;
            grpTalep.Text = "İzin Talebi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 68);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // lblMod
            // 
            lblMod.AutoSize = true;
            lblMod.Location = new Point(314, 179);
            lblMod.Name = "lblMod";
            lblMod.Size = new Size(70, 20);
            lblMod.TabIndex = 15;
            lblMod.Text = "Açıklama";
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(6, 134);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 7;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // btnTalepOlustur
            // 
            btnTalepOlustur.Location = new Point(156, 250);
            btnTalepOlustur.Name = "btnTalepOlustur";
            btnTalepOlustur.Size = new Size(150, 29);
            btnTalepOlustur.TabIndex = 10;
            btnTalepOlustur.Text = "Talep Oluştur";
            btnTalepOlustur.UseVisualStyleBackColor = true;
            btnTalepOlustur.Click += btnTalepOlustur_Click;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(286, 202);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(125, 34);
            txtAciklama.TabIndex = 9;
            txtAciklama.TextChanged += txtAciklama_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 179);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "İzin Türü";
            // 
            // cmbIzinTuru
            // 
            cmbIzinTuru.FormattingEnabled = true;
            cmbIzinTuru.Location = new Point(27, 202);
            cmbIzinTuru.Name = "cmbIzinTuru";
            cmbIzinTuru.Size = new Size(151, 28);
            cmbIzinTuru.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.AutoSize = true;
            dtpBaslangic.Location = new Point(6, 109);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(76, 20);
            dtpBaslangic.TabIndex = 2;
            dtpBaslangic.Text = "Bitiş Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 107);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 4;
            // 
            // dgvIzinler
            // 
            dgvIzinler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIzinler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIzinler.Location = new Point(13, 369);
            dgvIzinler.Name = "dgvIzinler";
            dgvIzinler.ReadOnly = true;
            dgvIzinler.RowHeadersWidth = 51;
            dgvIzinler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIzinler.Size = new Size(900, 120);
            dgvIzinler.TabIndex = 11;
            // 
            // grpAdminOnay
            // 
            grpAdminOnay.Controls.Add(btnReddet);
            grpAdminOnay.Controls.Add(btnOnay);
            grpAdminOnay.Controls.Add(label4);
            grpAdminOnay.Location = new Point(483, 39);
            grpAdminOnay.Name = "grpAdminOnay";
            grpAdminOnay.Size = new Size(305, 187);
            grpAdminOnay.TabIndex = 12;
            grpAdminOnay.TabStop = false;
            grpAdminOnay.Text = "Admin Onay/Red";
            // 
            // btnReddet
            // 
            btnReddet.Location = new Point(177, 108);
            btnReddet.Name = "btnReddet";
            btnReddet.Size = new Size(94, 29);
            btnReddet.TabIndex = 14;
            btnReddet.Text = "Reddet";
            btnReddet.UseVisualStyleBackColor = true;
            btnReddet.Click += btnReddet_Click;
            // 
            // btnOnay
            // 
            btnOnay.Location = new Point(13, 107);
            btnOnay.Name = "btnOnay";
            btnOnay.Size = new Size(94, 29);
            btnOnay.TabIndex = 13;
            btnOnay.Text = "Onayla";
            btnOnay.UseVisualStyleBackColor = true;
            btnOnay.Click += btnOnayla_Click;
            // 
            // chkTumIzinler
            // 
            chkTumIzinler.AutoSize = true;
            chkTumIzinler.Location = new Point(670, 339);
            chkTumIzinler.Name = "chkTumIzinler";
            chkTumIzinler.Size = new Size(155, 24);
            chkTumIzinler.TabIndex = 13;
            chkTumIzinler.Text = "Tüm İzinleri Göster";
            chkTumIzinler.UseVisualStyleBackColor = true;
            chkTumIzinler.Visible = false;
            chkTumIzinler.CheckedChanged += chkTumIzinler_CheckedChanged;
            // 
            // chkBeklemedeOnly
            // 
            chkBeklemedeOnly.AutoSize = true;
            chkBeklemedeOnly.Location = new Point(20, 335);
            chkBeklemedeOnly.Name = "chkBeklemedeOnly";
            chkBeklemedeOnly.Size = new Size(209, 24);
            chkBeklemedeOnly.TabIndex = 14;
            chkBeklemedeOnly.Text = "Sadece Beklemede Olanlar";
            chkBeklemedeOnly.UseVisualStyleBackColor = true;
            chkBeklemedeOnly.Visible = false;
            chkBeklemedeOnly.CheckedChanged += chkBeklemedeOnly_CheckedChanged;
            // 
            // IzinFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 501);
            Controls.Add(chkBeklemedeOnly);
            Controls.Add(chkTumIzinler);
            Controls.Add(grpAdminOnay);
            Controls.Add(dgvIzinler);
            Controls.Add(grpTalep);
            Name = "IzinFormu";
            Text = "IzinFormu";
            Load += IzinFormu_Load;
            grpTalep.ResumeLayout(false);
            grpTalep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIzinler).EndInit();
            grpAdminOnay.ResumeLayout(false);
            grpAdminOnay.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpTalep;
        private Label label1;
        private Label dtpBaslangic;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtpBitis;
        private ComboBox cmbIzinTuru;
        private TextBox txtAciklama;
        private Button btnTalepOlustur;
        private DataGridView dgvIzinler;
        private GroupBox grpAdminOnay;
        private Button btnOnay;
        private Button btnReddet;
        private Label lblMod;
        private CheckBox chkTumIzinler;
        private CheckBox chkBeklemedeOnly;
    }
}