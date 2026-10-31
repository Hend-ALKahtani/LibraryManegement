using LibraryMangegment_BusnissLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManegement
{
    public partial class frmActiveBorrowingsList : Form
    {
        private DataTable _AllActiveBorrowings = clsBorrowing.GetAllActiveBorrowings();
        public frmActiveBorrowingsList()
        {
            InitializeComponent();
        }

        private void frmActiveBorrowingsList_Load(object sender, EventArgs e)
        {
            dgListBorrowings.DataSource = _AllActiveBorrowings;
            if (dgListBorrowings.Rows.Count > 0)
            {
                dgListBorrowings.Columns[0].HeaderText = "Borrowing ID";
                dgListBorrowings.Columns[2].HeaderText = "Book Title";
                dgListBorrowings.Columns[4].HeaderText = "Borrow Date";
                dgListBorrowings.Columns[5].HeaderText = "Due Date";
                dgListBorrowings.Columns[6].HeaderText = "Actual ReturnDate";
                dgListBorrowings.Columns[7].HeaderText = "Statues";
            }
        }

        private string _GetColumName()
        {
            string ColumnName = "";
            switch(cbFilter.Text)
            {
                case "Barcode":
                    {
                        ColumnName = "Barcode";
                        break;
                    }
                case "Borrowing ID":
                    {
                        ColumnName = "BorrowingID";
                        break;
                    }
                default:
                    {
                        ColumnName = "None";
                        break;
                    }
            }
            return ColumnName;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string columnName = _GetColumName();
            if(string.IsNullOrEmpty(txtFilter.Text) || columnName=="None")
            {
                _AllActiveBorrowings.DefaultView.RowFilter = "";
                return;
            }
            if(cbFilter.Text=="Barcode")
                _AllActiveBorrowings.DefaultView.RowFilter =string.Format("[{0}] like '{1}'");
            else
                _AllActiveBorrowings.DefaultView.RowFilter = string.Format("[{0}] ={1}");



        }

       private void _RefreshData()
        {
            _AllActiveBorrowings = clsBorrowing.GetAllActiveBorrowings();
            dgListBorrowings.DataSource = _AllActiveBorrowings;
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Borrowing ID")
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void returnCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BorrowingID = (int)dgListBorrowings.CurrentRow.Cells[0].Value;
            clsBorrowing borrowing = clsBorrowing.FindByBorrowingID(BorrowingID);
         
            using (frmReturnCopy frm = new frmReturnCopy(borrowing))
            {
               frm.ShowDialog();
                if(frm.DialogResult==DialogResult.OK)
                {
                    borrowing.Note = frm.Note;
                    borrowing.ReturnedByUserID = Global.CurrentUser.UserID;
                    borrowing.ActualReturnDATE = DateTime.ParseExact(frm.Date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    if (borrowing.ReturnCopy(frm.IsPaid))
                    {
                        _RefreshData();
                        MessageBox.Show("Return seccessfully");
                    }
                    else
                        MessageBox.Show("fialed to return copy");
                }
            }
        }

        private void frmActiveBorrowingsList_Click(object sender, EventArgs e)
        {

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string columnName = _GetColumName();
            if (string.IsNullOrEmpty(txtFilter.Text) || columnName == "None")
            {
                _AllActiveBorrowings.DefaultView.RowFilter = "";
                return;
            }
            if (cbFilter.Text == "Barcode")
                _AllActiveBorrowings.DefaultView.RowFilter = string.Format("[{0}] like '{1}'",columnName,txtFilter.Text.Trim());
            else
                _AllActiveBorrowings.DefaultView.RowFilter = string.Format("[{0}] ={1}",columnName,txtFilter.Text.Trim());
        }
    }
}

        
    
