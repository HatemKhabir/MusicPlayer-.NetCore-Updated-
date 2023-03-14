using Guna.UI2.WinForms.Enums;
using MusicPlayer.HomePage;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FirstPage : Form
    {
        private Form activeform = null;
        private Mainpage mainpage;
        public FirstPage()
        {
            InitializeComponent();
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage = new Mainpage(this);
            mainpage.Show();

        }
    }
    }
