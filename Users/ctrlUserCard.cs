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
    public partial class ctrlUserCard : UserControl
    {
        private int _PersonID = -1;
        public int PersonID { get { return _PersonID; }private  set { _PersonID = value; } }
        public clsPerson PersonInfo { get; private set; }

        private int _UserID = -1;
        public int UserID { get; private set; }
        public clsUser UserInfo { get;private set; }
        public ctrlUserCard()
        {
            InitializeComponent();
            
        }
       private void _FillUserInfo()
        {
            UserID = UserInfo.UserID;
            ctrlCardPerson1.LoadPersoninfo(UserInfo.PersonID);
            lblUserID.Text = UserID.ToString();
            lblUserName.Text = UserInfo.UserName;
            lblIsActive.Text = UserInfo.IsActive ? "Yes" : "No";
        }
        public void LoadUserInfo(int UserID)
        {
            UserInfo = clsUser.GetUserByUserID(UserID);
            if (UserInfo==null)
            {
                MessageBox.Show("This User Not Found");
                
                return;
            }
           
            _FillUserInfo();
        }
    }
}
