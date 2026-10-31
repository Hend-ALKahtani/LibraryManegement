using LibraryMangegment_BusnissLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryMangegment_BusnissLogic.clsBookCopy;

namespace LibraryManegement
{
    public partial class frmAddUpdateCopy : Form
    {
       public class SaveCopyArg:EventArgs
        {
            public int CopyID { get; }
            public string BookTitle { get; }
            public SaveCopyArg(int copyID,string bookName)
            {
                CopyID= copyID;
                BookTitle= bookName; 
            }
        }
        public event EventHandler<SaveCopyArg> CopySave;
       protected virtual void OnBookSaved(SaveCopyArg e)
        {
            CopySave?.Invoke(this, e);
        }
      //  public enum enStatusCopy { New=1,Good=2,Damage=3};
        
        public enum enMode { AddNew=1,Update=2};
        private enMode _Mode = enMode.AddNew;
        private int _CopyID;
        private clsBookCopy _CopyInfo;
        public frmAddUpdateCopy()
        {
            InitializeComponent();
            _Mode=enMode.AddNew;
        }
        public frmAddUpdateCopy(int CopyID)
        {
            InitializeComponent();
            _CopyID = CopyID;
            _Mode = enMode.Update;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                if (ctrlBookInfoWithFilter1.BookID == -1)
                {
                    MessageBox.Show("Please choose book to Insert its Copy");
                    return;
                }
                
               btnSave.Enabled = true;
               tpCopyInfo.Enabled = true;
            }

            
            tpcInfo.SelectedTab = tpcInfo.TabPages["tpCopyInfo"];
            
        }
        private void _SetData()
        {
            if(_Mode==enMode.AddNew)
            {
                _CopyInfo= new clsBookCopy();
                cbStatusCopy.SelectedIndex = 0;
                tpCopyInfo.Enabled = false;
                btnSave.Enabled = false;
                btnRenewBarcode.Enabled = false;
                lblMode.Text = "New";
            }
            else
            {
                btnSave.Enabled = true;
                ctrlBookInfoWithFilter1.EnabledFilterBook = false;

                lblMode.Text = "Update";
                _CopyInfo = clsBookCopy.Find(_CopyID);
                enStatusCopy CopyStatus = (enStatusCopy)_CopyInfo.Condition;
                cbStatusCopy.Enabled = true;
                bool isMatch = SecurityManager.IsAthorized(typeof(clsBookCopy), nameof(clsBookCopy.RenewBarcode), Global.CurrentUser.UserName);
                btnRenewBarcode.Enabled = isMatch && CopyStatus == enStatusCopy.Damage;
                     
            }
        }
      
        private void _LoadData()
        {
            ctrlBookInfoWithFilter1.LoadData(_CopyInfo.BookID);
            lblID.Text = _CopyInfo.CopyID.ToString();
            chBoxIsAvailable.Checked = _CopyInfo.IsAvailable;
            txtBarcode.Text=_CopyInfo.Barcode;
            cbStatusCopy.Text = _CopyInfo.GetStatusCopyText;
        }
      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmAddUpdateCopy_Load(object sender, EventArgs e)
        {
            _SetData();
            if(_Mode==enMode.Update)
            {
                _LoadData();
            }
        }

     
        private enStatusCopy _GetCopyStatuse()
        {
            enStatusCopy enStatusCopy;
            switch(cbStatusCopy.Text)
            {
                case "New":
                    {
                        enStatusCopy = enStatusCopy.New;
                        break;
                    }
                case "Good":
                    {
                        enStatusCopy= enStatusCopy.Good;
                        break;
                    }
                case "Damage":
                    {
                        enStatusCopy= enStatusCopy.Damage;
                        break;
                    }
                default:
                    {
                        enStatusCopy= enStatusCopy.New;
                        break;
                    }
            }
            return enStatusCopy;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            _CopyInfo.IsAvailable = chBoxIsAvailable.Checked;
            _CopyInfo.Condition = _GetCopyStatuse();
            _CopyInfo.BookID = ctrlBookInfoWithFilter1.BookID;

            if (_CopyInfo.Save())
            {
                txtBarcode.Text = _CopyInfo.Barcode;
                lblID.Text = _CopyInfo.CopyID.ToString();
                _Mode = enMode.Update;
                lblMode.Text = "Update";
                OnBookSaved(new SaveCopyArg(_CopyInfo.CopyID, ctrlBookInfoWithFilter1.BookInfo.BookTitle));
                MessageBox.Show("Save successfully");
            }
            else
                MessageBox.Show("Not Saved");
        }

        private void btnRenewBarcode_Click(object sender, EventArgs e)
        {
            if (_CopyInfo.RenewBarcode())
            {
                txtBarcode.Text = _CopyInfo.Barcode;
                btnRenewBarcode.Enabled = false;
                cbStatusCopy.Text = "New";
                cbStatusCopy.Enabled = false;
                _CopyInfo.Condition = _GetCopyStatuse();
            }
            else
                MessageBox.Show("failed to renew barcode");
        }

        private void cbStatusCopy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_Mode==enMode.AddNew)
            {
                return;
            }
            bool isMatch = SecurityManager.IsAthorized(typeof(clsBookCopy), "RenewBarcode", Global.CurrentUser.UserName);

            btnRenewBarcode.Enabled = (cbStatusCopy.Text == "Damage" && isMatch);
        }
    }
}
