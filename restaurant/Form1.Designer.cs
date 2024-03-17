namespace restaurant
{
    partial class frmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbKullanici = new ComboBox();
            textSifre = new TextBox();
            btnGiris = new Button();
            btnCikis = new Button();
            lbkullanici = new Label();
            label1 = new Label();
            titleForm1 = new Label();
            SuspendLayout();
            // 
            // cbKullanici
            // 
            cbKullanici.Cursor = Cursors.Hand;
            cbKullanici.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKullanici.FormattingEnabled = true;
            cbKullanici.Location = new Point(757, 278);
            cbKullanici.Name = "cbKullanici";
            cbKullanici.Size = new Size(292, 33);
            cbKullanici.TabIndex = 0;
            // 
            // textSifre
            // 
            textSifre.Cursor = Cursors.Hand;
            textSifre.Location = new Point(757, 414);
            textSifre.Name = "textSifre";
            textSifre.Size = new Size(292, 31);
            textSifre.TabIndex = 1;
            textSifre.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.DarkOrange;
            btnGiris.Cursor = Cursors.Hand;
            btnGiris.Location = new Point(757, 559);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(107, 40);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giris";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += button1_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.DarkOrange;
            btnCikis.Cursor = Cursors.Hand;
            btnCikis.Location = new Point(931, 559);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(118, 40);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkıs";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += button2_Click;
            // 
            // lbkullanici
            // 
            lbkullanici.AutoSize = true;
            lbkullanici.ForeColor = SystemColors.ButtonFace;
            lbkullanici.Location = new Point(597, 281);
            lbkullanici.Name = "lbkullanici";
            lbkullanici.Size = new Size(134, 25);
            lbkullanici.TabIndex = 4;
            lbkullanici.Text = "Kullanıcı adı : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(644, 414);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 5;
            label1.Text = "Şifre : ";
            label1.Click += label1_Click;
            // 
            // titleForm1
            // 
            titleForm1.AutoSize = true;
            titleForm1.BackColor = SystemColors.ActiveCaptionText;
            titleForm1.Font = new Font("Segoe UI Historic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleForm1.ForeColor = Color.Firebrick;
            titleForm1.Location = new Point(675, 146);
            titleForm1.Name = "titleForm1";
            titleForm1.Size = new Size(353, 46);
            titleForm1.TabIndex = 6;
            titleForm1.Text = "Oturum Açma Formu";
            // 
            // frmGiris
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1605, 684);
            Controls.Add(titleForm1);
            Controls.Add(label1);
            Controls.Add(lbkullanici);
            Controls.Add(btnCikis);
            Controls.Add(btnGiris);
            Controls.Add(textSifre);
            Controls.Add(cbKullanici);
            Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yetkili Girişi";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbKullanici;
        private TextBox textSifre;
        private Button btnGiris;
        private Button btnCikis;
        private Label lbkullanici;
        private Label label1;
        private Label titleForm1;
    }
}
