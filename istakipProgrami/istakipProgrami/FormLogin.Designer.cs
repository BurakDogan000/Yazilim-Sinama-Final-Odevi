namespace istakipProgrami
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            this.panelLogin = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnKayit = new MetroFramework.Controls.MetroButton();
            this.lblKullaniciAdi = new MetroFramework.Controls.MetroLabel();
            this.lblSifre = new MetroFramework.Controls.MetroLabel();
            this.txtKullaniciAdi = new MetroFramework.Controls.MetroTextBox();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Green;
            this.btnGiris.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGiris.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGiris.Location = new System.Drawing.Point(82, 295);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(206, 32);
            this.btnGiris.Style = MetroFramework.MetroColorStyle.Green;
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseSelectable = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogin.BackgroundImage")));
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogin.HorizontalScrollbarBarColor = true;
            this.panelLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.panelLogin.HorizontalScrollbarSize = 10;
            this.panelLogin.Location = new System.Drawing.Point(128, 24);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(121, 123);
            this.panelLogin.TabIndex = 9;
            this.panelLogin.VerticalScrollbarBarColor = true;
            this.panelLogin.VerticalScrollbarHighlightOnWheel = false;
            this.panelLogin.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.metroLabel1.Location = new System.Drawing.Point(97, 151);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(182, 25);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Hesabınıza Giriş  Yapın";
            // 
            // btnKayit
            // 
            this.btnKayit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnKayit.BackColor = System.Drawing.Color.Green;
            this.btnKayit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnKayit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnKayit.ForeColor = System.Drawing.Color.White;
            this.btnKayit.Location = new System.Drawing.Point(82, 333);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(206, 32);
            this.btnKayit.Style = MetroFramework.MetroColorStyle.Green;
            this.btnKayit.TabIndex = 11;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseSelectable = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(80, 185);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(79, 19);
            this.lblKullaniciAdi.TabIndex = 13;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(80, 238);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(35, 19);
            this.lblSifre.TabIndex = 14;
            this.lblSifre.Text = "Şifre";
            // 
            // txtKullaniciAdi
            // 
            // 
            // 
            // 
            this.txtKullaniciAdi.CustomButton.Image = null;
            this.txtKullaniciAdi.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtKullaniciAdi.CustomButton.Name = "";
            this.txtKullaniciAdi.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtKullaniciAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKullaniciAdi.CustomButton.TabIndex = 1;
            this.txtKullaniciAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKullaniciAdi.CustomButton.UseSelectable = true;
            this.txtKullaniciAdi.CustomButton.Visible = false;
            this.txtKullaniciAdi.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtKullaniciAdi.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtKullaniciAdi.Lines = new string[0];
            this.txtKullaniciAdi.Location = new System.Drawing.Point(82, 208);
            this.txtKullaniciAdi.MaxLength = 32767;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.PromptText = "Kullanıcı Adınızı Giriniz";
            this.txtKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.SelectionLength = 0;
            this.txtKullaniciAdi.SelectionStart = 0;
            this.txtKullaniciAdi.ShortcutsEnabled = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(206, 27);
            this.txtKullaniciAdi.TabIndex = 15;
            this.txtKullaniciAdi.UseSelectable = true;
            this.txtKullaniciAdi.WaterMark = "Kullanıcı Adınızı Giriniz";
            this.txtKullaniciAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKullaniciAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSifre
            // 
            // 
            // 
            // 
            this.txtSifre.CustomButton.Image = null;
            this.txtSifre.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.txtSifre.CustomButton.Name = "";
            this.txtSifre.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSifre.CustomButton.TabIndex = 1;
            this.txtSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSifre.CustomButton.UseSelectable = true;
            this.txtSifre.CustomButton.Visible = false;
            this.txtSifre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSifre.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtSifre.Lines = new string[0];
            this.txtSifre.Location = new System.Drawing.Point(82, 260);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.PromptText = "Sifrenizi Giriniz";
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(206, 27);
            this.txtSifre.TabIndex = 16;
            this.txtSifre.UseSelectable = true;
            this.txtSifre.WaterMark = "Sifrenizi Giriniz";
            this.txtSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 383);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.btnGiris);
            this.Name = "formLogin";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnGiris;
        private MetroFramework.Controls.MetroPanel panelLogin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnKayit;
        private MetroFramework.Controls.MetroLabel lblKullaniciAdi;
        private MetroFramework.Controls.MetroLabel lblSifre;
        private MetroFramework.Controls.MetroTextBox txtKullaniciAdi;
        private MetroFramework.Controls.MetroTextBox txtSifre;
    }
}

