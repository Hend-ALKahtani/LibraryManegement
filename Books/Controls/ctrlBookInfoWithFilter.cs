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
using static LibraryManegement.frmAddUpdateBook;

namespace LibraryManegement
{
    public partial class ctrlBookInfoWithFilter : UserControl
    {
       public bool FilterEnabled { get { return gbFilter.Enabled; }set { gbFilter.Enabled = value; } }
        public int BookID { get { return ctrlBookInfo1.BookID; } }
        public clsBook BookInfo { get { return ctrlBookInfo1.BookInfo; } }
       public bool EnabledFilterBook { set { gbFilter.Enabled = value; } get { return gbFilter.Enabled;} }
        public ctrlBookInfoWithFilter()
        {
            InitializeComponent();
           
        }

       public void LoadData(int BookID)
        {
            cbFilter.SelectedIndex = 0;
            
            txtFilter.Text = BookID.ToString();
            ctrlBookInfo1.LoadData(BookID);
        }
        private void ShowDataBack(object sender , SaveBookArg saveBookArg)
        {
            txtFilter.Text = saveBookArg.BookID.ToString();
            cbFilter.SelectedIndex = 0;
            ctrlBookInfo1.LoadData(saveBookArg.BookID);
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook();
            frm.SaveBook += ShowDataBack ;
            frm.ShowDialog();
        }

        private void _FindNow()
        {
            switch(cbFilter.Text)
            {
                case "Book ID":
                    {
                        ctrlBookInfo1.LoadData(Int32.Parse(txtFilter.Text.Trim()));
                        break;
                    }
                case "Book Title":
                    {
                        ctrlBookInfo1.LoadData(txtFilter.Text.Trim());
                        break;
                    }
                default:
                    break;
            }

        }
        private void btnSerach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                MessageBox.Show("Insert value to start search");
                return;
            }
             _FindNow();
               
        }

        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFilter.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilter, "Not Allowed Empty");
            }
            else
            {
                errorProvider1.SetError(txtFilter, null);
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text=="Book ID")
            {
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
            }
        }

        private void ctrlBookInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            txtFilter.Focus();
        }
    }
}
