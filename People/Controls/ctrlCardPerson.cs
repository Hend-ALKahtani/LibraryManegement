using LibraryManegement.Properties;
using LibraryMangegment_BusnissLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManegement.frmAddUpdatePerson;

namespace LibraryManegement
{
    public partial class ctrlCardPerson : UserControl
    {
        int _personID = -1;
        public int PersonID { get { return _personID; } private set { _personID = value; } }
        public clsPerson PersonInfo { get; private set; }
        public ctrlCardPerson()
        {
            InitializeComponent();
        }
       private void _FillPersonData()
        {
            PersonID = PersonInfo.PersonID;
            lblName.Text = PersonInfo.FullName;
            lblNationalNo.Text = PersonInfo.NationalNo;
            lblDate.Text = PersonInfo.DateOfBirth.ToShortDateString();
            lblCountry.Text = PersonInfo.CountryInfo.CountryName;
            lblEmail.Text = PersonInfo.Email;
            lblGendor.Text = PersonInfo.Gender == 0 ? "Male" : "Female";
            lblID.Text = PersonInfo.PersonID.ToString();
            lblPhone.Text = PersonInfo.Phone;   
            lblAddress.Text = PersonInfo.Address;
            _LoadPersonImage();
        }
        private void _LoadPersonImage()
        {
            pbPersonimage.Image = PersonInfo.Gender == 0 ? Resources.Male_512 : Resources.Female_512;
            if(PersonInfo.ImagePath!=null)
            {
                if (File.Exists(PersonInfo.ImagePath))
                    pbPersonimage.ImageLocation = PersonInfo.ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + PersonInfo.ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void ResetPersonInfo()
        {
           
            lblID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblName.Text = "[????]";
            pbGendor.Image = Resources.Man_32;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDate.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonimage.Image = Resources.Male_512;

        }
        public void LoadPersoninfo(string NationalNo)
        {
            PersonInfo = clsPerson.Find(NationalNo);
            if (PersonInfo == null)
            {
                MessageBox.Show("This Person Not Exist");
                ResetPersonInfo();
                return;
            }
            else
                _FillPersonData();
        }
        public void LoadPersoninfo(int PersonId)
        {
            PersonInfo = clsPerson.Find(PersonId);
            if (PersonInfo == null)
            {
                PersonID = -1;
                MessageBox.Show("This Person Not Exist");
                ResetPersonInfo();
                return;
            }
            else
                _FillPersonData();
        }

       public void UpdatePersonInfo(object sender,EventSavePersonArg e)
        {
            LoadPersoninfo(e.PersonID);
        }
        private void llblEditePersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm=new frmAddUpdatePerson(PersonID);
            frm.EventSavePerson += UpdatePersonInfo;
            frm.ShowDialog();
            LoadPersoninfo(PersonID);
        }
    }
}
