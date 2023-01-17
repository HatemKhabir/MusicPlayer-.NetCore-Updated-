namespace MusicPlayer.Tabs
{
    partial class YoutubeSearch
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
            this.siticoneButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.musicSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.siticonePictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SearchResults = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.DarkCyan;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(498, 12);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(104, 25);
            this.siticoneButton1.TabIndex = 0;
            this.siticoneButton1.Text = "Search";
            this.siticoneButton1.Click += new System.EventHandler(this.SearchButton);
            // 
            // musicSearch
            // 
            this.musicSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.musicSearch.DefaultText = "";
            this.musicSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.musicSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.musicSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.musicSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.musicSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.musicSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.musicSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.musicSearch.Location = new System.Drawing.Point(45, 12);
            this.musicSearch.Name = "musicSearch";
            this.musicSearch.PasswordChar = '\0';
            this.musicSearch.PlaceholderText = "Search Music Name...";
            this.musicSearch.SelectedText = "";
            this.musicSearch.Size = new System.Drawing.Size(447, 25);
            this.musicSearch.TabIndex = 1;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.BorderRadius = 200;
            this.siticonePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = global::MusicPlayer.Properties.Resources.music_note;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(40, 25);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 2;
            this.siticonePictureBox1.TabStop = false;
            // 
            // SearchResults
            // 
            this.SearchResults.AutoScroll = true;
            this.SearchResults.Location = new System.Drawing.Point(-1, 43);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.Size = new System.Drawing.Size(625, 346);
            this.SearchResults.TabIndex = 3;
            // 
            // YoutubeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 388);
            this.Controls.Add(this.SearchResults);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.musicSearch);
            this.Controls.Add(this.siticoneButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YoutubeSearch";
            this.Text = "YoutubeSearch";
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button siticoneButton1;
        private Guna.UI2.WinForms.Guna2TextBox musicSearch;
        private Guna.UI2.WinForms.Guna2PictureBox siticonePictureBox1;
        private System.Windows.Forms.FlowLayoutPanel SearchResults;
    }
}
