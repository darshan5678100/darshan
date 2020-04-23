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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            tbHeadLine.Text = "Welcome User";
        }

        private void tbHeadLine_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusinessLogicLayer.UserRegistration(tbUsername.Text, tbPassword.Text, tbUsn.Text, TbBranch.Text, TbYear.Text, int.Parse(TbNum.Text)))
                {
                    MessageBox.Show("requsted successfully");
                }
                else
                    MessageBox.Show("something went wrong!!!");
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
