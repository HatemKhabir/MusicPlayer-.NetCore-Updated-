using System.ComponentModel;
using MusicPlayer.HomePage;
using WMPLib;

namespace MusicPlayer.Tabs
{
    public partial class MusicList : Form
    {   public WindowsMediaPlayer player { get; set; }
        private int i = 0;
        private Mainpage mainpage;
        private Home home;
        private YoutubeAPI ytb = new YoutubeAPI();
        private List<String> ytbresults;
        public string musicname { get; set; }
        public LinkedList<String> songs { get; set; }
        public List<string> songNames { get; set; }
        public int playingSong { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public MusicList(Mainpage mp, Home home)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            player=new WindowsMediaPlayer();
            player.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            this.mainpage = mp;
            this.home = home;
        }
        private Image img = Image.FromFile(@"C:\Users\Hatem\Downloads\play.jpg");


        private void PlayFromImportedMusic(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                player.URL = musicListTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                home.nowPlayingLabel.Visible = true;
                home.playingSongLabel.Visible = true;
                mainpage.nowPlayingLabel.Visible = true;
                mainpage.playingSongLabel.Visible = true;
                mainpage.playingSongLabel.Text = musicListTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                home.playingSongLabel.Text = musicListTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                playingSong = e.RowIndex;
                musicname = musicListTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                mainpage.showForm(home);
                changeimgVisual(musicname);
            }

        }

        public void changeHomeForm()
        {
            mainpage.showForm(home);
        }
        public async void changeimgVisual(String musicname)
        {
            try
            {
                home.imgVisualiza.Load(ytb.thumbnail(ytb.singlemusicID(musicname)));
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                await musicplay();
            }
        }
        public void musicstop()
        {
            player.controls.pause();
        }


        public async Task musicplay()
        {
            var tcs = new TaskCompletionSource<bool>();
            player.PlayStateChange += (newState) =>
            {
                if (newState == (int)WMPPlayState.wmppsReady)
                {
                    tcs.TrySetResult(true);
                }
            };
            try
            {
                player.controls.play();
            }catch(Exception ex)
            {
                   
            }
            await tcs.Task;

        }

        public void changeVolume(int volume)
        {
            player.settings.volume = volume;
        }
        public void changecurrentPost(int post)
        {
            player.controls.currentPosition = (double)post;
        }
        public void musicNext()
        {
            if (playingSong < songs.Count - 1)
                playingSong++;
            else
                playingSong = 0;
            player.URL = songs.ElementAt(playingSong);
            if(musicListTable.Enabled==true)
            musicname = musicListTable.Rows[playingSong].Cells[2].Value.ToString();
            else 
                musicname =songNames.ElementAt(playingSong);
            home.playingSongLabel.Text = musicname;
            mainpage.playingSongLabel.Text = musicname;
            changeimgVisual(musicname);

        }
        public void musicprevious()
        {
            if (playingSong > 0)
                playingSong--;
            else playingSong = songs.Count - 1;

            player.URL = songs.ElementAt(playingSong);

            if (musicListTable.Enabled == true)
                musicname = musicListTable.Rows[playingSong].Cells[2].Value.ToString();
            else
                musicname = songNames.ElementAt(playingSong); 
            home.playingSongLabel.Text = musicname;
            mainpage.playingSongLabel.Text = musicname;
            changeimgVisual(musicname);

        }
        public String currentpostStr()
        {
            return player.controls.currentPositionString;
        }
        public double currentpost()
        {
            return player.controls.currentPosition;
        }
        private void AddingPlayImageInTable(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = 20;
                var h = 20;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.play, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void ImportMusicButton(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            songs = new LinkedList<string>();
            playingSong = 0;
            musicListTable.Visible = true;
            //string icon = @"c:\users\hatem\downloads\play.jpg";
            //image img = image.fromfile(icon);
            foreach (var item in openFileDialog1.FileNames)
            {

                FileInfo f1 = new FileInfo(item);
                musicListTable.Rows.Add(new object[]
                {"P",++i,f1.Name,"00:00:00",f1.FullName});

                if (songs == null)
                    songs.AddFirst(f1.FullName);
                else
                    songs.AddLast(f1.FullName);
            }

            mainpage.guna2ImageButton1.Enabled = true;
            mainpage.guna2ImageButton2.Enabled= true;
        }
      

        public void changeLabelsText(string thumbnailurl, string musicName)
        {
            mainpage.playingSongLabel.Text = musicName;
            home.playingSongLabel.Text = musicName;
            home.imgVisualiza.Load(thumbnailurl);
        }
        private async void Player_PlayStateChange(int newState)
        {
            mainpage.nowPlayingLabel.Visible = true;
            mainpage.playingSongLabel.Visible = true;
            home.playingSongLabel.Visible = true;
            home.nowPlayingLabel.Visible = true;
            mainpage.nowPlayingLabel.Text = player.status.Split(' ')[0];
            home.imgVisualiza.Enabled = player.status.ToLower().Contains("playing");
            home.nowPlayingLabel.Text = player.status.Split(' ')[0];
            if (newState == (int)WMPPlayState.wmppsPlaying)
            {
                mainpage.slider.Maximum = (int)player.currentMedia.duration;
                mainpage.slider.Value = (int)player.controls.currentPosition;
            }
            else if (newState == (int)WMPPlayState.wmppsStopped)
            {
                await musicplay();
            }
            else if (newState == (int)WMPPlayState.wmppsMediaEnded)
                musicNext();
            else if (newState == (int)WMPPlayState.wmppsReady)
            {
                await musicplay();
            }


        }
    }
}
