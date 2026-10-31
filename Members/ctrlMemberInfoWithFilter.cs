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
using static LibraryManegement.frmAddUpdateMember;

namespace LibraryManegement
{
    public partial class ctrlMemberInfoWithFilter : UserControl
    {
       public bool EnabledFilter { get {return gbFilter.Enabled; } set { gbFilter.Enabled = value; } }
        public clsMember MemberInfo { get { return ctrlMemberInfo1.MemberInfo; }  private set { } }
     public int MemberID { get { return ctrlMemberInfo1.MemberID; } }
        public class EventSelectMemberArg : EventArgs
        {
            public int MemberID { get; }
            public string LibraryCardNumber { get; }
            public EventSelectMemberArg(int memberID, string libraryCardNumber)
            {
                MemberID = memberID;
                LibraryCardNumber = libraryCardNumber;
            }
        }
        public event EventHandler<EventSelectMemberArg> MemberSelect;
        protected virtual void OnMemberSelected(EventSelectMemberArg arg)
        {
            MemberSelect?.Invoke(this, arg);
        }
        public ctrlMemberInfoWithFilter()
        {
            InitializeComponent();
        }
       public void LoadData(object sender , EventSaveMemberArg memberArg)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilter.Text = memberArg.MemberID.ToString();
            ctrlMemberInfo1.LoadMemberInfo(memberArg.MemberID);
        }
        

      private void _FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Member ID":
                    {
                        ctrlMemberInfo1.LoadMemberInfo(Int32.Parse(txtFilter.Text.Trim()));
                        break;
                    }
                case "Library Card Number":
                    {
                        ctrlMemberInfo1.LoadMemberInfo(txtFilter.Text.Trim());
                        break;
                    }
            }
            if (MemberSelect != null && EnabledFilter)
                OnMemberSelected(new EventSelectMemberArg(MemberInfo.MemberID, MemberInfo.LibraryCardNumber));
        }
      public void LoadMemberInfo(int MemberID)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilter.Text = MemberID.ToString();
            _FindNow();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _FindNow();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frm = new frmAddUpdateMember();
            frm.MemberSave += LoadData;
            frm.ShowDialog();
        }

        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
