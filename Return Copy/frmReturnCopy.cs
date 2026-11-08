using LibraryMangegment_BusnissLogic;
using System;
using System.Windows.Forms;
namespace LibraryManegement
{
    public partial class frmReturnCopy : Form
    {
        public clsBorrowing _Borrowing;
        public bool IsPaid { get; set; }
        public string Note{ get; set; }
      public string Date { get {return lblRetunDate.Text; } }
        public frmReturnCopy(clsBorrowing borrowing)
        {
            InitializeComponent();
            _Borrowing = borrowing;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Note = txtNote.Text;
            if(_Borrowing.OverDueDays>0)
            {
                DialogResult result = MessageBox.Show($"you have fine,{_Borrowing.TotalFineAmount},do you want pay now ", "Payment", MessageBoxButtons.YesNo);
                IsPaid = result == DialogResult.Yes;  
                
            }
            this.Close();
        }

       private void _LoadFeesInfo()
        {
            lblLateDays.Text = _Borrowing.OverDueDays.ToString();
            lblFees.Text = _Borrowing.FineAmountOFLate.ToString();
            lblTotal.Text=_Borrowing.TotalFineAmount.ToString();
        }
        private void frmReturnCopy_Load(object sender, EventArgs e)
        {
           if(_Borrowing.OverDueDays>0)
            {
                gbFeesInfo.Enabled= true;
                _LoadFeesInfo();
            }
            lblBookTitle.Text = _Borrowing.CopyInfo.BookInfo.BookTitle;
            lblMemberName.Text = _Borrowing.MemberInfo.PersonInfo.FullName;
            lblRetunDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblDuDate.Text = _Borrowing.DueDate.ToString("dd/MM/yyyy");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
