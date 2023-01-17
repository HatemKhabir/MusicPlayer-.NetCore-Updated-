namespace MusicPlayer.Tabs
{
    partial class YoutubeToMP3
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
            this.videoLink = new Guna.UI2.WinForms.Guna2TextBox();
            this.DownloadButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // videoLink
            // 
            this.videoLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.videoLink.DefaultText = "";
            this.videoLink.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.videoLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.videoLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.videoLink.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.videoLink.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.videoLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.videoLink.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.videoLink.Location = new System.Drawing.Point(12, 202);
            this.videoLink.Name = "videoLink";
            this.videoLink.PasswordChar = '\0';
            this.videoLink.PlaceholderText = "Youtube Video Link or Video ID....";
            this.videoLink.SelectedText = "";
            this.videoLink.Size = new System.Drawing.Size(463, 36);
            this.videoLink.TabIndex = 0;
            // 
            // DownloadButton
            // 
            this.DownloadButton.AutoRoundedCorners = true;
            this.DownloadButton.BackColor = System.Drawing.Color.Transparent;
            this.DownloadButton.BorderRadius = 17;
            this.DownloadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DownloadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DownloadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DownloadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DownloadButton.FillColor = System.Drawing.Color.PapayaWhip;
            this.DownloadButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadButton.ForeColor = System.Drawing.Color.Black;
            this.DownloadButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DownloadButton.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadButton.Location = new System.Drawing.Point(481, 202);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(137, 36);
            this.DownloadButton.TabIndex = 1;
            this.DownloadButton.Text = "Download MP3";
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = global::MusicPlayer.Properties.Resources.ezgif_com_gif_maker__2_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(624, 388);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // YoutubeToMP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 388);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.videoLink);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YoutubeToMP3";
            this.Text = "YoutubeToMP3";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox videoLink;
        private Guna.UI2.WinForms.Guna2Button DownloadButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}