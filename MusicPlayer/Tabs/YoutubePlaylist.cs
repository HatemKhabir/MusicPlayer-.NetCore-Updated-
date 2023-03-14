using MusicPlayer.HomePage;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicPlayer.Tabs
{
    public partial class YoutubePlaylist : Form
    {
        private YoutubeAPI ytb = new YoutubeAPI();
        public string nextPageToken = "";
        private MusicList ml;
        private List<string> musiclist = new List<string>();
        private List<string> musicTitle = new List<string>();
        private List<string> duration = new List<string>();
        private List<string> thumbnails = new List<string>();
        private LinkedList<string> streamInfoURL= new LinkedList<string>();
        private Mainpage mainpage;
       
        public YoutubePlaylist(MusicList ml, Mainpage mp)
        {
            InitializeComponent();
            this.ml = ml;
            this.mainpage = mp;
           
        }
        private async Task<string> streamInfo(string videoId)
        {

            try
            {
                var youtube = new YoutubeClient();
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync("https://youtube.com/watch?v=" + videoId);
                var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                return streamInfo.Url;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
            return null;
        }
        private async void ListMusic_Click(object sender, EventArgs e)
        {
            SearchResults.Controls.Clear();
          
            int numberofVideos = 0;
            musiclist = ytb.playlistVideoList(playListLink.Text, out musicTitle, out thumbnails);
            for (int i = 0; i < musiclist.Count; i++)
            {
                searchResults results = new searchResults(ml,mainpage)
                {
                    musicid = musiclist.ElementAt(i),
                    title = musicTitle.ElementAt(i),
                    duration = ytb.duration(musiclist.ElementAt(i)),
                    thumbnailURL = thumbnails.ElementAt(i),
                    streaminfo = await streamInfo(musiclist.ElementAt(i)),
                };
                results.changeImage(musicTitle[i]);
                SearchResults.Controls.Add(results);
                streamInfoURL.AddLast(results.streaminfo);
            }
            ml.songs = streamInfoURL;
            ml.songNames = musicTitle;
            mainpage.guna2ImageButton1.Enabled = true;
            mainpage.guna2ImageButton2.Enabled = true;
        }
        private void LoadMore_Click(object sender, EventArgs e)
        {
           
            musiclist = ytb.playlistLoadNextPage(playListLink.Text, out musicTitle, out thumbnails);
            if (musiclist != null)
                for (int i = 0; i < musiclist.Count; i++)
                {
                    searchResults results = new searchResults(ml,mainpage)
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
                guna2Button1.Enabled = false;

        }


        private async void DownloadAll_ClickAsync(object sender, EventArgs e)
        { MessageBox.Show("please , please, listen , after you download the first 50 songs , " +
            "press load more and download the next 50, " +
            "don't load all playlist and then press download ," +
            " that ain't working unlucko , "+
            "too much work to make it work "+
            " , thank you ! ");
            int attempts = 0;
            // Create an SaveFileDialog to select the download location
            using (var SaveFileDialog = new SaveFileDialog())
            {
                SaveFileDialog.Filter = "Music Files|*.mp3";
                SaveFileDialog.FileName = musicTitle.ElementAt(0)+".mp3";
                
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var directory = Path.GetDirectoryName(SaveFileDialog.FileName);
                    
                    for (int i = 0; i < musiclist.Count; i++)
                    {
                        var youtube = new YoutubeClient();
                        var musicId = musiclist[i];
                        attempts = 0;
                        while (attempts<3)
                        try
                        {
                            var streamManifest = await youtube.Videos.Streams.GetManifestAsync("https://youtube.com/watch?v=" + musicId);
                            var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                            var fileName = musicTitle.ElementAt(i) + ".mp3";
                            var filePath = Path.Combine(directory, fileName);

                            // Download the stream to the selected file
                            var progressHandler = new Progress<double>(p =>
                            {
                                mainpage.ProgressBar1.Value = (int)(p * 100);
                                mainpage.ProgressBar1.Update();
                            });                         
                            try
                            {
                                await youtube.Videos.Streams.DownloadAsync(streamInfo, filePath, progressHandler);
                                    break;
                                }
                            catch (Exception exp)
                            {
                            }
                        }catch(Exception ex)
                        {
                        }
                        attempts++;
                    }

                        MessageBox.Show("Download Finished ! شكرا على حسن المتباعة و الإنتباه و إلى اللقاء ! ");
                }
            }

        }

      
    }
}
