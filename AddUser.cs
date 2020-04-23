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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
          gvAddUser.DataSource=  BusinessLogicLayer.DisplayUser().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void gvAddUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            User.Username = gvAddUser.CurrentRow.Cells[0].Value.ToString();
            User.Password = gvAddUser.CurrentRow.Cells[1].Value.ToString();

           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (User.Username != null)
                {
                    if (BusinessLogicLayer.Adduser(User.Username, User.Password))
                    {
                        MessageBox.Show("user added successfully");
                    }
                    else
                    {
                        MessageBox.Show("something went wrong");
                    }
                }
                else
                    MessageBox.Show("select user to add");
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
