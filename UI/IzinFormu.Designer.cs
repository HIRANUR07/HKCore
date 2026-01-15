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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            grpTalep.BackColor = Color.FromArgb(245, 242, 250);
            grpTalep.Controls.Add(dateTimePicker1);
            grpTalep.Controls.Add(lblMod);
            grpTalep.Controls.Add(dtpBitis);
            grpTalep.Controls.Add(btnTalepOlustur);
            grpTalep.Controls.Add(txtAciklama);
            grpTalep.Controls.Add(label3);
            grpTalep.Controls.Add(cmbIzinTuru);
            grpTalep.Controls.Add(label1);
            grpTalep.Controls.Add(dtpBaslangic);
            grpTalep.ForeColor = Color.FromArgb(107, 79, 163);
            grpTalep.Location = new Point(12, 12);
            grpTalep.Name = "grpTalep";
            grpTalep.Size = new Size(554, 230);
            grpTalep.TabIndex = 0;
            grpTalep.TabStop = false;
            grpTalep.Text = "İzin Talebi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // lblMod
            // 
            lblMod.AutoSize = true;
            lblMod.ForeColor = Color.FromArgb(68, 68, 68);
            lblMod.Location = new Point(304, 92);
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
            // 
            // btnTalepOlustur
            // 
            btnTalepOlustur.BackColor = Color.FromArgb(182, 163, 234);
            btnTalepOlustur.Cursor = Cursors.Hand;
            btnTalepOlustur.ForeColor = Color.White;
            btnTalepOlustur.Location = new Point(146, 181);
            btnTalepOlustur.Name = "btnTalepOlustur";
            btnTalepOlustur.Size = new Size(150, 35);
            btnTalepOlustur.TabIndex = 10;
            btnTalepOlustur.Text = "Talep Oluştur";
            btnTalepOlustur.UseVisualStyleBackColor = false;
            btnTalepOlustur.Click += btnTalepOlustur_Click;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(304, 115);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(231, 61);
            txtAciklama.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(68, 68, 68);
            label3.Location = new Point(304, 45);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "İzin Türü";
            // 
            // cmbIzinTuru
            // 
            cmbIzinTuru.FormattingEnabled = true;
            cmbIzinTuru.Location = new Point(384, 45);
            cmbIzinTuru.Name = "cmbIzinTuru";
            cmbIzinTuru.Size = new Size(151, 28);
            cmbIzinTuru.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(68, 68, 68);
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.AutoSize = true;
            dtpBaslangic.ForeColor = Color.FromArgb(68, 68, 68);
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
            dgvIzinler.BackgroundColor = SystemColors.ButtonHighlight;
            dgvIzinler.BorderStyle = BorderStyle.None;
            dgvIzinler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 231, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvIzinler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvIzinler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIzinler.EnableHeadersVisualStyles = false;
            dgvIzinler.GridColor = Color.Gainsboro;
            dgvIzinler.Location = new Point(3, 305);
            dgvIzinler.Name = "dgvIzinler";
            dgvIzinler.ReadOnly = true;
            dgvIzinler.RowHeadersWidth = 51;
            dgvIzinler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIzinler.Size = new Size(923, 201);
            dgvIzinler.TabIndex = 11;
            // 
            // grpAdminOnay
            // 
            grpAdminOnay.Controls.Add(btnReddet);
            grpAdminOnay.Controls.Add(btnOnay);
            grpAdminOnay.Controls.Add(label4);
            grpAdminOnay.ForeColor = Color.FromArgb(107, 79, 163);
            grpAdminOnay.Location = new Point(593, 35);
            grpAdminOnay.Name = "grpAdminOnay";
            grpAdminOnay.Size = new Size(305, 187);
            grpAdminOnay.TabIndex = 12;
            grpAdminOnay.TabStop = false;
            grpAdminOnay.Text = "Admin Onay/Red";
            // 
            // btnReddet
            // 
            btnReddet.BackColor = Color.FromArgb(209, 106, 116);
            btnReddet.Cursor = Cursors.Hand;
            btnReddet.FlatStyle = FlatStyle.Flat;
            btnReddet.ForeColor = Color.Black;
            btnReddet.Location = new Point(177, 108);
            btnReddet.Name = "btnReddet";
            btnReddet.Size = new Size(94, 35);
            btnReddet.TabIndex = 14;
            btnReddet.Text = "Reddet";
            btnReddet.UseVisualStyleBackColor = false;
            btnReddet.Click += btnReddet_Click;
            // 
            // btnOnay
            // 
            btnOnay.BackColor = Color.FromArgb(111, 191, 156);
            btnOnay.Cursor = Cursors.Hand;
            btnOnay.FlatStyle = FlatStyle.Flat;
            btnOnay.ForeColor = Color.Black;
            btnOnay.Location = new Point(13, 107);
            btnOnay.Name = "btnOnay";
            btnOnay.Size = new Size(94, 35);
            btnOnay.TabIndex = 13;
            btnOnay.Text = "Onayla";
            btnOnay.UseVisualStyleBackColor = false;
            btnOnay.Click += btnOnayla_Click;
            // 
            // chkTumIzinler
            // 
            chkTumIzinler.AutoSize = true;
            chkTumIzinler.Location = new Point(669, 265);
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
            chkBeklemedeOnly.Location = new Point(3, 275);
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
            BackgroundImage = Resource1.HKCore;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(925, 501);
            Controls.Add(chkBeklemedeOnly);
            Controls.Add(chkTumIzinler);
            Controls.Add(grpAdminOnay);
            Controls.Add(dgvIzinler);
            Controls.Add(grpTalep);
            Name = "IzinFormu";
            StartPosition = FormStartPosition.CenterScreen;
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