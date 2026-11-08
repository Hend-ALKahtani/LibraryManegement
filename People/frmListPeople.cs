using LibraryMangegment_BusnissLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using static LibraryManegement.frmAddUpdatePerson;

namespace LibraryManegement
{
    public partial class frmListPeople : Form
    {
     private static  DataTable _dtAllPeople=clsPerson.GetAllPeople();
        DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(true, "PersonID", "NationalNo", "FirstName",
            "SecoundName", "ThirdName", "LastName", "GendorCaption", "DateOfBirth", "CountryName", "Phone", "Email");

     private void frm_EvenetDataBack(object sender, EventSavePersonArg e )
        {
            _RefreshData();
        }
        private void _RefreshData()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(true, "PersonID", "NationalNo", "FirstName",
            "SecoundName", "ThirdName", "LastName", "GendorCaption", "DateOfBirth", "CountryName", "Phone", "Email");
           dgvListPeople.DataSource= _dtPeople;
            lblRecordCount.Text = dgvListPeople.Rows.Count.ToString();
        }
        public frmListPeople()
        {
            InitializeComponent();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            dgvListPeople.DataSource = _dtPeople;
            lblRecordCount.Text = dgvListPeople.Rows.Count.ToString();
            if(dgvListPeople.Rows.Count>0)
            {
                dgvListPeople.Columns[0].HeaderText = "Person ID";
                dgvListPeople.Columns[1].HeaderText = "National No";
                dgvListPeople.Columns[2].HeaderText = "First Name";
                dgvListPeople.Columns[3].HeaderText = "Scound Name";
                dgvListPeople.Columns[4].HeaderText = "Third Name";
                dgvListPeople.Columns[5].HeaderText = "Last Name";
                dgvListPeople.Columns[6].HeaderText = "Nationality";
                dgvListPeople.Columns[7].HeaderText = "Gendor";
                dgvListPeople.Columns[8].HeaderText = "Date Of Birth";
                dgvListPeople.Columns[9].HeaderText = "Nationality";

            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "PersonID") ;
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private string  GetColumnFilter()
        {
            string ColumnName = "";
            switch(cbFilter.Text)
            {
                case "Person ID":
                    {
                        ColumnName = "PersonID";
                        break;
                    }
                case "National No":
                    {
                        ColumnName = "NationalNo";
                        break;
                    }
                case "First Name":
                    {
                        ColumnName = "FirstName";
                        break;
                    }
                case "Second Name":
                    {
                        ColumnName = "SecoundName";
                        break;
                    }
                case "Third Name":
                    {
                        ColumnName = "ThirdName";
                        break;
                    }
                case "Last Name":
                    {
                        ColumnName = "LastName";
                        break;
                    }
                case "Nationality":
                    {
                        ColumnName = "Nationality";
                        break;
                    }
                case "Gendor":
                    {
                        ColumnName = "Gendor";
                        break;
                    }
                case "Phone":
                    {
                        ColumnName = "Phone";
                        break;
                    }
                case "Email":
                    {
                        ColumnName = "Phone";
                        break;
                    }
                default:
                    ColumnName = "None";
                    break;

            }
            return ColumnName;
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string ColumnName = GetColumnFilter();
           if(ColumnName=="None" ||txtFilter.Text.Trim()=="")
            {
                _dtAllPeople.DefaultView.RowFilter = "";
                lblRecordCount.Text=dgvListPeople.Rows.Count.ToString();
                return;
            }
            if (ColumnName == "None" || txtFilter.Text.Trim() == "")
            {
                _dtAllPeople.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvListPeople.Rows.Count.ToString();
                return;
            }
            if(ColumnName =="PersonID")
         
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}]={1}", ColumnName, txtFilter.Text.Trim());
            else
         
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColumnName, txtFilter.Text.Trim());
            lblRecordCount.Text = dgvListPeople.Rows.Count.ToString();

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = cbFilter.Text != "None";
            if (txtFilter.Visible)
            {
                txtFilter.Clear();
                txtFilter.Focus();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshData();
        }

        private bool CheckingIsExistRow()
        {
            if (dgvListPeople.Rows.Count == 0 || dgvListPeople.CurrentRow == null)
            {
                MessageBox.Show("There isn't Record");
                return false;
            }
            return true;
        }
        private void updatePersonInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckingIsExistRow())
            {
                return;
            }
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson((int)dgvListPeople.CurrentRow.Cells[0].Value);
            frmAddUpdatePerson.EventSavePerson += frm_EvenetDataBack;
            frmAddUpdatePerson.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckingIsExistRow();
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson();
            frmAddUpdatePerson.EventSavePerson += frm_EvenetDataBack;
            frmAddUpdatePerson.ShowDialog();
           
        }

        private void showPersonInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckingIsExistRow())
            {
                return;
            }
            frmShowPersonInfo frmShowPersonInfo = new frmShowPersonInfo((int)dgvListPeople.CurrentRow.Cells[0].Value);
            frmShowPersonInfo.ShowDialog();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckingIsExistRow())
            {
                return;
            }
            if (clsPerson.DeletePerson((int)dgvListPeople.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Delete Successfully");
                _RefreshData();
            }
            else
                MessageBox.Show("This Person was not delete");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dgvListPeople.Rows.Count==0 || dgvListPeople.CurrentRow==null)
            {
                e.Cancel = true;
                return;
            }

        }
    }
}
