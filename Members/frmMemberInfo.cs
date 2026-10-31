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
    public partial class frmMemberInfo : Form
    {
        private int _MemberID;
            
        public frmMemberInfo(int MemberID)
        {
            InitializeComponent();
            ctrlMemberInfo1.LoadMemberInfo(MemberID);
        }
    }
}
