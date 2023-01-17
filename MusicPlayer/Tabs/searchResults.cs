using YoutubeExplode;
using YoutubeExplode.Videos.Streams;


namespace MusicPlayer.Tabs
{
    public partial class searchResults : UserControl
    {
        public string musicid { get; set; }
        public string title { get; set; }
        public string duration { get; set; }
        public string thumbnailURL { get; set; }
        private MusicList mp;
        private YoutubeAPI ytb = new YoutubeAPI();
        public searchResults(MusicList mp)
        {
            InitializeComponent();
            this.mp = mp;
        }
        public void changeImage(String musicname)
        {
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
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, filepath);
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
            mp.player.URL = streamInfo.Url;
            mp.changeLabelsText(thumbnailURL, ytb.VideoName(musicid));
            mp.changeHomeForm();

        }

    }
}
