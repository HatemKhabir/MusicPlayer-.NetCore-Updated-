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
        private YoutubeSearch search;
       

        public searchResults(MusicList ml, YoutubeSearch sch)
        {
            InitializeComponent();
            this.ml = ml;
            this.search = sch;
           
        }
        public searchResults(MusicList ml)
        {
            InitializeComponent();
            this.ml = ml;

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
            var youtube = new YoutubeClient();
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync("https://youtube.com/watch?v=" + musicid);
            var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

            // Create an SaveFileDialog to select the download location
            using (var SaveFileDialog = new SaveFileDialog())
            {
                SaveFileDialog.Filter = "Music Files|*.mp3";
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filepath = SaveFileDialog.FileName;

                    // Download the stream to the selected file
                    var progress = new Progress<double>(p => search.ProgressBar1.Value = (int)(p * 100));
                    try
                    {
                        await youtube.Videos.Streams.DownloadAsync(streamInfo, filepath, progress);

                    }catch(Exception ex)
                    {
                        MessageBox.Show("wallah manaaref aleh , base lvideo is not found donc it's OUT OF MY HAND . ");
                    }
                    MessageBox.Show("Download Finished , check : " + filepath);
                }
            }

        }

        //Play as mp3 button
        private async void PlayMp3(object sender, EventArgs e)
        {
            var youtube = new YoutubeClient();
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync("https://youtube.com/watch?v=" + musicid);
            var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
            var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
            ml.player.URL = streamInfo.Url;
            ml.changeLabelsText(thumbnailURL, ytb.VideoName(musicid));
            ml.playingSong = videoNumber;
            ml.changeHomeForm();
            MessageBox.Show(ml.playingSong.ToString());

        }

        private void searchResults_Load(object sender, EventArgs e)
        {

        }
    }
}
