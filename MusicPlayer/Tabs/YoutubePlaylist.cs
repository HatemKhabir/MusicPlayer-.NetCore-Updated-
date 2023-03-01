using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Tabs
{
    public partial class YoutubePlaylist : Form
    {private YoutubeAPI ytb=new YoutubeAPI();
        public string nextPageToken = "";
        private MusicList ml ;
        public YoutubePlaylist(MusicList ml)
        {
            InitializeComponent();
            this.ml = ml;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            SearchResults.Controls.Clear();
            List<string> musiclist = new List<string>();
            List<string> musicTitle = new List<string>();
            List<string> duration = new List<string>();
            List<string> thumbnails = new List<string>();
            int numberofVideos=0;
            musiclist = ytb.playlistVideoList(playListLink.Text,out musicTitle, out thumbnails);
            for (int i = 0; i < musiclist.Count; i++)
            {
                searchResults results = new searchResults(ml)
                {
                    musicid = musiclist.ElementAt(i),
                    title = musicTitle.ElementAt(i),
                    duration = ytb.duration(musiclist.ElementAt(i)),
                    thumbnailURL = thumbnails.ElementAt(i),
                };
                results.changeImage(musicTitle[i]);
                SearchResults.Controls.Add(results);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            List<string> musiclist = new List<string>();
            List<string> musicTitle = new List<string>();
            List<string> duration = new List<string>();
            List<string> thumbnails = new List<string>();
            musiclist = ytb.playlistLoadNextPage(playListLink.Text, out musicTitle, out thumbnails);
            if (musiclist!=null)
            for (int i = 0; i < musiclist.Count; i++)
            {
                searchResults results = new searchResults(ml)
                {
                    musicid = musiclist.ElementAt(i),
                    title = musicTitle.ElementAt(i),
                    duration = ytb.duration(musiclist.ElementAt(i)),
                    thumbnailURL = thumbnails.ElementAt(i),
                };
                results.changeImage(musicTitle[i]);
                SearchResults.Controls.Add(results);
            }
            else 
                guna2Button1.Enabled= false;

        }
    }
}
