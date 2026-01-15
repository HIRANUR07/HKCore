namespace ikYonetimNYPProjesi.UI
{
    partial class DepartmanYonetimi
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
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnPasifeAl = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDepartmanAdi = new TextBox();
            label4 = new Label();
            chkPasifleriGoster = new CheckBox();
            dgvDepartman = new DataGridView();
            btnAktifeAl = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepartman).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(246, 243, 251);
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 167, 232);
            btnEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 184, 240);
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ForeColor = Color.FromArgb(58, 47, 79);
            btnEkle.Location = new Point(12, 194);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(246, 243, 251);
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 167, 232);
            btnGuncelle.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 184, 240);
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.FromArgb(58, 47, 79);
            btnGuncelle.Location = new Point(166, 194);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnPasifeAl
            // 
            btnPasifeAl.BackColor = Color.FromArgb(246, 243, 251);
            btnPasifeAl.FlatAppearance.BorderSize = 0;
            btnPasifeAl.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 167, 232);
            btnPasifeAl.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 184, 240);
            btnPasifeAl.FlatStyle = FlatStyle.Flat;
            btnPasifeAl.ForeColor = Color.FromArgb(58, 47, 79);
            btnPasifeAl.Location = new Point(12, 271);
            btnPasifeAl.Name = "btnPasifeAl";
            btnPasifeAl.Size = new Size(94, 29);
            btnPasifeAl.TabIndex = 2;
            btnPasifeAl.Text = "Pasife Al";
            btnPasifeAl.UseVisualStyleBackColor = false;
            btnPasifeAl.Click += btnPasifeAl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 203);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 303);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 371);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // txtDepartmanAdi
            // 
            txtDepartmanAdi.Location = new Point(64, 113);
            txtDepartmanAdi.Name = "txtDepartmanAdi";
            txtDepartmanAdi.Size = new Size(125, 27);
            txtDepartmanAdi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 76);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 7;
            label4.Text = "Departman Adı";
            // 
            // chkPasifleriGoster
            // 
            chkPasifleriGoster.AutoSize = true;
            chkPasifleriGoster.Location = new Point(598, 60);
            chkPasifleriGoster.Name = "chkPasifleriGoster";
            chkPasifleriGoster.Size = new Size(129, 24);
            chkPasifleriGoster.TabIndex = 8;
            chkPasifleriGoster.Text = "Pasifleri Göster";
            chkPasifleriGoster.UseVisualStyleBackColor = true;
            chkPasifleriGoster.CheckedChanged += chkPasifleriGoster_CheckedChanged;
            // 
            // dgvDepartman
            // 
            dgvDepartman.BackgroundColor = Color.FromArgb(246, 243, 251);
            dgvDepartman.BorderStyle = BorderStyle.None;
            dgvDepartman.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 231, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDepartman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDepartman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartman.EnableHeadersVisualStyles = false;
            dgvDepartman.GridColor = Color.FromArgb(185, 167, 216);
            dgvDepartman.Location = new Point(350, 113);
            dgvDepartman.Name = "dgvDepartman";
            dgvDepartman.RowHeadersWidth = 51;
            dgvDepartman.Size = new Size(377, 187);
            dgvDepartman.TabIndex = 9;
            dgvDepartman.CellContentClick += dgvDepartman_CellContentClick;
            dgvDepartman.SelectionChanged += dgvDepartman_SelectionChanged;
            // 
            // btnAktifeAl
            // 
            btnAktifeAl.BackColor = Color.FromArgb(246, 243, 251);
            btnAktifeAl.FlatAppearance.BorderSize = 0;
            btnAktifeAl.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 167, 232);
            btnAktifeAl.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 184, 240);
            btnAktifeAl.FlatStyle = FlatStyle.Flat;
            btnAktifeAl.ForeColor = Color.FromArgb(58, 47, 79);
            btnAktifeAl.Location = new Point(166, 271);
            btnAktifeAl.Name = "btnAktifeAl";
            btnAktifeAl.Size = new Size(94, 29);
            btnAktifeAl.TabIndex = 10;
            btnAktifeAl.Text = "Aktife Al";
            btnAktifeAl.UseVisualStyleBackColor = false;
            btnAktifeAl.Click += btnAktifeAl_Click;
            // 
            // DepartmanYonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.HKCore;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAktifeAl);
            Controls.Add(dgvDepartman);
            Controls.Add(chkPasifleriGoster);
            Controls.Add(label4);
            Controls.Add(txtDepartmanAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPasifeAl);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Name = "DepartmanYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DepartmanYoneticisi";
            Load += DepartmanYonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnPasifeAl;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDepartmanAdi;
        private Label label4;
        private CheckBox chkPasifleriGoster;
        private DataGridView dgvDepartman;
        private Button btnAktifeAl;
    }
}