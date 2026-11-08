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
using static LibraryMangegment_BusnissLogic.clsBorrowing;

namespace LibraryManegement
{
    public partial class frmAddUpdateBorrowings : Form
    {
        public class EventSaveBorrowingArg : EventArgs
        {
            public int BorrowingID { get; }
            public int CopyID { get; }
            public EventSaveBorrowingArg(int borrowingID,int copyID)
            {
                BorrowingID= borrowingID;
                CopyID = copyID;
            }
        }
        // public delegate void EventSaveBorrowingEventHandler(object sender, EventSaveBorrowingArg e);
        // public event EventSaveBorrowingEventHandler EventSaveBorrowing;
        public event EventHandler<EventSaveBorrowingArg> SaveBorrowing;
       protected virtual void OnSave(EventSaveBorrowingArg e)
        {
            SaveBorrowing?.Invoke(this, e);
        }
        public enum enMode { AddNew=1,Update=2};
        private enMode _Mode = enMode.AddNew;
        private clsBorrowing.enStatuse statuse;
        public int _BorrowingID;
        public clsBorrowing BorrowingInfo;
        public frmAddUpdateBorrowings()
        {
            InitializeComponent();
            _Mode= enMode.AddNew;
        }
        public frmAddUpdateBorrowings(int BorrowingID)
        {
            InitializeComponent();
            _BorrowingID = BorrowingID;
            _Mode = enMode.Update;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_Mode==enMode.AddNew)
            {
                if(ctrlMemberInfoWithFilter1.MemberID==-1)
                {
                    MessageBox.Show("you must choose Member");
                    return;
                }
                if (!ctrlMemberInfoWithFilter1.MemberInfo.IsMembershipActive())
                {
                    MessageBox.Show("this membership is not Active");
                    return;
                }
                if(ctrlMemberInfoWithFilter1.MemberInfo.IsExpireMembership)
                {
                    MessageBox.Show("Membership is Expire");
                    return;
                }
                if (ctrlMemberInfoWithFilter1.MemberInfo.IsMemberHasUnPaidFines())
                {
                    MessageBox.Show("this member has Fines");
                    return;
                }

                tpCopyInfo.Enabled = true;
            }
            tabControl1.SelectedTab = tabControl1.TabPages["tpCopyInfo"];
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            if(_Mode==enMode.AddNew)
            {
                if(ctrlCopyInfoWithFilter1.CopyID==-1)
                {
                    MessageBox.Show("choose Copy");
                    return;
                }
                if(!ctrlCopyInfoWithFilter1.CopyInfo.IsCopyAvailable())
                {
                    MessageBox.Show("this copy is not Availble, choose anthore one ");
                    return;
                }
                lblMemberID.Text = ctrlMemberInfoWithFilter1.MemberID.ToString();
                lblCopyID.Text = ctrlCopyInfoWithFilter1.CopyID.ToString();

                tpBorrowingInfo.Enabled = true;
                btnSave.Enabled = true;
            }
            tabControl1.SelectedTab = tabControl1.TabPages["tpBorrowingInfo"];
        }

        private void _LoadData()
        {
            ctrlMemberInfoWithFilter1.LoadMemberInfo(BorrowingInfo.MemberID);
            ctrlCopyInfoWithFilter1.LoadCopyInfo(BorrowingInfo.CopyID);
            lblBorrowingID.Text = BorrowingInfo.BorrowingID.ToString();
            lblCopyID.Text= BorrowingInfo.CopyID.ToString();
            lblMemberID.Text= BorrowingInfo.MemberID.ToString();
            lblBorrowDate.Text = BorrowingInfo.BorrowDate.ToString("dd/MM/yyyy");
            lblDueDate.Text = BorrowingInfo.DueDate.ToString("dd/MM/yyyy");
            dtDueDate.Value=BorrowingInfo.DueDate;
            lblStatues.Text = BorrowingInfo.GetStatues;
            lblUserName.Text = Global.CurrentUser.UserName;
            txtNote.Text = BorrowingInfo.Note;
        }
        private void _SetDate()
        {
            if(_Mode==enMode.AddNew)
            {
                tpCopyInfo.Enabled = false;
                tpBorrowingInfo.Enabled=false;
                BorrowingInfo = new clsBorrowing();
                lblMode.Text = "New Borrowing";
                lblStatues.Text = "Issued";
                lblUserName.Text=Global.CurrentUser.UserName;
                lblBorrowDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblDueDate.Text = DateTime.Now.AddDays(BorrowingInfo.DaysDue).ToString("dd/MM/yyyy");
               // dtDueDate.Value = DateTime.Now.AddDays(BorrowingInfo.DaysDue);
                //dtDueDate.MinDate = DateTime.Now;
                return;
            }
            BorrowingInfo = clsBorrowing.FindByBorrowingID(_BorrowingID);
            btnSave.Enabled = true;
            lblMode.Text = "Update Borrowing";

        }
        private void frmBorrowings_Load(object sender, EventArgs e)
        {
            _SetDate();
            if(_Mode==enMode.Update)
            {
               // ctrlCopyInfoWithFilter1.EnabledFilerCopy = false;
               // ctrlMemberInfoWithFilter1.EnabledFilter = false;
                tabControl1.TabPages["tbMemberInfo"].Enabled = false;
                tabControl1.TabPages["tpCopyInfo"].Enabled = false;
                _LoadData();
            }
        }
        private enStatuse _GetStatues()
        {
            enStatuse Statues;
            switch(lblStatues.Text)
            {
                case "Issued":
                    {
                        return Statues = enStatuse.Issued;
                    }
                case "Returned":
                    {
                        return Statues = enStatuse.Returned;
                    }
                case "Lost":
                    {
                        return Statues = enStatuse.Lost;
                    }
                case "OverDue":
                    {
                        return Statues = enStatuse.OverDue;
                    }
                default:
                    {
                        return Statues = enStatuse.Issued;
                    }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            BorrowingInfo.CopyID = ctrlCopyInfoWithFilter1.CopyID;
            BorrowingInfo.MemberID = ctrlMemberInfoWithFilter1.MemberID;
            BorrowingInfo.BorrowDate = DateTime.ParseExact(lblBorrowDate.Text,"dd/MM/yyyy",CultureInfo.InvariantCulture);
            BorrowingInfo.DueDate = DateTime.ParseExact(lblDueDate.Text,"dd/MM/yyyy",CultureInfo.InvariantCulture);
            BorrowingInfo.IssuedByUserID = Global.CurrentUser.UserID;
            BorrowingInfo.Note = txtNote.Text;
            BorrowingInfo.Statuse = _GetStatues();
            if(BorrowingInfo.Save())
            {
                _Mode = enMode.Update;
                lblMode.Text = "Update Borrowing";
                lblBorrowingID.Text = BorrowingInfo.BorrowingID.ToString();
                OnSave(new EventSaveBorrowingArg(BorrowingInfo.BorrowingID,BorrowingInfo.CopyID));
                tabControl1.TabPages["tbMemberInfo"].Enabled = false;
                tabControl1.TabPages["tpCopyInfo"].Enabled = false;
                MessageBox.Show("Saved Successfuly");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
        }

        private void ctrlCopyInfoWithFilter1_CopySelected(object sender, ctrlCopyInfoWithFilter.EventCopySelectArg e)
        {
            lblCopyID.Text= e.CopyID.ToString();
        }

        private void ctrlMemberInfoWithFilter1_MemberSelect(object sender, ctrlMemberInfoWithFilter.EventSelectMemberArg e)
        {
            lblMemberID.Text=e.MemberID.ToString();
        }
    }
}
