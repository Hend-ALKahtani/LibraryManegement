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

namespace LibraryManegement
{
    public partial class frmChangPassword : Form
    {
        private int _UserID;
        private clsUser _User;
        public frmChangPassword(int userID)
        {
            InitializeComponent();
            _UserID = userID;
            ctrlUserCard1.LoadUserInfo(_UserID);
            _User = ctrlUserCard1.UserInfo;
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
          
            if (!_User.IsPasswordConfirmWithUserPassword(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "current password not confirm with user password");
            }
            else
                errorProvider1.SetError(txtCurrentPassword, null);

            /*
             if (txtCurrentPassword.Text.Trim() != ctrlUserCard1.UserInfo.PassWord)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "current password not confirm with user password");
            }
            else
                errorProvider1.SetError(txtCurrentPassword, null);
             */
        }

        private void txtNewPasswrd_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNewPasswrd.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPasswrd, "not allowed blank");
            }
            else
                errorProvider1.SetError (txtNewPasswrd, null);
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirm.Text.Trim()!=txtNewPasswrd.Text.Trim())
            {
                e.Cancel= true;
                errorProvider1.SetError(txtConfirm, "must be confim with new password");
            }
            else
                errorProvider1.SetError(txtConfirm, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("some filed not valid put mouse over red icon(s)");
                return;
            }
            if (!_User.IsPasswordConfirmWithUserPassword(txtNewPasswrd.Text.Trim()))
            {
                _User.ChangePassword(txtNewPasswrd.Text.Trim());
            }
           // _User.PassWord = txtNewPasswrd.Text.Trim();
            if (_User.Save())
            {
                btnSave.Enabled = false;
                MessageBox.Show("Update password successfully");
            }
            else
                MessageBox.Show("password did not update");
        }
    }
}
