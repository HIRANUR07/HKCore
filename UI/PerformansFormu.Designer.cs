namespace ikYonetimNYPProjesi.UI
{
    partial class PerformansFormu
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
            cmbPersonel = new ComboBox();
            nudPuan = new NumericUpDown();
            dtpTarih = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAciklama = new TextBox();
            btnKaydet = new Button();
            label4 = new Label();
            btnGuncelle = new Button();
            btnTemizle = new Button();
            dgvPerformans = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nudPuan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPerformans).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbPersonel
            // 
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(179, 13);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(133, 28);
            cmbPersonel.TabIndex = 0;
            // 
            // nudPuan
            // 
            nudPuan.Location = new Point(180, 61);
            nudPuan.Name = "nudPuan";
            nudPuan.Size = new Size(132, 27);
            nudPuan.TabIndex = 1;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(180, 103);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(232, 27);
            dtpTarih.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 108);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 3;
            label1.Text = "Değerlendirme Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 4;
            label2.Text = "Personel Seçimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 63);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 5;
            label3.Text = "Performans Puanı";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(494, 44);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(250, 60);
            txtAciklama.TabIndex = 6;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(221, 212, 245);
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Location = new Point(525, 133);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 35);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(230, 224, 248);
            label4.Location = new Point(494, 9);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 8;
            label4.Text = "Açıklama";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(221, 212, 245);
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(650, 133);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 35);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(122, 100, 198);
            btnTemizle.Cursor = Cursors.Hand;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Location = new Point(585, 174);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(94, 35);
            btnTemizle.TabIndex = 10;
            btnTemizle.Text = "Sil";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dgvPerformans
            // 
            dgvPerformans.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPerformans.BorderStyle = BorderStyle.None;
            dgvPerformans.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 231, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPerformans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPerformans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerformans.GridColor = Color.Gainsboro;
            dgvPerformans.Location = new Point(12, 218);
            dgvPerformans.Name = "dgvPerformans";
            dgvPerformans.RowHeadersWidth = 51;
            dgvPerformans.Size = new Size(776, 207);
            dgvPerformans.TabIndex = 11;
            dgvPerformans.CellClick += dgvPerformans_CellClick;
            dgvPerformans.CellContentClick += dgvPerformans_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 224, 248);
            panel1.Controls.Add(nudPuan);
            panel1.Controls.Add(cmbPersonel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpTarih);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 153);
            panel1.TabIndex = 12;
            // 
            // PerformansFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.HKCore;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgvPerformans);
            Controls.Add(btnTemizle);
            Controls.Add(btnGuncelle);
            Controls.Add(label4);
            Controls.Add(btnKaydet);
            Controls.Add(txtAciklama);
            Name = "PerformansFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PerformanFormu";
            Load += PerformansFormu_Load;
            Click += PerformansFormu_Load;
            ((System.ComponentModel.ISupportInitialize)nudPuan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPerformans).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPersonel;
        private NumericUpDown nudPuan;
        private DateTimePicker dtpTarih;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAciklama;
        private Button btnKaydet;
        private Label label4;
        private Button btnGuncelle;
        private Button btnTemizle;
        private DataGridView dgvPerformans;
        private Panel panel1;
    }
}