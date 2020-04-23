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
    public partial class AddBook : Form
    {
       
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate1_Click(object sender, EventArgs e)
        {
            try
            {
                int Bookid = int.Parse(tbBookId.Text);
                string Bookname = tbBookname.Text;
                int Copies = int.Parse(tbCopies.Text);
                string Status = tbstatus.Text;
                int Price = int.Parse(tbPrice.Text);
                string author = tbAuthor.Text;
             if( BusinessLogicLayer.AddBook(Bookid, Bookname, Copies, Status, Price, author))
                {
                    MessageBox.Show("book added successfully");
                }
             else
                {
                    MessageBox.Show("something went wrong");
                }
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void labelBookname_Click(object sender, EventArgs e)
        {

        }

        private void tbCopies_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBookId_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCopies_Click(object sender, EventArgs e)
        {

        }

        private void tbAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAuthor_Click(object sender, EventArgs e)
        {

        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void tbstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
