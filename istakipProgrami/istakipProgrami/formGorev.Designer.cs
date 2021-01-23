namespace istakipProgrami
{
    partial class formGorev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGorev));
            this.lblBaslik = new MetroFramework.Controls.MetroLabel();
            this.txtBaslik = new MetroFramework.Controls.MetroTextBox();
            this.txtAciklama = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbGorevliler = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(99, 159);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(41, 19);
            this.lblBaslik.TabIndex = 14;
            this.lblBaslik.Text = "Başlık";
            // 
            // txtBaslik
            // 
            // 
            // 
            // 
            this.txtBaslik.CustomButton.Image = null;
            this.txtBaslik.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtBaslik.CustomButton.Name = "";
            this.txtBaslik.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBaslik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBaslik.CustomButton.TabIndex = 1;
            this.txtBaslik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBaslik.CustomButton.UseSelectable = true;
            this.txtBaslik.CustomButton.Visible = false;
            this.txtBaslik.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBaslik.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtBaslik.Lines = new string[0];
            this.txtBaslik.Location = new System.Drawing.Point(104, 181);
            this.txtBaslik.MaxLength = 32767;
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.PasswordChar = '\0';
            this.txtBaslik.PromptText = "Eklemek istediginz görevin başlığını giriniz";
            this.txtBaslik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBaslik.SelectedText = "";
            this.txtBaslik.SelectionLength = 0;
            this.txtBaslik.SelectionStart = 0;
            this.txtBaslik.ShortcutsEnabled = true;
            this.txtBaslik.Size = new System.Drawing.Size(237, 27);
            this.txtBaslik.TabIndex = 16;
            this.txtBaslik.UseSelectable = true;
            this.txtBaslik.WaterMark = "Eklemek istediginz görevin başlığını giriniz";
            this.txtBaslik.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBaslik.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAciklama
            // 
            // 
            // 
            // 
            this.txtAciklama.CustomButton.Image = null;
            this.txtAciklama.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.txtAciklama.CustomButton.Name = "";
            this.txtAciklama.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAciklama.CustomButton.TabIndex = 1;
            this.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAciklama.CustomButton.UseSelectable = true;
            this.txtAciklama.CustomButton.Visible = false;
            this.txtAciklama.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAciklama.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtAciklama.Lines = new string[0];
            this.txtAciklama.Location = new System.Drawing.Point(104, 292);
            this.txtAciklama.MaxLength = 32767;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.PromptText = "Göreve eklemek istediğiniz açıklamayı yazınız";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.SelectionLength = 0;
            this.txtAciklama.SelectionStart = 0;
            this.txtAciklama.ShortcutsEnabled = true;
            this.txtAciklama.Size = new System.Drawing.Size(291, 88);
            this.txtAciklama.TabIndex = 17;
            this.txtAciklama.UseSelectable = true;
            this.txtAciklama.WaterMark = "Göreve eklemek istediğiniz açıklamayı yazınız";
            this.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAciklama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(99, 211);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Görevli Ekle";
            // 
            // cmbGorevliler
            // 
            this.cmbGorevliler.FormattingEnabled = true;
            this.cmbGorevliler.ItemHeight = 23;
            this.cmbGorevliler.Location = new System.Drawing.Point(104, 234);
            this.cmbGorevliler.Name = "cmbGorevliler";
            this.cmbGorevliler.Size = new System.Drawing.Size(121, 29);
            this.cmbGorevliler.TabIndex = 19;
            this.cmbGorevliler.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(101, 269);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Açıklama Ekle";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Green;
            this.btnKaydet.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnKaydet.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKaydet.Location = new System.Drawing.Point(146, 406);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(206, 32);
            this.btnKaydet.Style = MetroFramework.MetroColorStyle.Green;
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(184, 16);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(121, 116);
            this.metroPanel1.TabIndex = 22;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(186, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(123, 25);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Görev Ekleyin ";
            // 
            // formGorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 476);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbGorevliler);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.lblBaslik);
            this.Name = "formGorev";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.formGorev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblBaslik;
        private MetroFramework.Controls.MetroTextBox txtBaslik;
        private MetroFramework.Controls.MetroTextBox txtAciklama;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbGorevliler;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}