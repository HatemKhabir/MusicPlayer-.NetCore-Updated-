using MusicPlayer.HomePage;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;


namespace MusicPlayer.Tabs
{
    public partial class searchResults : UserControl
    {
        public string musicid { get; set; }
        public string title { get; set; }
        public int videoNumber { get; set; }
        public string streaminfo { get; set; }
        public string duration { get; set; }
        public string thumbnailURL { get; set; }
        private MusicList ml;
        private YoutubeAPI ytb = new YoutubeAPI();
        private Mainpage mainpage;
       

        public searchResults(MusicList ml,Mainpage mp)
        {
            InitializeComponent();
            this.ml = ml;
            this.mainpage = mp;
           
        }
    
        public void changeImage(String musicname)
        {if (thumbnailURL!="")
            this.videoThumbnail.Load(thumbnailURL);
            this.videoName.Text = musicname;
            this.videoDuration.Text = duration;


        }
        //Download Button Action
        private async void DownloadMP3(object sender, EventArgs e)
        {
            int attempts = 0;
            while (attempts < 3)
            {
                try
                {
                    var youtube = new YoutubeClient();
                    var streamManifest = await youtube.Videos.Streams.GetManifestAsync("https://youtube.com/watch?v=" + musicid);
                    var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

                    // Create an SaveFileDialog to select the download location
                    using (var SaveFileDialog = new SaveFileDialog())
                    {
                        SaveFileDialog.FileName = title+".mp3";
                        SaveFileDialog.Filter = "Music Files|*.mp3";
                        if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var filepath = SaveFileDialog.FileName;

                            // Download the stream to the selected file
                            var progress = new Progress<double>(p =>
                            {
                                mainpage.ProgressBar1.Value = (int)(p * 100);
                                mainpage.ProgressBar1.Update();
                            });
                            try
                            {
                                await youtube.Videos.Streams.DownloadAsync(streamInfo, filepath, progress);

                            }
                            catch (Exception ex)
                            {}
                            MessageBox.Show("Download Finished , check : " + filepath);
                            break;
                        }
                    }
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("retrying again , press ok . ");
                    attempts++;
                }
            }
            if (attempts == 3)
            {
                MessageBox.Show("All attempts failed");
            }

        }

        //Play as mp3 button
        private async void PlayMp3(object sender, EventArgs e)
        {
            int attempts = 0;
            while (attempts < 3)
            {
                try
                {
                    var youtube = new YoutubeClient();
                    var streamManifest = await youtube.Videos.Streams.GetManifestAsync("https://youtube.com/watch?v=" + musicid);
                    var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                    var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                    ml.player.URL = streamInfo.Url;
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("retrying...");
                    attempts++;
                }
            }
            if (attempts < 3)
            {
                ml.changeLabelsText(thumbnailURL, ytb.VideoName(musicid));
                ml.playingSong = videoNumber;
                ml.changeHomeForm();
            }
            else MessageBox.Show("something wrong happened");
            

        }

        private void searchResults_Load(object sender, EventArgs e)
        {

        }
    }
}
