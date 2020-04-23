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
    public partial class issue : Form
    {
        public static string bookname;
        public static string user;
        public issue()
        {
            try
            {
                InitializeComponent();
                gvTable.DataSource = BusinessLogicLayer.Issue().Tables[0];
            }
            catch(Exception e)
            {
                MessageBox.Show("something went wrong");
            }

        }

        private void issue_Load(object sender, EventArgs e)
        {

        }

        private void gvTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         bookname = gvTable.CurrentRow.Cells[0].Value.ToString();
             user = gvTable.CurrentRow.Cells[1].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BusinessLogicLayer.Transcation(bookname, user))
            {
                MessageBox.Show("book issued successfully");
            }
            else
            {
                MessageBox.Show("something went wrong");
            }
        }
    }
}
