using LibraryMangegment_BusnissLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManegement.frmAddUpdateBorrowings;

namespace LibraryManegement
{
    public partial class frmManageBorrowing : Form
    {
        private DataTable _AllBorrowings = clsBorrowing.GetAllBorrowing();
        public frmManageBorrowing()
        {
            InitializeComponent();
        }

       
        private void frmManageBorrowing_Load(object sender, EventArgs e)
        {
            dgListBorrowings.DataSource = _AllBorrowings;
            if(dgListBorrowings.Rows.Count>0)
            {
                dgListBorrowings.Columns[0].HeaderText = "Borrowing ID";
                dgListBorrowings.Columns[2].HeaderText = "Book Title";
                dgListBorrowings.Columns[4].HeaderText = "Borrow Date";
                dgListBorrowings.Columns[5].HeaderText = "Due Date";
                dgListBorrowings.Columns[6].HeaderText = "Actual ReturnDate";
                dgListBorrowings.Columns[7].HeaderText = "Statues";
            }
        }

      private string GetColumnName()
        {
            string ColumnName = "";
            switch(cbFilter.Text)
            {
                case "Borrowing ID":
                    {
                        ColumnName = "BorrowingID";
                        break;
                    }
                case "Copy ID":
                    {
                        ColumnName = "CopyID";
                        break;
                    }
                case "Book Title":
                    {
                        ColumnName = "BookTitle";
                        break;
                    }
                case "Statues":
                    {
                        ColumnName = "Statues";
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
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "Book Title" && cbFilter.Text != "Statues")
            {
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ColumnName=GetColumnName();
            if(string.IsNullOrEmpty(textBox1.Text.Trim()) || ColumnName=="None")
            {
                _AllBorrowings.DefaultView.RowFilter = "";
                return;
            }
            if (ColumnName == "CopyID" || ColumnName == "BorrowingID")
            {
                _AllBorrowings.DefaultView.RowFilter = string.Format("[{0}]={1}", ColumnName, textBox1.Text.Trim());
            }
            else
                _AllBorrowings.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColumnName, textBox1.Text.Trim());
        }

        /*
         private void updateBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBorrowings frm = new frmAddUpdateBorrowings((int)dgListBorrowings.CurrentRow.Cells[0].Value);
            frm.SaveBorrowing += ShowUpdateData;
            frm.ShowDialog();
        }
         
         */

        private bool CheckingIsExistRow()
        {
            if (dgListBorrowings.Rows.Count == 0 || dgListBorrowings.CurrentRow == null)
            {
                MessageBox.Show("There isn't Record");
                return false;
            }
            return true;
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
          if(dgListBorrowings.Rows.Count==0 || dgListBorrowings.CurrentRow==null)
            {
                e.Cancel=true;
                return;
            }
            int BorrowingID = (int)dgListBorrowings.CurrentRow.Cells[0].Value;
            clsBorrowing borrowing = clsBorrowing.FindByBorrowingID(BorrowingID);
            if (borrowing == null)
            {
                MessageBox.Show("this BorrowingRecord not found");
                return;
            }
            clsMember member = clsMember.Find(borrowing.MemberID);
            bool MemberHasUnpaidFines=member.IsMemberHasUnPaidFines();
            bool IsCopyIssued = borrowing.IsCopyIssued();
            bool IsDueDateOver = borrowing.IsDueDateOver;
            extendDueDateToolStripMenuItem.Enabled = (IsCopyIssued && !MemberHasUnpaidFines &&!IsDueDateOver);
            bool isAuthorizedToReportLost=SecurityManager.IsAthorized(typeof(clsBorrowing), nameof(clsBorrowing.ReportLostCopy), Global.CurrentUser.UserName);
            bool CanReport = borrowing.CanReportAsLost();
            reportToolStripMenuItem.Enabled = (isAuthorizedToReportLost && CanReport);
        }

        private void extendDueDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckingIsExistRow())
            {
                return;
            }
            int BorrowingID = (int)dgListBorrowings.CurrentRow.Cells[0].Value;
            clsBorrowing borrowing = clsBorrowing.FindByBorrowingID(BorrowingID);
            if (borrowing != null)
            {
                borrowing.DueDate = borrowing.DueDate.AddDays(10);
                if(borrowing.ExtendDueDate())
                {
                    ShowUpdateData(null, null);
                    MessageBox.Show("extend duedate successfuly");
                }
                else
                {
                    MessageBox.Show("failed to extend duedate");
                }
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckingIsExistRow())
            {
                return;
            }
            int BorrowingID = (int)dgListBorrowings.CurrentRow.Cells[0].Value;
            clsBorrowing borrowing = clsBorrowing.FindByBorrowingID(BorrowingID);
            if (borrowing == null)
            {
                MessageBox.Show("this BorrowingRecord not found");
                return;
            }
          if(borrowing.ReportLostCopy(Global.CurrentUser.UserID,false,borrowing.FineOfReportLost))
            {
                ShowUpdateData(null, null);
                MessageBox.Show($"Reporting lost Copy Succefuly,must pay Fine Of Losting Copy{borrowing.FineOfReportLost}");
            }
          //payment must be in Fines Screen
            /*
              if (MessageBox.Show("do you want pay now or later ","Confirm",MessageBoxButtons.YesNo)==DialogResult.Yes)
             {

                 if(borrowing.ReportLostCopy(Global.CurrentUser.UserID, true, 10))
                 {
                     ShowUpdateData(null, null);
                     MessageBox.Show("Update the statues for Copy");

                 }
             }
             else
             {
                 if (borrowing.ReportLostCopy(Global.CurrentUser.UserID, false, 10))
                 {
                     ShowUpdateData(null, null);
                     MessageBox.Show("Update the statues for Copy");
                 }

             }
             */
        }

        private void ShowUpdateData(object sender, EventSaveBorrowingArg e)
        {
            _AllBorrowings = clsBorrowing.GetAllBorrowing();
            dgListBorrowings.DataSource = _AllBorrowings;
        }
        private void addNewBorrowingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBorrowings frm = new frmAddUpdateBorrowings();
            frm.SaveBorrowing += ShowUpdateData;
            frm.ShowDialog();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.Text=="None")
            {
                textBox1.Visible= false;
                _AllBorrowings.DefaultView.RowFilter = "";
                return;
            }
            textBox1.Visible= true;
            textBox1.Text = "";
        }

        private void btnBorrowing_Click(object sender, EventArgs e)
        {
            frmAddUpdateBorrowings frm=new frmAddUpdateBorrowings();
            frm.SaveBorrowing += ShowUpdateData;
            frm.ShowDialog();
        }
    }
}
