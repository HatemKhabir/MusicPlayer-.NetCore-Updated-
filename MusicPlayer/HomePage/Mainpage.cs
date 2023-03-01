using MusicPlayer.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.HomePage
{
    public partial class Mainpage : Form
    {

        static YoutubeAPI ytb = new YoutubeAPI();
        private bool collapsedMedia = false;
        private bool collapsedPlaylist = false;
        private bool collapsedDownload = false;
        private FirstPage firstpage;
        private Home homepage;
        private Form activeform = null;
        private YoutubePlaylist ytbPlaylist;
        public MusicList musiclist { get; }
        private YoutubeSearch ytbsearch;

        public Mainpage(FirstPage firstpage)
        {
            InitializeComponent();
            this.firstpage = firstpage;
            homepage = new Home();
            musiclist = new MusicList(this, homepage);
            ytbPlaylist = new YoutubePlaylist(musiclist);
            ytbsearch = new YoutubeSearch(musiclist);
            showForm(homepage);

        }



        public void showForm(Form child)
        {
            if (activeform != null)
                activeform.Hide();
            activeform = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            formPanel.Controls.Add(child);
            formPanel.Tag = child;
            child.BringToFront();
            child.Show();

        }
        private void Mainpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            firstpage.Show();
        }

        private void CloseButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void importMediaButton(object sender, EventArgs e)
        {
            showForm(musiclist);
        }

        private void LocalMusicButton(object sender, EventArgs e)
        {
            Point pt = new Point(0, 0);
            Point pt2 = new Point(0, 0);
            if (!collapsedMedia)
            {
                while (panel2.Size != panel2.MaximumSize)
                {
                    panel2.Height += 10;
                    pt.X = panel3.Location.X;
                    pt.Y = panel3.Location.Y + 10;
                    panel3.Location = pt;
                    pt2.X = panel4.Location.X;
                    pt2.Y = panel4.Location.Y + 10;
                    panel4.Location = pt2;

                }
                collapsedMedia = true;
            }
            else
            {
                while (panel2.Size != panel2.MinimumSize)
                {
                    panel2.Height -= 10;
                    pt.X = panel3.Location.X;
                    pt.Y = panel3.Location.Y - 10;
                    panel3.Location = pt;
                    pt2.X = pt.X;
                    pt2.Y = panel4.Location.Y - 10;
                    panel4.Location = pt2;

                }
                collapsedMedia = false;

            }


        }

        private void PlaylistButton(object sender, EventArgs e)
        {
            Point pt = new Point(0, 0);
            if (!collapsedPlaylist)
            {
                while (panel3.Size != panel3.MaximumSize)
                {
                    panel3.Height += 10;
                    pt.X = panel4.Location.X;
                    pt.Y = panel4.Location.Y + 10;
                    panel4.Location = pt;
                }
                collapsedPlaylist = true;

            }
            else
            {
                while (panel3.Size != panel3.MinimumSize)
                {
                    panel3.Height -= 10;
                    pt.X = panel4.Location.X;
                    pt.Y = panel4.Location.Y - 10;
                    panel4.Location = pt;
                }
                collapsedPlaylist = false;
            }
        }

        private void MP3Downloader(object sender, EventArgs e)
        {
            if (!collapsedDownload)
            {
                while (panel4.Size != panel4.MaximumSize)
                    panel4.Height += 10;
                collapsedDownload = true;
            }
            else
            {
                while (panel4.Size != panel4.MinimumSize)
                    panel4.Height -= 10;
                collapsedDownload = false;

            }

        }

        private void VolumeButtonClick(object sender, EventArgs e)
        {
            if (this.volumeTrackBar2.Visible == true)
                this.volumeTrackBar2.Visible = false;
            else this.volumeTrackBar2.Visible = true;
        }

        private void HomeButton(object sender, EventArgs e)
        {
            showForm(homepage);
        }



        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PauseButtonClick(object sender, EventArgs e)
        {
            musiclist.musicstop();
        }

        private void PlayButtonClick(object sender, EventArgs e)
        {
            musiclist.musicplay();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = musiclist.currentpostStr();
            slider.Value = (int)musiclist.currentpost();
        }

        private void volumeTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            musiclist.changeVolume(volumeTrackBar2.Value);
        }

        private void slider_Scroll(object sender, ScrollEventArgs e)
        {

            musiclist.changecurrentPost(slider.Value);
        }

        private void NextButtonClick(object sender, EventArgs e)
        {
            musiclist.musicNext();
        }

        private void PreviousButtonClick(object sender, EventArgs e)
        {
            musiclist.musicprevious();
        }

        private void SearchButton(object sender, EventArgs e)
        {
            showForm(ytbsearch);
        }

        private void youtubeToMp3_Click(object sender, EventArgs e)
        {
            YoutubeToMP3 ytbToMp3 = new YoutubeToMP3();
            showForm(ytbToMp3);
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            showForm(ytbPlaylist);
        }
    }
}