using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using LibraryManagmentSystem.bll;

namespace LibraryManagmentSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbHeadLine.Text = "Welcome to ADD Library";
            tbAdmin.Text = "Welcome to Admin Login page";
        }
       

        private void tbHeadLine_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(BusinessLogicLayer.AdminLogin(tbUsername.Text, tbPassword.Text))
            {
                Home HomePage = new Home();
                HomePage.Show();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            UserLogin Page = new UserLogin();
            Page.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserLoginForm login = new UserLoginForm();
            login.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
