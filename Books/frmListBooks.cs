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
    public partial class frmListBooks : Form
    {
        private DataTable _AllBooks = clsBook.GetAllBook();
        public frmListBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListBooks_Load(object sender, EventArgs e)
        {
            dgvBooks.DataSource= _AllBooks;
            lblCountRecord.Text = dgvBooks.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if(dgvBooks.Rows.Count>0)
            {
                dgvBooks.Columns[0].HeaderText = "Book ID";
                dgvBooks.Columns[1].HeaderText = "Book Title";
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.Text!="None")
            {
                txtFilter.Visible = true;
                txtFilter.Text = "";
                return;
            }
            txtFilter.Visible = false;
            _AllBooks.DefaultView.RowFilter = "";
            lblCountRecord.Text = dgvBooks.Rows.Count.ToString();
        }
        private string _GetColumnName()
        {
            string ColumnName = "";
            switch(cbFilter.Text)
            {
                case "Book ID":
                    {
                        ColumnName = "BookID";
                        break;
                    }
                case "Book Title":
                    {
                        ColumnName = "BookTitle";
                        break;
                    }
                case "Author":
                    {
                        ColumnName = "Author";
                        break;
                    }
                case "Category":
                    {
                        ColumnName = "Category";
                        break;
                    }
                case "Puplisher":
                    {
                        ColumnName = "Puplisher";
                        break;
                    }
                case "ISBN":
                    {
                        ColumnName = "ISBN";
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

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text=="Book ID")
            {
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string ColumnName = _GetColumnName();
            if(string.IsNullOrEmpty(txtFilter.Text) ||ColumnName=="None")
            {
                _AllBooks.DefaultView.RowFilter = "";
                lblCountRecord.Text = dgvBooks.Rows.Count.ToString();
                return;
            }
            if (ColumnName == "BookID")
            {
                _AllBooks.DefaultView.RowFilter = $"[{ColumnName}]={txtFilter.Text.Trim()}";
            }
            else
                _AllBooks.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'",ColumnName,txtFilter.Text.Trim());
            lblCountRecord.Text = dgvBooks.Rows.Count.ToString();
        }

       private void _RefreshData(object sender, SaveBookArg saveBookArg)
        {
            _AllBooks = clsBook.GetAllBook();
            dgvBooks.DataSource = _AllBooks;
            lblCountRecord.Text = dgvBooks.Rows.Count.ToString();
        }
        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook();
            frm.SaveBook += _RefreshData;
            frm.ShowDialog();


        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook((int)dgvBooks.CurrentRow.Cells[0].Value);
            frm.SaveBook += _RefreshData;
            frm.ShowDialog();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this book","Confirm",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if (clsBook.Delete((int)dgvBooks.CurrentRow.Cells[0].Value))
                {
                    _AllBooks = clsBook.GetAllBook();
                    dgvBooks.DataSource = _AllBooks;
                    lblCountRecord.Text = dgvBooks.Rows.Count.ToString();
                    MessageBox.Show("Delete Successfully");
                }
                else
                    MessageBox.Show("Failed to delete");
            }
        }

        private void showBookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBookInfo frm = new frmShowBookInfo((int)dgvBooks.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
