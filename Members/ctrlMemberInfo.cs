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
    public partial class ctrlMemberInfo : UserControl
    {
      public clsMember MemberInfo {  get; private set; }
        private int _MemberID = -1;
        public int MemberID { get { return _MemberID; } }
        public ctrlMemberInfo()
        {
            InitializeComponent();
        }
       private void _ResetMemberInfo()
        {
            lblExpiryDate.Text = "[???]";
            lblIsActive.Text = "[??]";
            lblLibraryCardNumber.Text = "[???]";
            lblMembershipDate.Text = "[???]";
        }
        private void _FillMemberInfo()
        {
            _MemberID = MemberInfo.MemberID;
            lblExpiryDate.Text = MemberInfo.ExpiryDate.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);

            lblIsActive.Text = MemberInfo.IsActive ? "Yes" : "No";
            lblLibraryCardNumber.Text =MemberInfo.LibraryCardNumber;
            lblMembershipDate.Text = MemberInfo.MembershipDate.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);
        }
        public void LoadMemberInfo(int MemberID)
        {
           MemberInfo=clsMember.Find(MemberID);
            if(MemberInfo==null)
            {
                _MemberID = -1;
                ctrlCardPerson1.ResetPersonInfo();
                _ResetMemberInfo();
                MessageBox.Show($"No Member with ID= {MemberID}");
                return;
            }
            ctrlCardPerson1.LoadPersoninfo(MemberInfo.PersonID);
            _FillMemberInfo();
        }
        public void LoadMemberInfo(string LibraryCardNumber)
        {
            MemberInfo = clsMember.Find(LibraryCardNumber);
            if (MemberInfo == null)
            {
                ctrlCardPerson1.ResetPersonInfo();
                _ResetMemberInfo();
                MessageBox.Show($"No Member with Library Card Number ={LibraryCardNumber}");
              
                return;
            }
            ctrlCardPerson1.LoadPersoninfo(MemberInfo.PersonID);
            _FillMemberInfo();
        }
    }
}
