namespace ikYonetimNYPProjesi.UI
{
    partial class RaporFormu
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
            cmbRapor = new ComboBox();
            label1 = new Label();
            btnGetir = new Button();
            dgvRapor = new DataGridView();
            grpFiltre = new GroupBox();
            dtpBit = new DateTimePicker();
            dtpBas = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            nudYil = new NumericUpDown();
            pnlMaas = new Panel();
            nudAy = new NumericUpDown();
            PnlTarih = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            grpFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYil).BeginInit();
            pnlMaas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAy).BeginInit();
            PnlTarih.SuspendLayout();
            SuspendLayout();
            // 
            // cmbRapor
            // 
            cmbRapor.FormattingEnabled = true;
            cmbRapor.Location = new Point(6, 47);
            cmbRapor.Name = "cmbRapor";
            cmbRapor.Size = new Size(186, 28);
            cmbRapor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(74, 58, 106);
            label1.Location = new Point(126, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Raporlar";
            // 
            // btnGetir
            // 
            btnGetir.Cursor = Cursors.Hand;
            btnGetir.FlatStyle = FlatStyle.Flat;
            btnGetir.ForeColor = Color.FromArgb(122, 104, 166);
            btnGetir.Location = new Point(57, 170);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(135, 40);
            btnGetir.TabIndex = 2;
            btnGetir.Text = "Raporu Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // dgvRapor
            // 
            dgvRapor.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRapor.BorderStyle = BorderStyle.None;
            dgvRapor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.GridColor = Color.Gainsboro;
            dgvRapor.Location = new Point(-6, 268);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.RowHeadersVisible = false;
            dgvRapor.RowHeadersWidth = 51;
            dgvRapor.Size = new Size(809, 170);
            dgvRapor.TabIndex = 3;
            // 
            // grpFiltre
            // 
            grpFiltre.BackColor = Color.FromArgb(237, 231, 246);
            grpFiltre.Controls.Add(label1);
            grpFiltre.Controls.Add(cmbRapor);
            grpFiltre.Controls.Add(btnGetir);
            grpFiltre.Location = new Point(12, 12);
            grpFiltre.Name = "grpFiltre";
            grpFiltre.Size = new Size(243, 216);
            grpFiltre.TabIndex = 4;
            grpFiltre.TabStop = false;
            grpFiltre.Text = "Filtreler";
            // 
            // dtpBit
            // 
            dtpBit.Location = new Point(-3, 86);
            dtpBit.Name = "dtpBit";
            dtpBit.Size = new Size(250, 27);
            dtpBit.TabIndex = 1;
            // 
            // dtpBas
            // 
            dtpBas.Location = new Point(-3, 41);
            dtpBas.Name = "dtpBas";
            dtpBas.Size = new Size(250, 27);
            dtpBas.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(74, 58, 106);
            label2.Location = new Point(91, 5);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 8;
            label2.Text = "Tarih";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(74, 58, 106);
            label3.Location = new Point(62, 5);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 9;
            label3.Text = "Yıl Seçiniz";
            // 
            // nudYil
            // 
            nudYil.Location = new Point(31, 46);
            nudYil.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudYil.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudYil.Name = "nudYil";
            nudYil.Size = new Size(150, 27);
            nudYil.TabIndex = 0;
            nudYil.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // pnlMaas
            // 
            pnlMaas.BackColor = Color.FromArgb(237, 231, 246);
            pnlMaas.Controls.Add(nudAy);
            pnlMaas.Controls.Add(nudYil);
            pnlMaas.Controls.Add(label3);
            pnlMaas.Location = new Point(279, 26);
            pnlMaas.Name = "pnlMaas";
            pnlMaas.Size = new Size(250, 125);
            pnlMaas.TabIndex = 10;
            // 
            // nudAy
            // 
            nudAy.Location = new Point(30, 88);
            nudAy.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudAy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAy.Name = "nudAy";
            nudAy.Size = new Size(150, 27);
            nudAy.TabIndex = 10;
            nudAy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // PnlTarih
            // 
            PnlTarih.BackColor = Color.FromArgb(237, 231, 246);
            PnlTarih.Controls.Add(dtpBas);
            PnlTarih.Controls.Add(label2);
            PnlTarih.Controls.Add(dtpBit);
            PnlTarih.Location = new Point(538, 26);
            PnlTarih.Name = "PnlTarih";
            PnlTarih.Size = new Size(250, 125);
            PnlTarih.TabIndex = 11;
            // 
            // RaporFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.HKCore;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(PnlTarih);
            Controls.Add(pnlMaas);
            Controls.Add(grpFiltre);
            Controls.Add(dgvRapor);
            Name = "RaporFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RaporFormu";
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            grpFiltre.ResumeLayout(false);
            grpFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYil).EndInit();
            pnlMaas.ResumeLayout(false);
            pnlMaas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAy).EndInit();
            PnlTarih.ResumeLayout(false);
            PnlTarih.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbRapor;
        private Label label1;
        private Button btnGetir;
        private DataGridView dgvRapor;
        private GroupBox grpFiltre;
        private DateTimePicker dtpBit;
        private DateTimePicker dtpBas;
        private Label label2;
        private Label label3;
        private NumericUpDown nudYil;
        private Panel pnlMaas;
        private Panel PnlTarih;
        private NumericUpDown nudAy;
    }
}