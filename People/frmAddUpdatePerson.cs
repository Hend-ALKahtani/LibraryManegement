using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManegement.Properties;
using LibraryMangegment_BusnissLogic;
namespace LibraryManegement
{
    public partial class frmAddUpdatePerson : Form
    {
        
        public class EventSavePersonArg : EventArgs
        {
            
            public int PersonID { get; }
            public string NationalNo { get; }
            public EventSavePersonArg(int personID, string nationalNo)
            {
                PersonID = personID;
                NationalNo = nationalNo;
            }
        }
        public event EventHandler<EventSavePersonArg> EventSavePerson;
        
        protected virtual void ONPersonSave(EventSavePersonArg e)
        {
            EventSavePerson?.Invoke(this, e);
        }
       
        public enum enMode { AddNew=0,Update=1};
        public enum enGendor { Male=0, Female=1};
        private int _PersonID = -1;
        private clsPerson _Person;
        private enMode _Mode = enMode.AddNew;
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode= enMode.AddNew; 
        }
        public frmAddUpdatePerson(int personID)
        {
            InitializeComponent ();
            _Mode = enMode.Update;
            _PersonID = personID;   
           
        }
        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountry();
            foreach(DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }
       private void _ResetDefualtValues()
        {
            _FillCountriesInComoboBox();
            if (_Mode == enMode.AddNew)
            {
                _Person = new clsPerson();
                lblTitle.Text = "Add New Person";
            }
            else
                lblTitle.Text = "Update Person";
            dtpDataOfBrith.MinDate= DateTime.Now.AddYears(-100);
            dtpDataOfBrith.MaxDate= DateTime.Now.AddYears(-18);
            dtpDataOfBrith.Value = dtpDataOfBrith.MaxDate;
            if(rbtnMale.Checked)
            {
                pbPersonImage.Image = Resources.Male_512;
            }
            else
                pbPersonImage.Image= Resources.Female_512;

            txtFirstName.Text = "";
            cbCountry.SelectedIndex = cbCountry.FindString("Yemen");
            llblRemoveImage.Visible = false;
        }
      public void Logger(string message)
        {
            string source = "LibraryManegement";
            try
            {
                if (!EventLog.SourceExists(source))
                {
                    EventLog.CreateEventSource(source,"Application");
                }
                EventLog.WriteEntry(source, message,EventLogEntryType.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool _HandelPersonImage()
        {
            if(_Person.ImagePath!= pbPersonImage.ImageLocation)
            {
                if(_Person.ImagePath!=null)
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch(IOException e)
                    {
                        Logger(e.Message);
                        MessageBox.Show(e.Message);
                    }
                }
                if(pbPersonImage.ImageLocation!=null)
                {
                   string SourceFileImage=pbPersonImage.ImageLocation.ToString();
                   if (clsUtil.CopyImageToProjectFolder( ref SourceFileImage))
                    {
                        pbPersonImage.ImageLocation = SourceFileImage;
                        return true;
                    }
                    MessageBox.Show("Error Copying image", "Error", MessageBoxButtons.OKCancel);
                    return false;

                }
            }
            return true;
        }
      private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);
            if(_Person==null)
            {
                MessageBox.Show("this person not found");
                this.Close();
                return;
            }
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.LastName;
            txtThirdName.Text= _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtAddress.Text= _Person.Address;
            if (_Person.Gender == 0)
                rbtnMale.Checked = true;
            else rbtnFemal.Checked = true;
            lblID.Text = _Person.PersonID.ToString();
            if (_Person.ImagePath != null)
                pbPersonImage.ImageLocation = _Person.ImagePath;
            dtpDataOfBrith.Value = _Person.DateOfBirth;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);
            llblRemoveImage.Visible = _Person.ImagePath != null;
        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Choose Picture";
           openFileDialog1.Filter = "image Files|*.jpg;*.jpeg;*.bmp;*.png;*.gif";

            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FilterIndex = 1;
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
               
                // pbPersonImage.Load(openFileDialog1.FileName);
                pbPersonImage.ImageLocation= openFileDialog1.FileName;
            }
            llblRemoveImage.Visible = true;
        }

        private void txtThirdName_Validated(object sender, EventArgs e)
        {

        }

       
        private void TextValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "Not Allowed Empty");
            }
            else
                errorProvider1.SetError(textBox, "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("there is some filed not correct");
                return; 
            }
            if (!_HandelPersonImage())
                return;
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecoundName = txtSecondName.Text.Trim();
            _Person.ThirdName=txtThirdName.Text.Trim();
            _Person.LastName= txtLastName.Text.Trim();
            _Person.NationalNo= txtNationalNo.Text.Trim();
            _Person.DateOfBirth = dtpDataOfBrith.Value;
            if (rbtnFemal.Checked)
                _Person.Gender = (short)enGendor.Female;
            else
                _Person.Gender = (short)enGendor.Male;
            if (pbPersonImage.ImageLocation != null)
            {
                _Person.ImagePath = pbPersonImage.ImageLocation;
            }
            else
                _Person.ImagePath = null;
            _Person.Address=txtAddress.Text.Trim();
            _Person.Email=txtEmail.Text.Trim();
            _Person.Phone=txtPhone.Text.Trim();
            _Person.NationalityCountryID = clsCountry.Find(cbCountry.Text).CountryID;
            if (_Person.Save())
            {
                lblID.Text = _Person.PersonID.ToString();
                lblTitle.Text = "Update Person";
               
                MessageBox.Show("Data Saved Successfully");
                ONPersonSave(new EventSavePersonArg(_Person.PersonID, _Person.NationalNo));
               // EventSavePerson?.Invoke(this,new EventSavePersonArg(,));
                
            }
            else
                MessageBox.Show("The data not saved");

        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "Must Enter Value");
            }
            else
                errorProvider1.SetError(txtNationalNo, null);
            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExsit(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This NationalNo Is Exsit To Anthor Person");
            }
            else
                errorProvider1.SetError(txtNationalNo, null);
        }

       

        

        private void rbtnMale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_512;
        }

        private void rbtnFemal_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_512;
        }

        private void llblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
           if(rbtnFemal.Checked)
                pbPersonImage.Image=Resources.Female_512;
           else
                pbPersonImage.Image=Resources.Male_512;
            llblRemoveImage.Visible=false;
        }
    }
}
