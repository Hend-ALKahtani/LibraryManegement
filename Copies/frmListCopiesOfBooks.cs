using LibraryMangegment_BusnissLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManegement.frmAddUpdateCopy;

namespace LibraryManegement
{
    public partial class frmListCopiesOfBooks : Form
    {
        private clsBookCopy copyInfo;
        public DataTable _AllCopies = clsBookCopy.GetAllCopies();
        public frmListCopiesOfBooks()
        {
            InitializeComponent();
        }

        private void frmListCopiesOfBooks_Load(object sender, EventArgs e)
        {
            dgListCopyies.DataSource = _AllCopies;
            lblCountRecords.Text = dgListCopyies.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if(dgListCopyies.Rows.Count>0)
            {
                dgListCopyies.Columns[0].HeaderText= "Copy ID";
                dgListCopyies.Columns[1].HeaderText = "Book ID";
                dgListCopyies.Columns[2].HeaderText = "Book Title";
                dgListCopyies.Columns[4].HeaderText = "Is Available";
                dgListCopyies.Columns[5].HeaderText = "Statuse Copy";
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text=="Copy ID" || cbFilter.Text=="Book ID")
                e.Handled=(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

       private string GetColumnName()
        {
            string ColumnName = "";
            switch(cbFilter.Text)
            {
                case "Copy ID":
                    {
                        ColumnName = "CopyID";
                        break;
                    }
                case "Book ID":
                    {
                        ColumnName = "BookID";
                        break;
                    }
                case "Book Title":
                    {
                        ColumnName = "Book Title";
                        break;
                    }
                case "Copy Status":
                    {
                        ColumnName = "CopyStatus";
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
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string ColumnName = GetColumnName();
           if(ColumnName=="None" || string.IsNullOrEmpty(txtFilter.Text.Trim()))
            {
                _AllCopies.DefaultView.RowFilter = "";
                lblCountRecords.Text = dgListCopyies.Rows.Count.ToString();
                return;
            }
            if (cbFilter.Text == "Copy ID" || cbFilter.Text == "Book ID")
            {
                _AllCopies.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilter.Text.Trim());

            }
            else
                _AllCopies.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'",ColumnName,txtFilter.Text.Trim());

            lblCountRecords.Text = dgListCopyies.Rows.Count.ToString();

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.Text=="None")
            {
                txtFilter.Visible = false;
                cbIsVailable.Visible = false;
                _AllCopies.DefaultView.RowFilter = "";
                lblCountRecords.Text = dgListCopyies.Rows.Count.ToString();
                return;
            }
            if(cbFilter.Text!="Is Available")
            {
                txtFilter.Visible = true;
                txtFilter.Text = "";
                cbIsVailable.Visible = false;
            }
            else
            {
                cbIsVailable.Visible = true;
                cbIsVailable.SelectedIndex = 0;
                txtFilter.Visible = false;
            }
        }

      private void _RefreshData(object sender, SaveCopyArg e)
        {
            _AllCopies = clsBookCopy.GetAllCopies();
            dgListCopyies.DataSource= _AllCopies;
            lblCountRecords.Text = dgListCopyies.Rows.Count.ToString();
        }
        private void addCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCopy frm = new frmAddUpdateCopy();
            frm.CopySave += _RefreshData;
            frm.ShowDialog();
        }

        private void deleteCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this copy","Confirm",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if(clsBookCopy.Delete((int)dgListCopyies.CurrentRow.Cells[0].Value))
                {
                    _RefreshData(null, null);
                    MessageBox.Show("Delete successfuly");
                }
                else
                {
                    MessageBox.Show("failed to delete");
                }
            }
        }

        private void showCopyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopyDetails frm = new frmCopyDetails((int)dgListCopyies.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        /*
         private void updateCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCopy frm = new frmAddUpdateCopy((int)dgListCopyies.CurrentRow.Cells[0].Value);
            frm.CopySave += _RefreshData;

            frm.ShowDialog();
        }
         */

        private void renewBracodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FindBookCopy();
            if (copyInfo != null)
            {
                if(copyInfo.RenewBarcode())
                {
                    _RefreshData(null, null);
                    MessageBox.Show("Renew Barcode successfuly");
                }
                else
                {
                    MessageBox.Show("Faild to Renew Barcode");
                }
            }
        }

        private void _FindBookCopy()
        {
            int CopyID = (int)dgListCopyies.CurrentRow.Cells[0].Value;
            copyInfo = clsBookCopy.Find(CopyID);
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            _FindBookCopy();
            if (copyInfo != null)
            {
                bool isMatch = SecurityManager.IsAthorized(typeof(clsBookCopy), nameof(clsBookCopy.RenewBarcode), Global.CurrentUser.UserName);
                renewBracodeToolStripMenuItem.Enabled = copyInfo.Condition == clsBookCopy.enStatusCopy.Damage && copyInfo.IsAvailable && isMatch;
                updateCopyToolStripMenuItem.Enabled = copyInfo.IsAvailable;
            
            }
        }
        private void Status_DoubleClick(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem=(ToolStripMenuItem)sender;
            _FindBookCopy();
            switch(clickedItem.Text)
            {
                case "New":
                    {
                        copyInfo.UpdateStatusOfCopy(clsBookCopy.enStatusCopy.New);
                        break;
                    }
                case "Good":
                    {
                        copyInfo.UpdateStatusOfCopy(clsBookCopy.enStatusCopy.Good);
                        break;
                    }
                case "Damage":
                    {
                        copyInfo.UpdateStatusOfCopy(clsBookCopy.enStatusCopy.Damage);
                        break;
                    }
            }
            _RefreshData(null, null);
        
        }
    }
}
