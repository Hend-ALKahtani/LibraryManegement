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
using static LibraryManegement.frmAddUpdateUser;

namespace LibraryManegement
{
    public partial class frmListUsers : Form
    {
        private DataTable _AllUsers = clsUser.GetAllUser();
        private void _RefreshData()
        {
            _AllUsers = clsUser.GetAllUser();
        }
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0;
            dgvListUser.DataSource= _AllUsers;
            lblRecord.Text = dgvListUser.Rows.Count.ToString();
            if(dgvListUser.Rows.Count>0)
            {
                dgvListUser.Columns[0].HeaderText = "User ID";
                dgvListUser.Columns[1].HeaderText = "Person ID";
                dgvListUser.Columns[2].HeaderText = "Full Name";
                dgvListUser.Columns[2].Width = 80;
                dgvListUser.Columns[3].HeaderText = "Is Active";
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.Text=="None")
            {
                txtFilter.Visible= false;
                cbIsActive.Visible= false;
                return;
            }
            if(cbFilter.Text=="Is Active")
            {
                cbIsActive.Visible = true;
                txtFilter.Visible = false;
                return;
            }
            txtFilter.Visible = true;
            cbIsActive.Visible = false;
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(cbFilter.Text=="User ID" || cbFilter.Text=="Person ID")
             e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
           

        }

       private string GetColumnName()
        {
            string ColumnName = "";
            switch(cbFilter.Text)
            {
                case "User ID":
                    {
                        ColumnName = "UserID";
                        break;
                    }
                case "UserName":
                    {
                        ColumnName = "UserName";
                        break;
                    }
                case "Person ID":
                    {
                        ColumnName = "PersonID";
                        break;
                    }
                case "Full Name":
                    {
                        ColumnName = "FullName";
                        break;
                    }
                
                case "None":
                    {
                        ColumnName = "";
                        break;
                    }
            }
            return ColumnName;
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string ColumnName = GetColumnName();
            if(string.IsNullOrEmpty(txtFilter.Text) || ColumnName=="" )
            {
                _AllUsers.DefaultView.RowFilter = "";
                lblRecord.Text = dgvListUser.Rows.Count.ToString();
                return;
            }
            if (ColumnName == "PersonID" || ColumnName == "UserID")
            {
                _AllUsers.DefaultView.RowFilter = string.Format("[{0}]={1}", ColumnName, txtFilter.Text.Trim());
            }
            else
                _AllUsers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColumnName, txtFilter.Text.Trim());
            lblRecord.Text = dgvListUser.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text == "All")
            {
                _AllUsers.DefaultView.RowFilter = "";
                lblRecord.Text = dgvListUser.Rows.Count.ToString();
                return;
            }
            if(cbIsActive.Text=="Yes")
            {
                _AllUsers.DefaultView.RowFilter = string.Format("[{0}]={1}", "IsActive", true);

            }
            else
                _AllUsers.DefaultView.RowFilter = string.Format("[{0}]={1}", "IsActive", false);
            lblRecord.Text = dgvListUser.Rows.Count.ToString();

        }

      private void _Refresh()
        {
            _AllUsers = clsUser.GetAllUser();
            dgvListUser.DataSource = _AllUsers;
            lblRecord.Text = dgvListUser.Rows.Count.ToString();
        }
        private void ShowUpdate(object sender, EventSaveUserArg e )
        {
            _Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.OnUserSaved += ShowUpdate;
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckingIsExistRow()
        {
            if (dgvListUser.Rows.Count == 0 || dgvListUser.CurrentRow == null)
            {
                MessageBox.Show("There isn't Record");
                return false;
            }
            return true;
        }
        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if(!CheckingIsExistRow())
            {
                return;
            }
            frmShowUserInfo frm = new frmShowUserInfo((int)dgvListUser.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.OnUserSaved += ShowUpdate;
            frm.ShowDialog();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(!CheckingIsExistRow())
            {
                return;
            }
            frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvListUser.CurrentRow.Cells[0].Value);
            frm.OnUserSaved += ShowUpdate;
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(!CheckingIsExistRow())
            {
                return;
            }
            if(MessageBox.Show("Are you sure want delete this user", "confirm", MessageBoxButtons.OK)==DialogResult.OK)
            {
                if (clsUser.Delete((int)dgvListUser.CurrentRow.Cells[0].Value))
                {
                    _Refresh();
                    MessageBox.Show("delete successfully");
                }
                else
                    MessageBox.Show("data didtn delete");
            }
        }

        private void changPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckingIsExistRow())
            {
                return;
            }
            frmChangPassword frm = new frmChangPassword((int)dgvListUser.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dgvListUser.Rows.Count==0 || dgvListUser.CurrentRow==null)
            {
                return;
            }
        }
    }
}
