using LibraryMangegment_BusnissLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManegement.frmAddUpdatePerson;

namespace LibraryManegement
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
       
      public int PersonID { get { return ctrlCardPerson1.PersonID; }  }
     public clsPerson PersonInfo { get { return ctrlCardPerson1.PersonInfo; } }
        public bool EnableFilterBox
        {
            set { gbFilter.Enabled = value; }
            get { return gbFilter.Enabled; }
        }

        public class PersonSelectArg:EventArgs
        {

            
            public int PersonID { get; }
            public string NationalNo { get;}
            public PersonSelectArg(int personID, string nationalNo)
            {
                PersonID = personID;
                NationalNo = nationalNo;
            }
        }
        public event EventHandler<PersonSelectArg> PersonSelect;
        protected virtual void OnPersonSelected(PersonSelectArg personSelectArg)
        {
            PersonSelect?.Invoke(this, personSelectArg);
        }
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

       public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.Text = "Person ID";
            txtFilter.Text = PersonID.ToString();
            FindNow();
        }
       private void FindNow()
        {
            switch(cbFilterBy.Text)
            {
                case "Person ID":
                    {
                        ctrlCardPerson1.LoadPersoninfo(Int32.Parse(txtFilter.Text));
                        break;
                    }
                case "National No":
                    {
                        ctrlCardPerson1.LoadPersoninfo(txtFilter.Text.Trim());
                        break;
                    }
                default:
                    break;
            }
            if (PersonSelect!=null && EnableFilterBox)
                OnPersonSelected(new PersonSelectArg(ctrlCardPerson1.PersonID, ctrlCardPerson1.PersonInfo.NationalNo));
        }
      private void ShowDataBack(object sender, EventSavePersonArg personArg)
        {
            txtFilter.Text = personArg.PersonID.ToString();
            cbFilterBy.SelectedIndex = 0;
            ctrlCardPerson1.LoadPersoninfo(personArg.PersonID);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm=new frmAddUpdatePerson();
            frm.EventSavePerson += ShowDataBack;
            frm.ShowDialog();

        }

        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilter, "Enter Value To Search");
            }
            else
                errorProvider1.SetError(txtFilter, null);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if(cbFilterBy.Text=="Person ID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            if(e.KeyChar==13)
            {
                btnSearch.PerformClick();
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           if (!ValidateChildren())
            {
                MessageBox.Show("Some filed are not Valide put mouse over red icon(s)", "Validation Erroe", MessageBoxButtons.OK);
                return;
            }
            FindNow();
        }
        public void RestPersonInfo()
        {
            ctrlCardPerson1.ResetPersonInfo();
        }
    }
}
