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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            tbBookIdU.Text = Book.BookId.ToString();
            tbBooknameU.Text = Book.Bookname;
            tbCopiesU.Text = Book.Copies.ToString();
            tbstatusU.Text = Book.Status;
            tbPriceU.Text = Book.Price.ToString();
            tbauthoru.Text = Book.Author;
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void labelAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(tbBookIdU.Text);
                string Name = tbBooknameU.Text;
                int Copies = int.Parse(tbCopiesU.Text);
                string Status = tbstatusU.Text;
                int Price = int.Parse(tbPriceU.Text);
                string Author = tbauthoru.Text;
                if (BusinessLogicLayer.UpdateBook(Id, Name, Copies, Status, Price, Author))
                {
                    MessageBox.Show("updated successfully!!!");
                }
                else
                {
                    MessageBox.Show("Oops something went wrong");
                }
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }
    }
}
