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
                    Global.RememberMe(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                }
               else
                {
                    Global.CleareCredential();
                }
                this.Hide();
                Form1 frm = new Form1(this);
                frm.ShowDialog();
                if (!chRemember.Checked)
                {
                    //CleareCredential();
                    txtPassword.Text = "";
                    txtUserName.Clear();
                    
                }
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
