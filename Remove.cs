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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
            tbBookIdr.Text = Book.BookId.ToString();
            tbBooknamer.Text = Book.Bookname;
            tbcopiesr.Text = Book.Copies.ToString();
            tbstatusr.Text = Book.Status;
            tbPriceR.Text = Book.Price.ToString();
            tbauthorR.Text = Book.Author;
        }

        private void Remove_Load(object sender, EventArgs e)
        {

        }

        private void labelBookId_Click(object sender, EventArgs e)
        {

        }

        private void labelCopies_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate1_Click(object sender, EventArgs e)
        {
            try
            {
                if (BusinessLogicLayer.delete(Book.BookId))
                {
                    MessageBox.Show("book removed successfully");
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

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
