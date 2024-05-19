namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    partial class FrmGazeteler
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnHurriyet = new System.Windows.Forms.Button();
            this.btnMilliyet = new System.Windows.Forms.Button();
            this.btnHaberturk = new System.Windows.Forms.Button();
            this.btnSozcu = new System.Windows.Forms.Button();
            this.btnFanatik = new System.Windows.Forms.Button();
            this.btnOnedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 84);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1247, 655);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnHurriyet
            // 
            this.btnHurriyet.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHurriyet.Location = new System.Drawing.Point(89, 4);
            this.btnHurriyet.Name = "btnHurriyet";
            this.btnHurriyet.Size = new System.Drawing.Size(145, 74);
            this.btnHurriyet.TabIndex = 1;
            this.btnHurriyet.Text = "Hürriyet";
            this.btnHurriyet.UseVisualStyleBackColor = true;
            this.btnHurriyet.Click += new System.EventHandler(this.btnHurriyet_Click);
            // 
            // btnMilliyet
            // 
            this.btnMilliyet.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMilliyet.Location = new System.Drawing.Point(254, 4);
            this.btnMilliyet.Name = "btnMilliyet";
            this.btnMilliyet.Size = new System.Drawing.Size(145, 74);
            this.btnMilliyet.TabIndex = 2;
            this.btnMilliyet.Text = "Milliyet";
            this.btnMilliyet.UseVisualStyleBackColor = true;
            this.btnMilliyet.Click += new System.EventHandler(this.btnMilliyet_Click);
            // 
            // btnHaberturk
            // 
            this.btnHaberturk.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaberturk.Location = new System.Drawing.Point(627, 4);
            this.btnHaberturk.Name = "btnHaberturk";
            this.btnHaberturk.Size = new System.Drawing.Size(145, 74);
            this.btnHaberturk.TabIndex = 3;
            this.btnHaberturk.Text = "HaberTürk";
            this.btnHaberturk.UseVisualStyleBackColor = true;
            this.btnHaberturk.Click += new System.EventHandler(this.btnHaberturk_Click);
            // 
            // btnSozcu
            // 
            this.btnSozcu.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSozcu.Location = new System.Drawing.Point(437, 4);
            this.btnSozcu.Name = "btnSozcu";
            this.btnSozcu.Size = new System.Drawing.Size(145, 74);
            this.btnSozcu.TabIndex = 4;
            this.btnSozcu.Text = "Sözcü";
            this.btnSozcu.UseVisualStyleBackColor = true;
            this.btnSozcu.Click += new System.EventHandler(this.btnSozcu_Click);
            // 
            // btnFanatik
            // 
            this.btnFanatik.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFanatik.Location = new System.Drawing.Point(820, 4);
            this.btnFanatik.Name = "btnFanatik";
            this.btnFanatik.Size = new System.Drawing.Size(145, 74);
            this.btnFanatik.TabIndex = 5;
            this.btnFanatik.Text = "Fanatik";
            this.btnFanatik.UseVisualStyleBackColor = true;
            this.btnFanatik.Click += new System.EventHandler(this.btnFanatik_Click);
            // 
            // btnOnedio
            // 
            this.btnOnedio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnedio.Location = new System.Drawing.Point(1004, 4);
            this.btnOnedio.Name = "btnOnedio";
            this.btnOnedio.Size = new System.Drawing.Size(145, 74);
            this.btnOnedio.TabIndex = 6;
            this.btnOnedio.Text = "Onedio";
            this.btnOnedio.UseVisualStyleBackColor = true;
            this.btnOnedio.Click += new System.EventHandler(this.btnOnedio_Click);
            // 
            // FrmGazeteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.btnOnedio);
            this.Controls.Add(this.btnFanatik);
            this.Controls.Add(this.btnSozcu);
            this.Controls.Add(this.btnHaberturk);
            this.Controls.Add(this.btnMilliyet);
            this.Controls.Add(this.btnHurriyet);
            this.Controls.Add(this.webBrowser1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGazeteler";
            this.Text = "Gazeteler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnHurriyet;
        private System.Windows.Forms.Button btnMilliyet;
        private System.Windows.Forms.Button btnHaberturk;
        private System.Windows.Forms.Button btnSozcu;
        private System.Windows.Forms.Button btnFanatik;
        private System.Windows.Forms.Button btnOnedio;
    }
}