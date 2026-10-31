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
    public partial class ctrlCopyDetails : UserControl
    {
        private int _CopyID = -1;
      
        public int CopyID { get { return _CopyID; } }
        public clsBookCopy CopyInfo{ get; private set; }
        public ctrlCopyDetails()
        {
            InitializeComponent();
        }
      
        private void SetData()
        {
            lblCopyID.Text = "[???]";
            lblBookTitle.Text = "[???]";
            lblBarcode.Text = "[???]";
            lblStatuse.Text = "[???]";
            lblAvalaible.Text = "[???]";
        }
       private void _FillData()
        {
            _CopyID = CopyInfo.CopyID;
            lblAvalaible.Text = CopyInfo.IsAvailable ? "Yes" : "No";
            lblCopyID.Text = CopyInfo.CopyID.ToString();
            lblBarcode.Text = CopyInfo.Barcode;
            lblBookTitle.Text = CopyInfo.BookInfo.BookTitle;
            lblStatuse.Text = CopyInfo.GetStatusCopyText;
        }
        public void LoadCopyInfoByCopyID(int CopyID)
        {
            CopyInfo = clsBookCopy.Find(CopyID);
            if(CopyInfo == null)
            {
                _CopyID = -1;
                SetData();
                MessageBox.Show("this copy not found");
                return;
            }
            _FillData();
        }
        public void LoadCopyInfoByBarcode(string Barcode)
        {
            CopyInfo = clsBookCopy.FindByBarcode(Barcode);
            if (CopyInfo == null)
            {
                SetData();
                MessageBox.Show($"this copy with{Barcode} not found");
                return;
            }
            _FillData();
        }
        public void LoadCopyInfoByBookTitle(string BookTitle)
        {
            CopyInfo = clsBookCopy.FindByBookTitle(BookTitle);
            if (CopyInfo == null)
            {
                SetData();
                MessageBox.Show($"this copy with{BookTitle} not found");
                return;
            }
            _FillData();
        }

        private void LoadData(object sender, SaveCopyArg saveCopyArg)
        {
            CopyInfo = clsBookCopy.Find(saveCopyArg.CopyID);

            if (CopyInfo == null)
            {
                SetData();
                MessageBox.Show("this copy not found");
                return;
            }
            _FillData();
        }
        private void llblEditeCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateCopy frm = new frmAddUpdateCopy(CopyID);
            frm.CopySave += LoadData;
            frm.ShowDialog();
        }

        private void llblShowBookDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CopyInfo == null)
            {
                MessageBox.Show("You dont choose copy to show details book");
                return;
            }
            frmShowBookInfo frm = new frmShowBookInfo(CopyInfo.BookID);
            frm.ShowDialog();
        }
    }
}
