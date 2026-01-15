namespace ikYonetimNYPProjesi.UI
{
    partial class SifreDegistirFormu
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
            txtEskiSifre = new TextBox();
            txtYeniSifreTekrar = new TextBox();
            txtYeniSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDegistir = new Button();
            SuspendLayout();
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(449, 68);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.Size = new Size(125, 27);
            txtEskiSifre.TabIndex = 0;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(449, 207);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(125, 27);
            txtYeniSifreTekrar.TabIndex = 1;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(449, 136);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(125, 27);
            txtYeniSifre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 75);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 3;
            label1.Text = "Eski Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 143);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Yeni Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 214);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 5;
            label3.Text = "Yeni Şifre Tekrar";
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(334, 294);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(137, 29);
            btnDegistir.TabIndex = 6;
            btnDegistir.Text = "Şifre Değiştir";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // SifreDegistirFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.HKCore;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDegistir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtYeniSifre);
            Controls.Add(txtYeniSifreTekrar);
            Controls.Add(txtEskiSifre);
            Name = "SifreDegistirFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SifreDegistir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEskiSifre;
        private TextBox txtYeniSifreTekrar;
        private TextBox txtYeniSifre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDegistir;
    }
}