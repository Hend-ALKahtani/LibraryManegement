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
using static LibraryManegement.frmAddUpdateMember;

namespace LibraryManegement
{
    public partial class frmListMembers : Form
    {
        private DataTable _AllMembers = clsMember.GetAllMembers();
        public frmListMembers()
        {
            InitializeComponent();
        }

        private void frmListMembers_Load(object sender, EventArgs e)
        {
           dgvMembers.DataSource= _AllMembers;
            lblRecord.Text = dgvMembers.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
            if(dgvMembers.Rows.Count>0)
            {
                dgvMembers.Columns[0].HeaderText = "Member ID";
                dgvMembers.Columns[1].HeaderText = "Library Card Number";
                dgvMembers.Columns[2].HeaderText = "Membership Date";
                dgvMembers.Columns[3].HeaderText = "Is Active";
                dgvMembers.Columns[4].HeaderText = "Person ID";
                dgvMembers.Columns[5].HeaderText = "Expiry Date";
                dgvMembers.Columns[6].HeaderText = "Full Name";
                dgvMembers.Columns[6].Width = 120;
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbFilter.Text=="None")
            {
                txtFilter.Visible = false;
                cbIsActive.Visible = false;
                _AllMembers.DefaultView.RowFilter = "";
                lblRecord.Text = dgvMembers.Rows.Count.ToString();
                return;
            }
           if(cbFilter.Text=="Is Active")
            {
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
                txtFilter.Visible = false;
                return;
            }
            txtFilter.Visible = true;
            cbIsActive.Visible = false;
            txtFilter.Text="";
              
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text=="Member ID" || cbFilter.Text=="Perrson ID")
            {
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
            }
        }
       private string GetColumnName()
        {
            string ColumnName = "";
            switch(cbFilter.Text)
            {
                case "Pesron ID":
                    {
                        ColumnName = "PersonID";
                        break;
                    }
                case "Member ID":
                    {
                        ColumnName = "MemberID";
                        break;
                    }
                case "Library Card Number":
                    {
                        ColumnName = "LibraryCardNumber";
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
                default:
                    {
                        ColumnName = "";
                        break;
                    }
                  
            }
            return ColumnName;
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIsActive.Text=="All")
            {
                _AllMembers.DefaultView.RowFilter = "";
                lblRecord.Text = dgvMembers.Rows.Count.ToString();
                return;
            }
            if (cbIsActive.Text == "Yes")
                _AllMembers.DefaultView.RowFilter = string.Format("[{0}] = {1}", "IsActive", true);
            else
                _AllMembers.DefaultView.RowFilter = string.Format("[{0}]={1}", "IsActive", false);
            lblRecord.Text = dgvMembers.Rows.Count.ToString();
              

           
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string ColumnName=GetColumnName();
           if(ColumnName=="" || string.IsNullOrEmpty(txtFilter.Text.Trim()))
            {
                _AllMembers.DefaultView.RowFilter = "";
                lblRecord.Text = dgvMembers.Rows.Count.ToString();
                return;
            }
            if (ColumnName == "PersonID" || ColumnName == "MemberID")
                _AllMembers.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilter.Text.Trim());
            else
                _AllMembers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColumnName, txtFilter.Text.Trim());
            lblRecord.Text = dgvMembers.Rows.Count.ToString();
        }

       private void _RefreshData(object sender, EventSaveMemberArg saveMemberArg)
        {
            _AllMembers = clsMember.GetAllMembers();
            dgvMembers.DataSource= _AllMembers;
            lblRecord.Text = dgvMembers.Rows.Count.ToString();
        }
        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frm = new frmAddUpdateMember();
            frm.MemberSave += _RefreshData;
            frm.ShowDialog();
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frm = new frmAddUpdateMember((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.MemberSave += _RefreshData;
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Membership for this Person","Waring",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if (clsMember.DeleteMembership((int)dgvMembers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("delete membership successfully");
                    _AllMembers = clsMember.GetAllMembers();
                    dgvMembers.DataSource = _AllMembers;
                }
                else
                    MessageBox.Show("Filed to delete Membership");
            }

        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this member", "Waring", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsMember.DeleteMember((int)dgvMembers.CurrentRow.Cells[0].Value))
                {
                    _AllMembers = clsMember.GetAllMembers();
                    dgvMembers.DataSource = _AllMembers;
                    lblRecord.Text = dgvMembers.Rows.Count.ToString();
                    MessageBox.Show("delete Member successfully");
               
                }
                else
                    MessageBox.Show("Filed to delete this Member");
            }

        }

        private void showMemberInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberInfo frm = new frmMemberInfo((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
