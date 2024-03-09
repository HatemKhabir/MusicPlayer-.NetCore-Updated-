namespace MusicPlayer.Tabs
{
    partial class MusicList
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			musicListTable = new Guna.UI2.WinForms.Guna2DataGridView();
			Play = new DataGridViewButtonColumn();
			No = new DataGridViewTextBoxColumn();
			Title = new DataGridViewTextBoxColumn();
			Location = new DataGridViewTextBoxColumn();
			openFileDialog1 = new OpenFileDialog();
			guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
			((System.ComponentModel.ISupportInitialize)musicListTable).BeginInit();
			SuspendLayout();
			// 
			// musicListTable
			// 
			dataGridViewCellStyle1.BackColor = Color.White;
			musicListTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
			dataGridViewCellStyle2.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			musicListTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			musicListTable.ColumnHeadersHeight = 27;
			musicListTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			musicListTable.Columns.AddRange(new DataGridViewColumn[] { Play, No, Title, Location });
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.White;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
			dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			musicListTable.DefaultCellStyle = dataGridViewCellStyle3;
			musicListTable.Enabled = false;
			musicListTable.GridColor = Color.FromArgb(231, 229, 255);
			musicListTable.Location = new Point(0, 49);
			musicListTable.Margin = new Padding(5, 5, 5, 5);
			musicListTable.Name = "musicListTable";
			musicListTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
			musicListTable.RowHeadersVisible = false;
			musicListTable.RowHeadersWidth = 51;
			musicListTable.Size = new Size(833, 523);
			musicListTable.TabIndex = 5;
			musicListTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
			musicListTable.ThemeStyle.AlternatingRowsStyle.Font = null;
			musicListTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
			musicListTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
			musicListTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
			musicListTable.ThemeStyle.BackColor = Color.White;
			musicListTable.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
			musicListTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
			musicListTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
			musicListTable.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			musicListTable.ThemeStyle.HeaderStyle.ForeColor = Color.White;
			musicListTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			musicListTable.ThemeStyle.HeaderStyle.Height = 27;
			musicListTable.ThemeStyle.ReadOnly = false;
			musicListTable.ThemeStyle.RowsStyle.BackColor = Color.White;
			musicListTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			musicListTable.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			musicListTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
			musicListTable.ThemeStyle.RowsStyle.Height = 22;
			musicListTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
			musicListTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
			musicListTable.Visible = false;
			musicListTable.CellContentClick += PlayFromImportedMusic;
			musicListTable.CellPainting += AddingPlayImageInTable;
			// 
			// Play
			// 
			Play.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Play.FillWeight = 8.350253F;
			Play.HeaderText = "Play";
			Play.MinimumWidth = 6;
			Play.Name = "Play";
			Play.Resizable = DataGridViewTriState.True;
			// 
			// No
			// 
			No.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			No.FillWeight = 8.350253F;
			No.HeaderText = "No";
			No.MinimumWidth = 6;
			No.Name = "No";
			No.Resizable = DataGridViewTriState.True;
			// 
			// Title
			// 
			Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Title.HeaderText = "Title";
			Title.MinimumWidth = 6;
			Title.Name = "Title";
			Title.Resizable = DataGridViewTriState.True;
			// 
			// Location
			// 
			Location.HeaderText = "Location";
			Location.MinimumWidth = 6;
			Location.Name = "Location";
			Location.Visible = false;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.Filter = "\"MP3 files(*.mp3)|*.mp3";
			openFileDialog1.Multiselect = true;
			openFileDialog1.FileOk += openFileDialog1_FileOk_1;
			// 
			// guna2GradientButton1
			// 
			guna2GradientButton1.Animated = true;
			guna2GradientButton1.AutoRoundedCorners = true;
			guna2GradientButton1.BackColor = Color.Transparent;
			guna2GradientButton1.BorderRadius = 26;
			guna2GradientButton1.CustomizableEdges = customizableEdges1;
			guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
			guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
			guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
			guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			guna2GradientButton1.FillColor = Color.Snow;
			guna2GradientButton1.FillColor2 = Color.Gray;
			guna2GradientButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			guna2GradientButton1.ForeColor = Color.White;
			guna2GradientButton1.Location = new Point(-21, -5);
			guna2GradientButton1.Margin = new Padding(5, 5, 5, 5);
			guna2GradientButton1.Name = "guna2GradientButton1";
			guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
			guna2GradientButton1.Size = new Size(261, 54);
			guna2GradientButton1.TabIndex = 6;
			guna2GradientButton1.Text = "Import Music";
			guna2GradientButton1.UseTransparentBackground = true;
			guna2GradientButton1.Click += ImportMusicButton;
			// 
			// MusicList
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(832, 571);
			Controls.Add(guna2GradientButton1);
			Controls.Add(musicListTable);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(5, 5, 5, 5);
			Name = "MusicList";
			Text = "MusicList";
			((System.ComponentModel.ISupportInitialize)musicListTable).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        public Guna.UI2.WinForms.Guna2DataGridView musicListTable;
        private DataGridViewButtonColumn Play;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Location;
    }
}