namespace istakipProgrami
{
    partial class formGorevli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGorevli));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(87, 23);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(151, 128);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(99, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(131, 25);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Görevli Ekleyin ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Green;
            this.btnKaydet.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnKaydet.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKaydet.Location = new System.Drawing.Point(56, 428);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(206, 32);
            this.btnKaydet.Style = MetroFramework.MetroColorStyle.Green;
            this.btnKaydet.TabIndex = 25;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(62, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 194);
            this.panel1.TabIndex = 26;
            // 
            // formGorevli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroPanel1);
            this.Name = "formGorevli";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.formGorevli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private System.Windows.Forms.Panel panel1;
    }
}