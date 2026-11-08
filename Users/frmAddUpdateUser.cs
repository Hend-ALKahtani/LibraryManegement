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

namespace LibraryManegement
{
    public partial class frmAddUpdateUser : Form
    {
        private int _UserID = -1;
        private clsUser User;
        public enum enMode { AddNew=0,Update=1};
        private enMode _Mode= enMode.AddNew;
      public class EventSaveUserArg:EventArgs
        {
            public int UserID { get; }
            public string UserName { get; }
            public EventSaveUserArg(int UserID,string UserName)
            {
                this.UserID = UserID;
                this.UserName = UserName;
            }
        }
        public event EventHandler<EventSaveUserArg> OnUserSaved;
        protected virtual void UserSave(EventSaveUserArg e)
        {
            OnUserSaved?.Invoke(this, e);
        }
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode= enMode.AddNew;
        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID= UserID;
            _Mode= enMode.Update;
        }
        private void _ResetData()
        {
            if(_Mode==enMode.AddNew)
            {
                lblAddUpdate.Text = "Add New User";
                User = new clsUser();
                tpLoginInfo.Enabled = false;
                
            }
            else
            {
                lblAddUpdate.Text = "Update User";
                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;
                ctrlPersonCardWithFilter1.EnableFilterBox = false;
            }
            txtPassword.Text = "";
            txtConfirmpassword.Text = "";
            chboxIsActive.Checked = true;
        }

       private void _LoadData()
        {
            User = clsUser.GetUserByUserID(_UserID);
            if(User==null)
            {
                MessageBox.Show("this user not found");
                this.Close();
                return;
            }
            ctrlPersonCardWithFilter1.LoadPersonInfo(User.PersonID);
            lblUserID.Text = User.UserID.ToString();
            txtUserName.Text = User.UserName;
           // txtPassword.Text = User.PassWord;
           // txtConfirmpassword.Text = User.PassWord;
            chboxIsActive.Checked = User.IsActive;
        }
        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetData();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           if(_Mode==enMode.AddNew)
            {
                if (ctrlPersonCardWithFilter1.PersonID == -1)
                {
                    MessageBox.Show("please selected person");
                    return;
                }
               
                if (clsUser.IsUserExistByPersonID(ctrlPersonCardWithFilter1.PersonID))
                {
                     MessageBox.Show("this person  already acount user, choose anthor one");
                    return;
                }
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    
                
            }


           
            tabControl1.SelectedTab = tabControl1.TabPages["tpLoginInfo"];
            
        }

        

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "username not allowed blank");
                return;
            }
            else
                errorProvider1.SetError(txtUserName, null);
            if(_Mode==enMode.AddNew)
            {
                if(clsUser.IsUserExistByUserName(txtUserName.Text.Trim()))
                {
                    e.Cancel=true;
                    errorProvider1.SetError(txtUserName, "this username used by anthoe user");
                }
                else
                    errorProvider1.SetError(txtUserName, null);
            }
            else
            if(txtUserName.Text.Trim()!=User.UserName)
            {
                if (clsUser.IsUserExistByUserName(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "this username used bt anthor user");
                    return;
                }
                else
                    errorProvider1.SetError(txtUserName, null);
            }
        
        }
         
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
           if(_Mode==enMode.AddNew)
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPassword, "not allowed empty");
                }
                else
                    errorProvider1.SetError(txtPassword, null);
            }
           else
                errorProvider1.SetError(txtPassword, null);
        }

        private void txtConfirmpassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim() != txtConfirmpassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmpassword, "must confirm with password");
            }
            else
                errorProvider1.SetError(txtConfirmpassword, null); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some filed not valide put mouse over red icon(s)");
                return;
            }
            User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            User.UserName=txtUserName.Text;
            User.IsActive = chboxIsActive.Checked;
            if(_Mode==enMode.AddNew)
            {
                User.PassWord = txtPassword.Text;
            }

            if (_Mode==enMode.Update && !string.IsNullOrEmpty(txtPassword.Text))
            {
               User.ChangePassword(txtPassword.Text);
            }
            if(User.Save())
            {
                MessageBox.Show("Data Save Successfully");
                lblUserID.Text = User.UserID.ToString();
                lblAddUpdate.Text = "Update User";
                _Mode = enMode.Update;
                //fire event
                UserSave(new EventSaveUserArg(User.UserID, User.UserName));
            }
            else
            {
                MessageBox.Show("Data Not Save");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
