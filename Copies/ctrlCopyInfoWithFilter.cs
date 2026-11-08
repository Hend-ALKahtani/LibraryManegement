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
using static LibraryManegement.frmAddUpdateCopy;

namespace LibraryManegement
{
    public partial class ctrlCopyInfoWithFilter : UserControl
    {
        public class EventCopySelectArg : EventArgs
        {
            public int CopyID { get; }
            public int BookID {  get; }
            public EventCopySelectArg(int copyID, int bookID)
            {
                BookID = bookID;
                CopyID = copyID;
            }
        }
        public event EventHandler<EventCopySelectArg> CopySelected;
        protected void OnCopySelected(EventCopySelectArg e)
        {
            CopySelected?.Invoke(this, e);
        }
        public clsBookCopy CopyInfo { get { return ctrlCopyDetails1.CopyInfo; }  }
        public bool EnabledFilerCopy { get { return groupBox1.Enabled; } set { groupBox1.Enabled = value; } }
        public  int CopyID { get { return ctrlCopyDetails1.CopyID; } }
        public ctrlCopyInfoWithFilter()
        {
            InitializeComponent();
        }
        private void _FindNow()
        {
           switch(cbFilter.Text)
            {


                case "Copy ID":
                    {
                        ctrlCopyDetails1.LoadCopyInfoByCopyID(Int32.Parse(txtFilter.Text.Trim()));
                        break;
                    }
                case "Barcode":
                    {
                        ctrlCopyDetails1.LoadCopyInfoByBarcode(txtFilter.Text.Trim());
                        break;
                    }
                case "Book Title":
                    {
                        ctrlCopyDetails1.LoadCopyInfoByBookTitle(txtFilter.Text.Trim());
                        break;
                    }
            }
            //Rais event just when search and find copy otherwise not rais
            //and we just call OnCopySelected only if there is method regist in event
            if (CopySelected != null && ctrlCopyDetails1.CopyInfo!=null )
                OnCopySelected(new EventCopySelectArg(CopyInfo.CopyID, CopyInfo.BookID));
        }

        public void LoadCopyInfo(int  copyID)
        {
            cbFilter.SelectedIndex = 2;
            txtFilter.Text= copyID.ToString();
            _FindNow();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _FindNow();
        }

       private void ShowDataBack(object sender, SaveCopyArg e)
        {
            cbFilter.SelectedIndex = 2;
            txtFilter.Text=e.CopyID.ToString();
            ctrlCopyDetails1.LoadCopyInfoByCopyID(e.CopyID);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateCopy frm = new frmAddUpdateCopy();
            frm.CopySave += ShowDataBack;
            frm.ShowDialog();
        }

        private void ctrlCopyDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}
