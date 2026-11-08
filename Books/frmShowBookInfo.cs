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
    public partial class frmShowBookInfo : Form
    {
       private int _BookID;
       public frmShowBookInfo(int bookID)
        {
            InitializeComponent();
            _BookID = bookID;
            ctrlBookInfo1.LoadData(bookID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowBookInfo_Load(object sender, EventArgs e)
        {
            clsBook book = clsBook.Find(_BookID);
            if (book != null)
            {
                DataTable _AllCopiesforBook=book.GetAllCopiesForBook();
                DataTable _CopiesOfBook = _AllCopiesforBook.DefaultView.ToTable(true, "CopyID", "BookID",
                    "Barcode", "IsAvailable", "CopyStatus");
                dgvCopiesForBooks.DataSource = _CopiesOfBook;
            }
        }
    }
}
