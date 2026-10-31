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
using static LibraryManegement.frmAddUpdateBook;

namespace LibraryManegement
{
    public partial class ctrlBookInfo : UserControl
    {
        private int _BookID = -1;
        public int BookID { get { return _BookID; } private set { _BookID = value; } }
        public clsBook BookInfo { get; private set; }
        public ctrlBookInfo()
        {
            InitializeComponent();
        }
        private void _ResetData()
        {
            lblBookID.Text = "???";
            lblBookTitle.Text= "???";
            lblISBN.Text = "???";
            lblAuthor.Text= "???";
            lblCategory.Text= "???";
            lblPuplisher.Text= "???";
            lblNumberOfCopies.Text= "???";
           
        }
        private void _FillData()
        {
            BookID = BookInfo.BookID;
            lblBookID.Text = BookInfo.BookID.ToString(); 
            lblBookTitle.Text = BookInfo.BookTitle;
            lblISBN.Text = BookInfo.ISBN;
            lblCategory.Text= BookInfo.Category;
            lblAuthor.Text= BookInfo.Author;
            lblPuplisher.Text = BookInfo.Puplisher;
            lblNumberOfCopies.Text = BookInfo.GetCountCopyOfBook().ToString();
        }
        public void LoadData(int BookID)
        {
            BookInfo = clsBook.Find(BookID);
            if(BookInfo==null)
            {
                BookID = -1;
                MessageBox.Show("this book not found");
                _ResetData();
                return;
            }
            _FillData();
        }
        public void LoadData(string BookTitle)
        {
            BookInfo = clsBook.Find(BookTitle);
            if (BookInfo == null)
            {
                BookID = -1;
                MessageBox.Show("this book not found");
                _ResetData();
                return;
            }
            _FillData();
        }
       
        private void LoadData(object sender, SaveBookArg saveBookArg)
        {
            BookInfo = clsBook.Find(saveBookArg.BookID);
            if (BookInfo == null)
            {
                BookID = -1;
                MessageBox.Show("this book not found");
                _ResetData();
                return;
            }
            _FillData();
        }

        private void llblEditBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook(BookID);
            frm.SaveBook += LoadData;
            frm.ShowDialog();
        }
    }
}
