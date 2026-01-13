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
            ((System.ComponentModel.ISupportInitialize)nudPuan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPerformans).BeginInit();
            SuspendLayout();
            // 
            // cmbPersonel
            // 
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(32, 61);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(151, 28);
            cmbPersonel.TabIndex = 0;
            // 
            // nudPuan
            // 
            nudPuan.Location = new Point(29, 112);
            nudPuan.Name = "nudPuan";
            nudPuan.Size = new Size(150, 27);
            nudPuan.TabIndex = 1;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(369, 53);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(658, 61);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 3;
            label1.Text = "Değerlendirme Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 62);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 4;
            label2.Text = "Personel Seçimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 108);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 5;
            label3.Text = "Performans Puanı";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(359, 129);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(125, 27);
            txtAciklama.TabIndex = 6;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(362, 207);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 129);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 8;
            label4.Text = "Açıklama";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(525, 208);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(683, 213);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(94, 29);
            btnTemizle.TabIndex = 10;
            btnTemizle.Text = "Sil";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dgvPerformans
            // 
            dgvPerformans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerformans.Location = new Point(12, 268);
            dgvPerformans.Name = "dgvPerformans";
            dgvPerformans.RowHeadersWidth = 51;
            dgvPerformans.Size = new Size(776, 157);
            dgvPerformans.TabIndex = 11;
            dgvPerformans.CellClick += dgvPerformans_CellClick;
            // 
            // PerformansFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPerformans);
            Controls.Add(btnTemizle);
            Controls.Add(btnGuncelle);
            Controls.Add(label4);
            Controls.Add(btnKaydet);
            Controls.Add(txtAciklama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpTarih);
            Controls.Add(nudPuan);
            Controls.Add(cmbPersonel);
            Name = "PerformansFormu";
            Text = "PerformanFormu";
            Load += PerformansFormu_Load;
            Click += PerformansFormu_Load;
            ((System.ComponentModel.ISupportInitialize)nudPuan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPerformans).EndInit();
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
    }
}