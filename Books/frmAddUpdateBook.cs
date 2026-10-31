using LibraryMangegment_BusnissLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;

namespace LibraryManegement
{
    public partial class frmAddUpdateBook : Form
    {
       public class SaveBookArg:EventArgs
        {
            public int BookID { get; }
            public string BookTitle { get; }
            public SaveBookArg(int BookID,string BookTitle)
            {
                this.BookID = BookID;
                this.BookTitle = BookTitle;
            }
        }
     public event EventHandler<SaveBookArg> SaveBook;
        protected virtual void ONSaveBook(SaveBookArg saveBookArg)
        {
            SaveBook?.Invoke(this, saveBookArg);
        }
        public enum enMode { AddNew=1,Update=2};
        private enMode _Mode=enMode.AddNew;
        private int _BookID;
        private clsBook _BookInfo;
        
        public frmAddUpdateBook(int BookID)
        {
            InitializeComponent();
            _BookID= BookID;
            _Mode = enMode.Update;
        }
        public frmAddUpdateBook()
        {
            InitializeComponent();
            _Mode= enMode.AddNew;
        }

        private void _ResetData()
        {
            if(_Mode==enMode.AddNew)
            {
                lblMode.Text = "AddNew Book";
               _BookInfo=new clsBook();
                return;
            }
            lblMode.Text = "Update Book";
            _BookInfo = clsBook.Find(_BookID);
        }
        private void _LoadData()
        {
            txtAuthor.Text = _BookInfo.Author;
            txtBookTitle.Text= _BookInfo.BookTitle;
            txtISBN.Text = _BookInfo.ISBN;
            txtCategory.Text= _BookInfo.Category;
            txtPuplisher.Text= _BookInfo.Puplisher;
            lblID.Text=_BookInfo.BookID.ToString();

        }
        private void frmAddUpdateBook_Load(object sender, EventArgs e)
        {
            _ResetData();
            if (_Mode == enMode.Update)
                _LoadData();
                
           
        }

        private void txtBookTitle_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This Filed not allowed empty");
            }
            else
                errorProvider1.SetError(textBox, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("there is some filed not correct");
                   return;
            }
            _BookInfo.BookTitle = txtBookTitle.Text;
            _BookInfo.ISBN = txtISBN.Text;
            _BookInfo.Author = txtAuthor.Text;
            _BookInfo.Puplisher= txtPuplisher.Text;
            _BookInfo.Category = txtCategory.Text;
            if (_BookInfo.Save())
            {
                lblID.Text = _BookInfo.BookID.ToString();
                lblMode.Text = "Update";
                ONSaveBook(new SaveBookArg(_BookInfo.BookID, _BookInfo.BookTitle));
                _Mode = enMode.Update;
                MessageBox.Show("Saved Data Successfully");
            }
            else
                MessageBox.Show("Data didn't Save");
        }
    }
}
