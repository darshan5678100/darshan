using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagmentSystem.bll;

namespace LibraryManagmentSystem
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
            tbHeadLine.Text = "==Welcome User==";
           
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusinessLogicLayer.UserLogin(tbUsername.Text, tbPassword.Text))
                {
                    UserHome home = new UserHome();
                    home.Show();
                    LoginUser1.Username = tbUsername.Text;
                }
                else
                    MessageBox.Show("invalid username or password");
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
