using MusicPlayer.HomePage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Login_and_signup
{
    public partial class Login : Form
    {
        private Signup signup;
        private FirstPage mainpage;
        private Mainpage homepage;
        public Login(Form mainForm)
        {
            InitializeComponent();
            this.mainpage = (FirstPage)mainForm;
            signup = new Signup(this, (FirstPage)mainForm);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            mainpage.Hide();
            homepage = new Mainpage(mainpage);
            homepage.Show();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            mainpage.showForm(signup);
        }
    }
}

