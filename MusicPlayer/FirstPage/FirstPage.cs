using AngleSharp.Dom;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Guna.UI2.WinForms.Enums;
using MusicPlayer.HomePage;
using System.Diagnostics;
using System.Windows.Forms;
using YoutubeExplode;

namespace MusicPlayer
{
    public partial class FirstPage : Form
    {
        private Form activeform = null;
        private Mainpage mainpage;
        public string apiKey { get; private set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public FirstPage()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            string filepath = "apikey.txt";
            string apikey = "";
            try
            {apiKey = File.ReadAllText(filepath);
                if (apiKey != "")
                {
                    if (ValidateApiKey(apiKey))
                    {
                        MessageBox.Show("API key is valid");
                        this.ApiKey.Visible = false;
                    }
                }
            }catch(FileNotFoundException)
            {
                MessageBox.Show("File Not Found , please enter New Api Key");

            }catch(IOException)
            {
                MessageBox.Show("Something Wrong Happened ");
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (ApiKey.Visible == true)
            {
                this.apiKey = ApiKey.Text; // Get the API key from the user input
                string filepath = "apikey.txt";
                if (ValidateApiKey(apiKey))
                {
                    MessageBox.Show("API key is valid");
                    using (StreamWriter sw = File.AppendText(filepath))
                    {
                        sw.WriteLine(apiKey);
                    }
                }
            else
            {
                MessageBox.Show("Invalid API key. Please enter a valid API key.");
            }
            }
            mainpage = new Mainpage(this);
            mainpage.Show();
            this.Hide();
            
        }
 
        private bool ValidateApiKey(string apiKey)
        {
            try
            {
                // Create a YouTubeService instance with the provided API key
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = apiKey,
                    ApplicationName = "Music Player"
                });

                // Attempt to make a simple API request to validate the key
                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.MaxResults = 1;
                searchListRequest.Execute();

                return true; // If the request succeeds, the API key is valid
            }
            catch
            {
                return false; // If there's an error, the API key is invalid
            }
        }

    }
}
