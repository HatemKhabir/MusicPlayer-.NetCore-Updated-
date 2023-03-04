using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Xml.Linq;
using System.Windows.Forms;
using YoutubeExplode.Videos;
using YoutubeExplode.Playlists;


namespace MusicPlayer
{
    internal class YoutubeAPI
    {

        public String musicid;
        public string nextPageToken = "";
        public YouTubeService youtubeService = new YouTubeService(new BaseClientService.Initializer()
        {
            ApiKey = "AIzaSyD-eVP5VvZiygEc4yJ6wIZaAfaZdKjsWfk",
            ApplicationName = "testouta"
        });


        //method to change the time format returned by duration method
        private String timeReFormat(string time)
        {
            int minutes = 0;
            if (time.Contains("M"))
                minutes = int.Parse(time.Substring(2, time.IndexOf("M") - 2)); 
            int seconds = 0;
            if (time.Contains("S"))
                seconds = int.Parse(time.Substring(time.IndexOf("M") + 1, time.IndexOf("S") - time.IndexOf("M") - 1));

            return minutes.ToString() + ":"+seconds ;

        }
        //retrieve music id from search button
        public List<String> musicID(out List<string> thumbnails, out List<string> musicName, int numberofResults, string searchQuery)
        {
            List<string> songsId = new List<String>();
            musicName = new List<string>();
            thumbnails = new List<string>();

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = searchQuery; // Replace with your search term.
            searchListRequest.MaxResults = numberofResults;
            searchListRequest.Type = "video";
            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = searchListRequest.Execute();



            // Add each result to the appropriate list, and then display the lists of
            // matching videos, channels, and playlists.
            if (searchListResponse != null && searchListResponse.Items != null)
                foreach (var searchResult in searchListResponse.Items)
                {
                    var videoId = searchResult.Id.VideoId;
                    var videoRequest = youtubeService.Videos.List("snippet");
                    videoRequest.Id = videoId;
                    var videoResponse = videoRequest.Execute();
                    foreach (var video in videoResponse.Items)
                    {
                        if (video.Snippet.Thumbnails.Standard != null)
                        {
                            thumbnails.Add(video.Snippet.Thumbnails.Standard.Url);
                        }
                        else
                        {
                            thumbnails.Add("");
                        }
                        musicName.Add(video.Snippet.Title);
                    }
                    songsId.Add(videoId);
                }
            else MessageBox.Show("searchListResponse or searchListResponse.Items is not instantiated");

            return songsId;

        }

        //retreiving singluar music id to get thumbnail for home page
        public string singlemusicID(String searchQuery)
        {
            try
            {
                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = searchQuery; // Replace with your search term.
                searchListRequest.MaxResults = 1;

                // Call the search.list method to retrieve results matching the specified query term.
                var searchListResponse = searchListRequest.Execute();



                // Add each result to the appropriate list, and then display the lists of
                // matching videos, channels, and playlists.

                foreach (var searchResult in searchListResponse.Items)
                {
                    switch (searchResult.Id.Kind)
                    {
                        case "youtube#video":
                            musicid = searchResult.Id.VideoId;
                            break;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("bellehi ken saret haja , maandi manaamel , enzel ok taw tetaada , merci");
            }
            return musicid;
        }


        //get duration for video 
        public string duration(String musicID)
        {
            var videoRequest = youtubeService.Videos.List("contentDetails");
            videoRequest.Id = musicID;
            string duration = "";
            var videoResponse = videoRequest.Execute();

            foreach (var video in videoResponse.Items)
            {
                // The duration is in ISO 8601 format.
                duration = video.ContentDetails.Duration;
            }
            // Return the duration.
            return timeReFormat(duration);
        }
        public String thumbnail(String musicID)
        {
            try
            {
                return "https://img.youtube.com/vi/" + musicID + "/maxresdefault.jpg";
            }catch(Exception e)
            {
                MessageBox.Show("Errorr ! aleh ? mandroch . ");
            }
            return "";
        }
        public string VideoName(string musicId)
        {
            var videoListRequest = youtubeService.Videos.List("snippet");
            videoListRequest.Id = musicId;

            var videoListResponse = videoListRequest.Execute();

            if (videoListResponse.Items.Count > 0)
            {
                return videoListResponse.Items[0].Snippet.Title;
            }
            else
            {
                return "Video not found";
            }
        }
        //retrieve playlist song list
        public List<string> playlistVideoList(string playlistLink,out List<string> musicTitle,out List<string> thumbnails)
        {
            List<string> videoIds = new List<string>();
            musicTitle= new List<string>();
            thumbnails = new List<string>();
            if (playlistLink.Contains("youtube"))
            {
                try
                {
                    var playlistid = playlistLink.Substring(playlistLink.IndexOf('=') + 1, playlistLink.Length - playlistLink.IndexOf('=') - 1);
                    var playlistItemsListRequest = youtubeService.PlaylistItems.List("snippet");
                    playlistItemsListRequest.MaxResults = 50;
                    playlistItemsListRequest.PlaylistId = playlistid;
                    var playlistItemsListResponse = playlistItemsListRequest.Execute();
                    nextPageToken = playlistItemsListResponse.NextPageToken;

                    for (int i = 0; i < playlistItemsListResponse.Items.Count; i++)
                    {
                        PlaylistItem? playlistItem = playlistItemsListResponse.Items[i];
                        videoIds.Add(playlistItem.Snippet.ResourceId.VideoId);
                        if (playlistItem.Snippet.Thumbnails.Standard != null)
                        {
                            thumbnails.Add(playlistItem.Snippet.Thumbnails.Standard.Url);
                        }
                        else
                        {
                            thumbnails.Add("");
                        }
                        musicTitle.Add(playlistItem.Snippet.Title);
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("ch9awlek thot lien yasla7 ? ");
                }
            }
            else
            {
                try
                {
                    var playlistid = playlistLink;
                    var playlistItemsListRequest = youtubeService.PlaylistItems.List("snippet");
                    playlistItemsListRequest.MaxResults = 50;
                    playlistItemsListRequest.PlaylistId = playlistid;
                    var playlistItemsListResponse = playlistItemsListRequest.Execute();
                    nextPageToken = playlistItemsListResponse.NextPageToken;

                    for (int i = 0; i < playlistItemsListResponse.Items.Count; i++)
                    {
                        PlaylistItem? playlistItem = playlistItemsListResponse.Items[i];
                        videoIds.Add(playlistItem.Snippet.ResourceId.VideoId);
                        if (playlistItem.Snippet.Thumbnails.Standard != null)
                        {
                            thumbnails.Add(playlistItem.Snippet.Thumbnails.Standard.Url);
                        }
                        else
                        {
                            thumbnails.Add("");
                        }
                        musicTitle.Add(playlistItem.Snippet.Title);
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("ch9awlek thot lien yasla7 ? ");

                }
            }
            return videoIds;

        }
        public List<string> playlistLoadNextPage(string playlistLink, out List<string> musicTitle, out List<string> thumbnails)
        {
            
            List<string> videoIds = new List<string>();
            musicTitle = new List<string>();
            thumbnails = new List<string>();
            if (nextPageToken == null)
            {
                MessageBox.Show("All Videos of playlist were Loaded ! STOP CLICKING LOAD MORE . Thank You :)) ");
                return null;
            }
            if (playlistLink.Contains("youtube"))
            {
                try
                {
                    var playlistid = playlistLink.Substring(playlistLink.IndexOf('=') + 1, playlistLink.Length - playlistLink.IndexOf('=') - 1);
                    var playlistItemsListRequest = youtubeService.PlaylistItems.List("snippet");
                    playlistItemsListRequest.MaxResults = 50;
                    playlistItemsListRequest.PlaylistId = playlistid;
                    playlistItemsListRequest.PageToken = nextPageToken;
                    var playlistItemsListResponse = playlistItemsListRequest.Execute();

                    for (int i = 0; i < playlistItemsListResponse.Items.Count; i++)
                    {
                        PlaylistItem? playlistItem = playlistItemsListResponse.Items[i];
                        videoIds.Add(playlistItem.Snippet.ResourceId.VideoId);
                        if (playlistItem.Snippet.Thumbnails.Standard != null)
                        {
                            thumbnails.Add(playlistItem.Snippet.Thumbnails.Standard.Url);
                        }
                        else
                        {
                            thumbnails.Add("");
                        }
                        musicTitle.Add(playlistItem.Snippet.Title);
                    }
                    nextPageToken = playlistItemsListResponse.NextPageToken;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("awaaahh ");
                }
            }
            else
            {
                try
                {
                    var playlistid = playlistLink;
                    var playlistItemsListRequest = youtubeService.PlaylistItems.List("snippet");
                    playlistItemsListRequest.MaxResults = 50;
                    playlistItemsListRequest.PlaylistId = playlistid;
                    var playlistItemsListResponse = playlistItemsListRequest.Execute();
                    playlistItemsListRequest.PageToken = nextPageToken;
                    for (int i = 0; i < playlistItemsListResponse.Items.Count; i++)
                    {
                        PlaylistItem? playlistItem = playlistItemsListResponse.Items[i];
                        videoIds.Add(playlistItem.Snippet.ResourceId.VideoId);
                        if (playlistItem.Snippet.Thumbnails.Standard != null)
                        {
                            thumbnails.Add(playlistItem.Snippet.Thumbnails.Standard.Url);
                        }
                        else
                        {
                            thumbnails.Add("");
                        }
                        musicTitle.Add(playlistItem.Snippet.Title);
                    }
                    nextPageToken = playlistItemsListResponse.NextPageToken;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("awaaaah v2");
                }
            }
                
            return videoIds;

        }


    }
}
