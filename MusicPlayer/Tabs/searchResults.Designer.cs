namespace MusicPlayer.Tabs
{
    partial class searchResults
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoThumbnail = new System.Windows.Forms.PictureBox();
            this.videoName = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.videoDuration = new System.Windows.Forms.Label();
            this.siticoneButton2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // videoThumbnail
            // 
            this.videoThumbnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.videoThumbnail.Location = new System.Drawing.Point(0, 0);
            this.videoThumbnail.Name = "videoThumbnail";
            this.videoThumbnail.Size = new System.Drawing.Size(124, 46);
            this.videoThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.videoThumbnail.TabIndex = 0;
            this.videoThumbnail.TabStop = false;
            // 
            // videoName
            // 
            this.videoName.AutoEllipsis = true;
            this.videoName.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoName.Location = new System.Drawing.Point(130, 11);
            this.videoName.Name = "videoName";
            this.videoName.Size = new System.Drawing.Size(272, 35);
            this.videoName.TabIndex = 1;
            this.videoName.Text = "Video Name ";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneButton1.FillColor = System.Drawing.Color.SteelBlue;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(520, 0);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(84, 46);
            this.siticoneButton1.TabIndex = 2;
            this.siticoneButton1.Text = "Download MP3";
            this.siticoneButton1.Click += new System.EventHandler(this.DownloadMP3);
            // 
            // videoDuration
            // 
            this.videoDuration.AutoSize = true;
            this.videoDuration.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoDuration.Location = new System.Drawing.Point(400, 15);
            this.videoDuration.Name = "videoDuration";
            this.videoDuration.Size = new System.Drawing.Size(38, 16);
            this.videoDuration.TabIndex = 3;
            this.videoDuration.Text = "00:00";
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.CustomBorderColor = System.Drawing.Color.MistyRose;
            this.siticoneButton2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneButton2.FillColor = System.Drawing.Color.SteelBlue;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(444, 0);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(76, 46);
            this.siticoneButton2.TabIndex = 4;
            this.siticoneButton2.Text = "Play MP3";
            this.siticoneButton2.Click += new System.EventHandler(this.PlayMp3);
            // 
            // searchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.videoDuration);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.videoName);
            this.Controls.Add(this.videoThumbnail);
            this.Name = "searchResults";
            this.Size = new System.Drawing.Size(604, 46);
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox videoThumbnail;
        private System.Windows.Forms.Label videoName;
        private Guna.UI2.WinForms.Guna2Button siticoneButton1;
        private System.Windows.Forms.Label videoDuration;
        private Guna.UI2.WinForms.Guna2Button siticoneButton2;
    }
}
