using Guna.UI2.WinForms.Enums;
using MusicPlayer.Login_and_signup;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FirstPage : Form
    {
        bool mousedown;
        private Point offset;
        private Login Loginform;
        private Form activeform = null;

        public FirstPage()
        {
            InitializeComponent();
            Loginform= new Login(this);
            showForm(Loginform);
        }
        
        public void showForm(Form child)
        {
            if (activeform != null)
                activeform.Hide();
            activeform = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            formPanel.Controls.Add(child);
            formPanel.Tag = child;
            child.BringToFront();
            child.Show();

        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Account Created Successfully , Please use your information to login to your Account ! ", "Signup Successfull",MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
            }
            
             

        }

      
        }
    }
