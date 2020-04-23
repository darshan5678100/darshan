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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
            gvTable.DataSource = BusinessLogicLayer.Display().Tables[0];
        }

        private void UserHome_Load(object sender, EventArgs e)
        {

        }

        private void gvTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Book.BookId = (int)gvTable.CurrentRow.Cells[0].Value;
            Book.Bookname = gvTable.CurrentRow.Cells[1].Value.ToString();
            Book.Copies = (int)gvTable.CurrentRow.Cells[2].Value;
            Book.Status = gvTable.CurrentRow.Cells[3].Value.ToString();
            Book.Price = (int)gvTable.CurrentRow.Cells[4].Value;
            Book.Author = gvTable.CurrentRow.Cells[5].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Book.BookId > 0)
                {
                    if (BusinessLogicLayer.RequestedBook(Book.Bookname, LoginUser1.Username))
                    {
                        MessageBox.Show("book issued successfully");
                    }
                    else
                    {
                        MessageBox.Show("something went wrong");
                    }
                }
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Transcation home = new Transcation();
            home.Show();
        }
    }
}
