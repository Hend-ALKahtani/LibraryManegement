using LibraryMangegment_BusnissLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace LibraryManegement
{
    public partial class frmFines : Form
    {
        private DataGridView grid ;
        private DataTable _AllFine=clsFines.GettAllFines();
        private DataTable _AllUnPaidLostCopyFine = clsFines.GetAllUnPaidLostCopyFines();
        private DataTable _AllUnPaidOverDue=clsFines.GettAllUnPaidOverDueFine();
        private DataTable _dtCurrent;
        public frmFines()
        {
            InitializeComponent();
        }
        
        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           int FineID = (int)grid.CurrentRow.Cells[0].Value;
            clsFines fines = clsFines.Find(FineID);
            if (fines == null)
            {
                MessageBox.Show("this Fines not found");
                return;
            }
           if(fines.IsPaid==true)
            {
                MessageBox.Show("this Fines is Paid");
                return;
            }
            if(fines.PayFines())
            {
                _RefreshData();
                MessageBox.Show("Payment successfully");
            
            }
            else
            {
                MessageBox.Show("Failed Payment");
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFines_Load(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(null,null);
            dgAllFines.DataSource = _AllFine;
            dgvLostCopyFines.DataSource = _AllUnPaidLostCopyFine;
            dgvOverDueFines.DataSource = _AllUnPaidOverDue;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.Text=="None")
            {
                txtFilter.Visible = false;
                cbIsPaid.Visible = false;
                _dtCurrent.DefaultView.RowFilter = "";
                return;
            }
            if(cbFilter.Text!="Is Paid")
            {
                txtFilter.Visible=true;
                cbIsPaid.Visible = false;
                txtFilter.Text = "";
                
            }
            else
            {
                cbIsPaid.SelectedIndex = 0;
                txtFilter.Visible = false;
                cbIsPaid.Visible = true;
            }
        }

        private string _GetColumnName()
        {
                   string ColumnName = "";
            switch(cbFilter.Text)
            {
                case "Library Card Number":
                    {
                        ColumnName = "LibraryCardNumber";
                        break;
                    }
                case "Borrowing ID":
                    {
                        ColumnName = "BorrowingID";
                        break;
                    }
                case "Fine Type":
                   
                    {
                        ColumnName = "FineType";
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
       private void _SetDefaultViewOfDataTable(object value,string valueName)
        {
            
            if(valueName=="None" || string.IsNullOrEmpty(value.ToString()))
            {
                _dtCurrent.DefaultView.RowFilter = "";
                return;
            }
            if(valueName=="BorrowingID" || valueName=="FineType")
            {
                _dtCurrent.DefaultView.RowFilter = string.Format("[{0}]={1}",valueName,value );
               
            }
            else
                _dtCurrent.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", valueName, value);

        }
       private void _RefreshDataAfterPaymentOfAllFines()
        {
            _AllFine = clsFines.GettAllFines();
            dgAllFines.DataSource = _AllFine;
        }
        private void _RefreshData()
        {
           switch(tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        _RefreshDataAfterPaymentOfAllFines();
                       if(tabControl1.SelectedIndex==1)
                        {
                            dgvLostCopyFines.DataSource = _AllUnPaidLostCopyFine;
                        }
                       else
                            dgvOverDueFines.DataSource = _AllUnPaidOverDue;
                        break;
                    }
                case 1:
                    {
                        _AllUnPaidLostCopyFine = clsFines.GetAllUnPaidLostCopyFines();
                        dgvLostCopyFines.DataSource = _AllUnPaidLostCopyFine;
                        _RefreshDataAfterPaymentOfAllFines();
                        break;
                    }
                case 2:
                    {
                        _AllUnPaidOverDue = clsFines.GettAllUnPaidOverDueFine();
                        dgvOverDueFines.DataSource = _AllUnPaidOverDue;
                        _RefreshDataAfterPaymentOfAllFines();
                        break;
                    }
            }
            
        }
       
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string ColumnName = _GetColumnName();


            _SetDefaultViewOfDataTable( txtFilter.Text.Trim(), ColumnName);
         
            
        }

        private void cbIsPaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Col = "IsPaid";

            if(cbIsPaid.Text=="All")
            {
                _SetDefaultViewOfDataTable(null, Col);
            }
            else if(cbIsPaid.Text=="Yes")
                _SetDefaultViewOfDataTable(true, Col);
            else
                _SetDefaultViewOfDataTable(false, Col);


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                _dtCurrent = _AllFine;
                grid = dgAllFines;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                _dtCurrent = _AllUnPaidLostCopyFine;
                grid = dgvLostCopyFines;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                _dtCurrent = _AllUnPaidOverDue;
                grid = dgvOverDueFines;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(tabControl1.SelectedIndex!=0)
            {
                return;
            }
            int FineID = (int)dgAllFines.CurrentRow.Cells[0].Value;
            clsFines fines = clsFines.Find(FineID);
            if (fines == null)
            {
                MessageBox.Show("this Fines not found");
                return;
            }
            paymentToolStripMenuItem.Enabled=!fines.IsPaidFines();
        }
    }
}
