using LibraryMangegment_BusnissLogic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace LibraryManegement
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Global.CurrentUser = clsUser.GetUserByUserNameAndPassWord(txtUserName.Text.Trim(), txtPassword.Text.Trim());
           if(Global.CurrentUser==null)
            {
                MessageBox.Show("This User Not Exist");
                return;
            }
           // Global.CurrentUser != null;
          
               if(!Global.CurrentUser.IsActive)
                {
                    MessageBox.Show("This user is not active contact with adminstrstion");
                    return;
                }
               if(chRemember.Checked)
                {
                    RememberMe(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                }
               else
                {
                    CleareCredential();
                }
                this.Hide();
                Form1 frm = new Form1(this);
                frm.ShowDialog();
                if (!chRemember.Checked)
                {
                    //CleareCredential();
                    txtPassword.Text = "";
                    txtPassword.Clear();
                }
           

        }
        public static bool RememberMe(string UserName,string Password)
        {
          
            string KeyName = @"HKEY_CURRENT_USER\SOFTWARE\LibraryManegment";
            string valuPassword = "Password";
            string valueUserName = "UserName";
            string Keyname = @"SOFTWARE\LibraryManegment";

            try
            {
                using (RegistryKey key=Registry.CurrentUser.CreateSubKey(Keyname))
                {
                    if (key != null)
                    {
                        key.SetValue(valueUserName, UserName);
                        key.SetValue(valuPassword, Password);
                        return true;
                    }
                    
                }
            }
            catch(Exception E)
            {
                //throw new Exception(E.Message);
                MessageBox.Show(E.Message);
            }
            return false;
        }
        public static bool CleareCredential()
        {
            string KeyName = @"SOFTWARE\LibraryManegment";
            string valuPassword = "Password";
            string valueUserName = "UserName";
            try
            {
                using (RegistryKey basekey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = basekey.OpenSubKey(KeyName, writable: true))
                    {
                        if (key != null)
                        {
                            //here we user named arguments throwOnMissingValue:false write parameter name then write value
                            //this argment if the value not found will not throw exception
                            key.DeleteValue(valueUserName, throwOnMissingValue: false);
                            key.DeleteValue(valuPassword, throwOnMissingValue: false);
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //throw new Exception (ex.Message);
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            string UserName = "";string PassWord = "";
            if (Global.LoadData(ref UserName, ref PassWord))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = PassWord;
                chRemember.Checked = true;
            }
            else
                chRemember.Checked = false;
           // _FillData();
        }
    }
}
