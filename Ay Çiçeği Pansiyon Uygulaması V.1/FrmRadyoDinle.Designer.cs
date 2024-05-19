namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    partial class FrmRadyoDinle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRadyoDinle));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BtnDurdur = new System.Windows.Forms.Button();
            this.BtnCal = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel1.Location = new System.Drawing.Point(1153, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 27);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kanal1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel2.Location = new System.Drawing.Point(1153, 103);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(86, 27);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Kanal2";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel3.Location = new System.Drawing.Point(1153, 186);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(85, 27);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Kanal3";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.BackColor = System.Drawing.SystemColors.Info;
            this.BtnCıkıs.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCıkıs.Location = new System.Drawing.Point(1052, 611);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(193, 99);
            this.BtnCıkıs.TabIndex = 9;
            this.BtnCıkıs.Text = "Çıkış";
            this.BtnCıkıs.UseVisualStyleBackColor = false;
            this.BtnCıkıs.Click += new System.EventHandler(this.BtnCıkıs_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.BackColor = System.Drawing.SystemColors.Info;
            this.BtnBrowse.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowse.Location = new System.Drawing.Point(830, 611);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(193, 99);
            this.BtnBrowse.TabIndex = 8;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnDurdur
            // 
            this.BtnDurdur.BackColor = System.Drawing.SystemColors.Info;
            this.BtnDurdur.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDurdur.Location = new System.Drawing.Point(597, 611);
            this.BtnDurdur.Name = "BtnDurdur";
            this.BtnDurdur.Size = new System.Drawing.Size(193, 99);
            this.BtnDurdur.TabIndex = 7;
            this.BtnDurdur.Text = "Durdur";
            this.BtnDurdur.UseVisualStyleBackColor = false;
            this.BtnDurdur.Click += new System.EventHandler(this.Btndurdur_Click);
            // 
            // BtnCal
            // 
            this.BtnCal.BackColor = System.Drawing.SystemColors.Info;
            this.BtnCal.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCal.Location = new System.Drawing.Point(362, 611);
            this.BtnCal.Name = "BtnCal";
            this.BtnCal.Size = new System.Drawing.Size(193, 99);
            this.BtnCal.TabIndex = 6;
            this.BtnCal.Text = "Çal";
            this.BtnCal.UseVisualStyleBackColor = false;
            this.BtnCal.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.PeachPuff;
            this.txtFilePath.Location = new System.Drawing.Point(17, 494);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(460, 81);
            this.txtFilePath.TabIndex = 5;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(17, 19);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(773, 358);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            // 
            // FrmRadyoDinle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1257, 722);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.BtnCıkıs);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.BtnDurdur);
            this.Controls.Add(this.BtnCal);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRadyoDinle";
            this.Text = "RadyoDinle";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button BtnCıkıs;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Button BtnDurdur;
        private System.Windows.Forms.Button BtnCal;
        private System.Windows.Forms.TextBox txtFilePath;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}