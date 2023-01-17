using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Login_and_signup
{
    public partial class Signup : Form
    {
        private Login loginForm;
        private FirstPage mainPage;
        public Signup(Login loginForm, FirstPage mainpage)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.mainPage = mainpage;

        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }
    }
}
