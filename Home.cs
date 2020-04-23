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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
      gvTable.DataSource= BusinessLogicLayer.Display().Tables[0];
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gvTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         Book.BookId= (int)gvTable.CurrentRow.Cells[0].Value;
            Book.Bookname = gvTable.CurrentRow.Cells[1].Value.ToString();
            Book.Copies= (int)gvTable.CurrentRow.Cells[2].Value;
            Book.Status= gvTable.CurrentRow.Cells[3].Value.ToString();
            Book.Price= (int)gvTable.CurrentRow.Cells[4].Value;
            Book.Author= gvTable.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook Add = new AddBook();
            Add.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(Book.BookId>0)
            {
                Remove RemoveBook = new Remove();
                RemoveBook.Show();
            }
            else
            {
                MessageBox.Show("select book to delete");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
          gvTable.DataSource=  BusinessLogicLayer.Display().Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(Book.BookId>0)
            {
                Update UpdateBook = new Update();
                UpdateBook.Show();
            }
            else
            {
                MessageBox.Show("select book to update!!");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            issue home = new issue();
            home.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
