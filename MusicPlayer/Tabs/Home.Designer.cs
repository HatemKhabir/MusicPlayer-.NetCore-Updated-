namespace MusicPlayer.Tabs
{
    partial class Home
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.nowPlayingLabel = new System.Windows.Forms.Label();
            this.playingSongLabel = new System.Windows.Forms.Label();
            this.imgVisualiza = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgVisualiza)).BeginInit();
            this.SuspendLayout();
            // 
            // nowPlayingLabel
            // 
            this.nowPlayingLabel.AutoSize = true;
            this.nowPlayingLabel.BackColor = System.Drawing.Color.Transparent;
            this.nowPlayingLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nowPlayingLabel.ForeColor = System.Drawing.Color.Transparent;
            this.nowPlayingLabel.Location = new System.Drawing.Point(214, 387);
            this.nowPlayingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nowPlayingLabel.Name = "nowPlayingLabel";
            this.nowPlayingLabel.Size = new System.Drawing.Size(118, 23);
            this.nowPlayingLabel.TabIndex = 7;
            this.nowPlayingLabel.Text = "Now Playing -";
            this.nowPlayingLabel.Visible = false;
            // 
            // playingSongLabel
            // 
            this.playingSongLabel.AutoEllipsis = true;
            this.playingSongLabel.AutoSize = true;
            this.playingSongLabel.BackColor = System.Drawing.Color.Transparent;
            this.playingSongLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.playingSongLabel.ForeColor = System.Drawing.Color.Transparent;
            this.playingSongLabel.Location = new System.Drawing.Point(331, 387);
            this.playingSongLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playingSongLabel.Name = "playingSongLabel";
            this.playingSongLabel.Size = new System.Drawing.Size(115, 23);
            this.playingSongLabel.TabIndex = 8;
            this.playingSongLabel.Text = "-   Song Name";
            this.playingSongLabel.Visible = false;
            // 
            // imgVisualiza
            // 
            this.imgVisualiza.BackColor = System.Drawing.Color.Transparent;
            this.imgVisualiza.CustomizableEdges = customizableEdges1;
            this.imgVisualiza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgVisualiza.Enabled = false;
            this.imgVisualiza.Image = global::MusicPlayer.Properties.Resources.output_onlinegiftools;
            this.imgVisualiza.ImageRotate = 0F;
            this.imgVisualiza.Location = new System.Drawing.Point(0, 0);
            this.imgVisualiza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgVisualiza.Name = "imgVisualiza";
            this.imgVisualiza.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.imgVisualiza.Size = new System.Drawing.Size(728, 448);
            this.imgVisualiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVisualiza.TabIndex = 9;
            this.imgVisualiza.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 448);
            this.Controls.Add(this.nowPlayingLabel);
            this.Controls.Add(this.playingSongLabel);
            this.Controls.Add(this.imgVisualiza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.imgVisualiza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label nowPlayingLabel;
        public System.Windows.Forms.Label playingSongLabel;
        public Guna.UI2.WinForms.Guna2PictureBox imgVisualiza;
    }
}