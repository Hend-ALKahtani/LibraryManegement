using LibraryMangegment_BusnissLogic;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace LibraryManegement
{
    public partial class frmAddUpdateMember : Form
    {
        public event EventHandler<EventSaveMemberArg> MemberSave;
        public class EventSaveMemberArg : EventArgs
        {
            public int MemberID { get; }
            public string LibraryCardNumber { get; }
            public EventSaveMemberArg(int memberID,string libraryCardNumber)
            {
                MemberID = memberID;
                LibraryCardNumber = libraryCardNumber;
            }
            
        }
        protected virtual void OnMemberSaved(EventSaveMemberArg saveMemberArg)
        {
            MemberSave?.Invoke(this, saveMemberArg);
        }
        private int _MemberID;
        private clsMember _Member;
        public enum enMode { AddNew=0,Update=1};
        private enMode _Mode;
        public frmAddUpdateMember()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateMember(int MemberID)
        {
            InitializeComponent();
            _MemberID=MemberID; 
            _Mode = enMode.Update;

        }
        private void _SetDefualtData()
        {
            if(_Mode==enMode.AddNew)
            {
               _Member= new clsMember();
                lblMode.Text = "Add New";
                lblDateMembership.Text = DateTime.Now.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);
                lblExpiryDate.Text = DateTime.Now.AddYears(2).ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);
              string uniquCode=Guid.NewGuid().ToString().Substring(0,5);
                int NextMemberNumber = _Member.GetNextMemberNumber();
              //  txtCardNumber.Text = $"LIB-{DateTime.Now.Year}-{NextMemberNumber.ToString("D4")}";
               
                btnSave.Enabled= false;
                tpMemberInfo.Enabled = false;
            }
            else
            {
                lblMode.Text = "Update Mode";
                btnSave.Enabled = true;
               

            }
        }
        private void _LoadData()
        {
            _Member = clsMember.Find(_MemberID);
            if(_Member==null)
            {
                MessageBox.Show("this Member not exist, this Form will be closed");
                return;
            }
            ctrlPersonCardWithFilter1.LoadPersonInfo(_Member.PersonID);
            lblMemberID.Text = _Member.MemberID.ToString();
            lblExpiryDate.Text = _Member.ExpiryDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            lblDateMembership.Text = _Member.MembershipDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            chBoxIsActive.Checked= _Member.IsActive;
            txtCardNumber.Text = _Member.LibraryCardNumber;
            
        }

        private void frmAddUpdateMember_Load(object sender, EventArgs e)
        {
            _SetDefualtData();
            if (_Mode == enMode.Update)
            {
                _LoadData();
                ctrlPersonCardWithFilter1.EnableFilterBox = false;
            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_Mode==enMode.AddNew)
            {
                if (ctrlPersonCardWithFilter1.PersonID == -1)
                {
                    MessageBox.Show("Must select person");
                    return;
                }
                if(clsMember.IsMemberExistByPersonID(Int32.Parse(ctrlPersonCardWithFilter1.PersonID.ToString())))
                {
                    MessageBox.Show("This Person already is Member");
                    return;
                }
                btnSave.Enabled = true;
                tpMemberInfo.Enabled = true;
            }
          
            tabControl1.SelectedTab = tabControl1.TabPages["tpMemberInfo"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Member.ExpiryDate = DateTime.ParseExact(lblExpiryDate.Text,"dd/MM/yyyy",CultureInfo.InvariantCulture);
            _Member.MembershipDate = DateTime.ParseExact(lblDateMembership.Text,"dd/MM/yyyy",CultureInfo.InvariantCulture);
            _Member.IsActive = chBoxIsActive.Checked;
            _Member.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _Member.LibraryCardNumber = txtCardNumber.Text;
            if(_Member.Save())
            {
                OnMemberSaved(new EventSaveMemberArg(_Member.MemberID, _Member.LibraryCardNumber));
                MessageBox.Show("Saved Successfully");
                _Mode = enMode.Update;
                lblMode.Text = "Update Member";
                lblMemberID.Text=_Member.MemberID.ToString();
                txtCardNumber.Text= _Member.LibraryCardNumber;
            }
            else
            {
                MessageBox.Show("Data not Saved");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
