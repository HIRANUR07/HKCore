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
            ((System.ComponentModel.ISupportInitialize)dgvMaaslar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Personel :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 56);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 1;
            label2.Text = "Yıl";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 94);
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
            cmbYil.Location = new Point(107, 53);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(151, 28);
            cmbYil.TabIndex = 6;
            // 
            // cmbAy
            // 
            cmbAy.FormattingEnabled = true;
            cmbAy.Location = new Point(108, 94);
            cmbAy.Name = "cmbAy";
            cmbAy.Size = new Size(151, 28);
            cmbAy.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 165);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Brüt Maaş";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 200);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 9;
            label5.Text = "Kesinti";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 162);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 10;
            label6.Text = "Mesai";
            // 
            // label7
            // 
            label7.AutoSize = true;
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
            lblNetMaas.Location = new Point(380, 33);
            lblNetMaas.Name = "lblNetMaas";
            lblNetMaas.Size = new Size(72, 20);
            lblNetMaas.TabIndex = 15;
            lblNetMaas.Text = "Net Maaş";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(380, 85);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(94, 29);
            btnHesapla.TabIndex = 16;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(530, 85);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 17;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(665, 85);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 29);
            btnListele.TabIndex = 18;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // dgvMaaslar
            // 
            dgvMaaslar.AllowUserToAddRows = false;
            dgvMaaslar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaaslar.Location = new Point(12, 270);
            dgvMaaslar.Name = "dgvMaaslar";
            dgvMaaslar.ReadOnly = true;
            dgvMaaslar.RowHeadersWidth = 51;
            dgvMaaslar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaaslar.Size = new Size(885, 168);
            dgvMaaslar.TabIndex = 19;
            dgvMaaslar.CellClick += dgvMaaslar_CellClick;
          
            // 
            // label8
            // 
            label8.AutoSize = true;
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
            btnSil.Location = new Point(780, 85);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 22;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // cmbPersonel
            // 
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(97, 18);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(151, 28);
            cmbPersonel.TabIndex = 23;
            // 
            // MaasHesaplamaFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(cmbPersonel);
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
            Controls.Add(cmbAy);
            Controls.Add(cmbYil);
            Controls.Add(txtBrut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MaasHesaplamaFormu";
            Text = "MaasHesaplamaFormu";
            Load += MaasHesaplamaFormu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaaslar).EndInit();
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
    }
}