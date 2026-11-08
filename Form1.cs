using LibraryMangegment_BusnissLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManegement
{
    public partial class Form1 : Form
    {
        private frmLogIn _frmLogin;
        public Form1(frmLogIn frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }

        private void singOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmLogin.Show();
        }

        private void singOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmLogin.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm=new frmListUsers();
            frm.ShowDialog();
        }

        private void memberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListMembers frm=new frmListMembers();
            frm.ShowDialog();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBooks frm=new frmListBooks();
            frm.ShowDialog();
        }

        private void bookCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if(!string.Equals(Global.CurrentUser.UserName,"Admin",StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only Admin Can Edit This Screen");
                return;
            }
            frmListCopiesOfBooks frm = new frmListCopiesOfBooks();
            frm.ShowDialog();
        }

        private void borrowingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageBorrowing frm=new frmManageBorrowing();
            frm.ShowDialog();
        }

        private void returnCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActiveBorrowingsList frm=new frmActiveBorrowingsList(); 
            frm.ShowDialog();
        }

        private void paymentFinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFines frm=new frmFines();
            frm.ShowDialog();
        }

       
    }
}
