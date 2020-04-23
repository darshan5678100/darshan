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
    public partial class Transcation : Form
    {
        public Transcation()
        {
            InitializeComponent();
            try
            {
                gvTable.DataSource = BusinessLogicLayer.DisplayedBook(LoginUser1.Username).Tables[0];
                tbHeadLine.Text = "=====transcation books are===";
            }
            catch(Exception e)
            {
                MessageBox.Show("Exception!!");
            }
        }

        private void Transcation_Load(object sender, EventArgs e)
        {

        }
    }
}
