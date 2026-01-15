namespace ikYonetimNYPProjesi.UI
{
    partial class MaasHesaplamaFormu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBrut = new TextBox();
            cmbYil = new ComboBox();
            cmbAy = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtKesinti = new TextBox();
            txtMesai = new TextBox();
            txtPrim = new TextBox();
            lblNetMaas = new Label();
            btnHesapla = new Button();
            btnKaydet = new Button();
            btnListele = new Button();
            dgvMaaslar = new DataGridView();
            label8 = new Label();
            txtAciklama = new TextBox();
            btnSil = new Button();
            cmbPersonel = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMaaslar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Personel ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 58);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 1;
            label2.Text = "Yıl";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 99);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 2;
            label3.Text = "Ay";
            // 
            // txtBrut
            // 
            txtBrut.Location = new Point(173, 158);
            txtBrut.Name = "txtBrut";
            txtBrut.Size = new Size(125, 27);
            txtBrut.TabIndex = 5;
            // 
            // cmbYil
            // 
            cmbYil.FormattingEnabled = true;
            cmbYil.Location = new Point(86, 50);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(151, 28);
            cmbYil.TabIndex = 6;
            // 
            // cmbAy
            // 
            cmbAy.FormattingEnabled = true;
            cmbAy.Location = new Point(87, 91);
            cmbAy.Name = "cmbAy";
            cmbAy.Size = new Size(151, 28);
            cmbAy.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(207, 198, 244);
            label4.Location = new Point(70, 165);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Brüt Maaş";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(207, 198, 244);
            label5.Location = new Point(428, 200);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 9;
            label5.Text = "Kesinti";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(207, 198, 244);
            label6.Location = new Point(428, 162);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 10;
            label6.Text = "Mesai";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(207, 198, 244);
            label7.Location = new Point(70, 207);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 11;
            label7.Text = "Prim";
            // 
            // txtKesinti
            // 
            txtKesinti.Location = new Point(530, 200);
            txtKesinti.Name = "txtKesinti";
            txtKesinti.Size = new Size(125, 27);
            txtKesinti.TabIndex = 12;
            // 
            // txtMesai
            // 
            txtMesai.Location = new Point(531, 155);
            txtMesai.Name = "txtMesai";
            txtMesai.Size = new Size(125, 27);
            txtMesai.TabIndex = 13;
            // 
            // txtPrim
            // 
            txtPrim.Location = new Point(172, 204);
            txtPrim.Name = "txtPrim";
            txtPrim.Size = new Size(125, 27);
            txtPrim.TabIndex = 14;
            // 
            // lblNetMaas
            // 
            lblNetMaas.AutoSize = true;
            lblNetMaas.ForeColor = Color.FromArgb(90, 63, 140);
            lblNetMaas.Location = new Point(380, 33);
            lblNetMaas.Name = "lblNetMaas";
            lblNetMaas.Size = new Size(81, 20);
            lblNetMaas.TabIndex = 15;
            lblNetMaas.Text = "NET MAAŞ";
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.FromArgb(179, 157, 219);
            btnHesapla.Cursor = Cursors.Hand;
            btnHesapla.ForeColor = Color.Black;
            btnHesapla.Location = new Point(380, 85);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(94, 35);
            btnHesapla.TabIndex = 16;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(179, 157, 219);
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.ForeColor = Color.Black;
            btnKaydet.Location = new Point(512, 85);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 35);
            btnKaydet.TabIndex = 17;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.FromArgb(179, 157, 219);
            btnListele.Cursor = Cursors.Hand;
            btnListele.ForeColor = Color.Black;
            btnListele.Location = new Point(643, 85);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 35);
            btnListele.TabIndex = 18;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // dgvMaaslar
            // 
            dgvMaaslar.AllowUserToAddRows = false;
            dgvMaaslar.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMaaslar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 231, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMaaslar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMaaslar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaaslar.Dock = DockStyle.Bottom;
            dgvMaaslar.GridColor = Color.Gainsboro;
            dgvMaaslar.Location = new Point(0, 282);
            dgvMaaslar.Name = "dgvMaaslar";
            dgvMaaslar.ReadOnly = true;
            dgvMaaslar.RowHeadersWidth = 51;
            dgvMaaslar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaaslar.Size = new Size(900, 168);
            dgvMaaslar.TabIndex = 19;
            dgvMaaslar.CellClick += dgvMaaslar_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(216, 209, 247);
            label8.Location = new Point(714, 142);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 20;
            label8.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(714, 174);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(160, 66);
            txtAciklama.TabIndex = 21;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.Control;
            btnSil.Cursor = Cursors.Hand;
            btnSil.ForeColor = Color.FromArgb(229, 115, 115);
            btnSil.Location = new Point(776, 81);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(98, 39);
            btnSil.TabIndex = 22;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // cmbPersonel
            // 
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(87, 9);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(151, 28);
            cmbPersonel.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbPersonel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbYil);
            panel1.Controls.Add(cmbAy);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 24;
            // 
            // MaasHesaplamaFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.HKCore;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 450);
            Controls.Add(panel1);
            Controls.Add(btnSil);
            Controls.Add(txtAciklama);
            Controls.Add(label8);
            Controls.Add(dgvMaaslar);
            Controls.Add(btnListele);
            Controls.Add(btnKaydet);
            Controls.Add(btnHesapla);
            Controls.Add(lblNetMaas);
            Controls.Add(txtPrim);
            Controls.Add(txtMesai);
            Controls.Add(txtKesinti);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBrut);
            Name = "MaasHesaplamaFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MaasHesaplamaFormu";
            Load += MaasHesaplamaFormu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaaslar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBrut;
        private ComboBox cmbYil;
        private ComboBox cmbAy;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtKesinti;
        private TextBox txtMesai;
        private TextBox txtPrim;
        private Label lblNetMaas;
        private Button btnHesapla;
        private Button btnKaydet;
        private Button btnListele;
        private DataGridView dgvMaaslar;
        private Label label8;
        private TextBox txtAciklama;
        private Button btnSil;
        private ComboBox cmbPersonel;
        private Panel panel1;
    }
}