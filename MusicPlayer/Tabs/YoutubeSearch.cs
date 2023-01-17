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
    public partial class YoutubeSearch : Form
    {
        private YoutubeAPI ytb = new YoutubeAPI();
        private MusicList ml;
        public YoutubeSearch(MusicList mp)
        {
            InitializeComponent();
            this.ml = mp;
        }

        private void SearchButton(object sender, EventArgs e)
        {
            SearchResults.Controls.Clear();
            List<string> musiclist = new List<string>();
            List<string> musicTitle = new List<string>();
            List<string> duration = new List<string>();
            List<string> thumbnails = new List<string>();
            musiclist = ytb.musicID(out thumbnails, out musicTitle, 15, musicSearch.Text);
            for (int i = 0; i < musiclist.Count - 1; i++)
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
    }
}
