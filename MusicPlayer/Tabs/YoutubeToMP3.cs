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
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace MusicPlayer.Tabs
{
    public partial class YoutubeToMP3 : Form
    {

        public YoutubeToMP3()
        {
            InitializeComponent();
        }
        //using if or else to treat case where he use a full link or id seperately.
        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            var youtube = new YoutubeClient();
            if (videoLink.Text.Contains("youtu"))
            {
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoLink.Text);
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
                        MessageBox.Show("Download Finished , Location :  " + filepath);
                    }
                }
            }
            else
            {
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync("https://youtube.com/watch?v=" + videoLink.Text);
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
                        MessageBox.Show("Download Finished , Location :  " + filepath);
                    }
                }
            }


        }
    }
}
