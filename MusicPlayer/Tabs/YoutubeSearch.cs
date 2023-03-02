using MusicPlayer.HomePage;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace MusicPlayer.Tabs
{
    public partial class YoutubeSearch : Form
    {
        private YoutubeAPI ytb = new YoutubeAPI();
        private MusicList ml;
        private Mainpage mp;
        
        public YoutubeSearch(Mainpage mainpage,MusicList mp)
        {
            InitializeComponent();
            this.ml = mp;
            this.mp = mainpage;
        }

        private async Task<string> streamInfo(string videoId)
        {
            
            try
            {
                var youtube = new YoutubeClient();
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync("https://youtube.com/watch?v=" + videoId);
                var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                return streamInfo.Url;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
             }
            return null;
        }
        private async void SearchButton(object sender, EventArgs e)
        {
            SearchResults.Controls.Clear();
            List<string> musiclist = new List<string>();
            List<string> musicTitle = new List<string>();
            List<string> duration = new List<string>();
            List<string> thumbnails = new List<string>();
            musiclist = ytb.musicID(out thumbnails, out musicTitle, 15, musicSearch.Text);
            LinkedList<string> streamInfosList = new LinkedList<string>();
            for (int i = 0; i < musiclist.Count - 1; i++)
            {
                searchResults results = new searchResults(ml,this)
                {
                    musicid = musiclist.ElementAt(i),
                    title = musicTitle.ElementAt(i),
                    duration = ytb.duration(musiclist.ElementAt(i)),
                    thumbnailURL = thumbnails.ElementAt(i),
                    streaminfo = await streamInfo(musiclist.ElementAt(i)),
                    videoNumber = i
                };
                results.changeImage(musicTitle[i]);
                SearchResults.Controls.Add(results);
                streamInfosList.AddLast(results.streaminfo);
            }
            ml.songs = streamInfosList;
            ml.songNames = musicTitle;
            mp.guna2ImageButton1.Enabled = true;
            mp.guna2ImageButton2.Enabled = true;
        }
    }
}
