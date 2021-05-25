using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class frmCarassociation : Form
    {
        ArrayList memberlist = new ArrayList();
        Member member;
        public frmCarassociation()
        {
            InitializeComponent();
            try
            {
                StreamReader read = new StreamReader("Test Data.txt");
                string aName, aIc, aDOB, aPhoneNum, aCarRegNum, aCarModel, aCarYear,aTypeOfMembership;
                DateTime aMembership;
                Car aCar;
                aName = read.ReadLine();
                while (aName != null)
                {
                    aIc = read.ReadLine();
                    aDOB = read.ReadLine();
                    aPhoneNum = read.ReadLine();
                    aMembership = Convert.ToDateTime(read.ReadLine());
                    aCarRegNum = read.ReadLine();
                    aCarModel = read.ReadLine();
                    aCarYear = read.ReadLine();
                    aCar = new Car(aCarRegNum, aCarModel, aCarYear);
                    aTypeOfMembership = read.ReadLine();
                    if (aTypeOfMembership == "One Year Membership")
                    {
                        OneYearMember aMember = new OneYearMember(aName, aIc, aDOB, aMembership, aPhoneNum, aCar);
                        memberlist.Add(aMember);
                    }
                    else 
                    {
                        FiveYearMember aMember = new FiveYearMember(aName, aIc, aDOB, aMembership, aPhoneNum, aCar);
                        memberlist.Add(aMember);
                    }
                    aName = read.ReadLine();
                }
                read.Close();
            }
            catch (IOException exc)
            {
                MessageBox.Show("File error: " + exc.Message);
            }
        }

        private void frmCarassociation_Load(object sender, EventArgs e)
        {
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            formatingForm();
            tbxSearch.Enabled = true;          
            lblinstruction.Text ="";
        }

        private void lblIc_Click(object sender, EventArgs e)
        {}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {}

        private void btnRenewMember_Click(object sender, EventArgs e)
        {
            formatingForm();
            panel1.Visible = false;
            btnRenew.Enabled = true;
            tbxSearch.Enabled = true;
            lblinstruction.Text =
           "Instructions               :  Click renew to renew member's membership!!";
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            formatingForm();
            panel1.Visible = false;
            btnEdit.Enabled = true;
            tbxSearch.Enabled = true;
            tbxCarRegNum.Enabled = true;
            tbxModel.Enabled = true;
            tbxPhone.Enabled = true;
            tbxYear.Enabled = true;
            lblinstruction.Text = 
           "Instructions               :  Enter the new details of member and click edit to edit member's details!!";
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            formatingForm();
            rbnFiveYearMembership.Visible = true;
            rbnOneYearMembership.Visible = true;      
            panel2.Visible = false;
            panel1.Visible = true;
            btnAdd.Enabled = true;
            panel1.Enabled = true;
            tbxCarRegNum.Enabled = true;
            tbxModel.Enabled = true;
            tbxPhone.Enabled = true;
            tbxYear.Enabled = true;
            tbxDob.Enabled = true;
            tbxIc.Enabled = true;
            tbxName.Enabled = true;
            tbxMembership.Enabled = true;
            tbxMembership.Text = "DD/MM/YYYY";
            lblinstruction.Text =
           "Instructions               :  Enter details of member and click add to add new member!!";
            lblTypeOfMembership.Text = "Type Of Membership:";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            panel1.Visible = true;
            panel1.Enabled = true;
            tbxSearch.Enabled = false;
            
            string input = tbxSearch.Text;
            int count = memberlist.Count;
            for (int i = 0; i < count; i++)
            {
                if (memberlist[i] is OneYearMember)
                {
                    member = (OneYearMember)memberlist[i];
                }
                else
                {
                    member = (FiveYearMember)memberlist[i];
                }
                
                Car car = member.Car;
                if (input == member.Ic)
                {
                    if (member is OneYearMember)
                    { lblTypeOfMembership.Text = "Type Of Membership:  One Year Membership";}
                    else
                    {lblTypeOfMembership.Text = "Type Of Membership:  Five Year Membership";}
                    tbxName.Text=member.Name;
                    tbxIc.Text = member.Ic;
                    tbxDob.Text = member.DateOfBirth;
                    tbxMembership.Text =Convert.ToString(member.Membership);
                    tbxPhone.Text = member.PhoneNum;
                    tbxCarRegNum.Text = car.CarRegNumber;
                    tbxModel.Text = car.Model;
                    tbxYear.Text = car.Year;     
                    break;
                }
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            btnRenew.Enabled = false;
            panel1.Enabled = false;
            if(member is FiveYearMember)
            {
                FiveYearMember amember = (FiveYearMember)member;
                amember.Renewal();
            }
            else { member.Renewal(); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            panel1.Enabled = false;

            Car car=member.Car;
            member.PhoneNum = tbxPhone.Text;
            car.CarRegNumber = tbxCarRegNum.Text;
            car.Model = tbxModel.Text;
            car.Year = tbxYear.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            panel1.Enabled = false;
            try
            {
                string aName, aIc, aDob, aPhoneNum;
                DateTime aMembership;
                Car aCar;
                aName = tbxName.Text;
                aIc = tbxIc.Text;
                aDob = tbxDob.Text;
                aPhoneNum = tbxPhone.Text;
                aMembership = Convert.ToDateTime(tbxMembership.Text);
                string aCarRegNum = tbxCarRegNum.Text;
                string aCarModel = tbxModel.Text;
                string aCarYear = tbxYear.Text;
                aCar = new Car(aCarRegNum, aCarModel, aCarYear);
                if (rbnOneYearMembership.Checked)
                {
                    OneYearMember aMember = new OneYearMember(aName, aIc, aDob, aMembership, aPhoneNum, aCar);
                    memberlist.Add(aMember);
                }
                if(rbnFiveYearMembership.Checked)
                {
                    FiveYearMember aMember = new FiveYearMember(aName, aIc, aDob, aMembership, aPhoneNum, aCar);
                    memberlist.Add(aMember);
                }
            }
            catch(FormatException exc)
            {
                MessageBox.Show("Invalid data: "
                               + exc.Message);
            }
        }

        public void formatingForm()
        {
            rbnOneYearMembership.Visible = false;
            rbnFiveYearMembership.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            btnSearch.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnRenew.Enabled = false;
            tbxSearch.Enabled = false;
            tbxDob.Enabled = false;
            tbxIc.Enabled = false;
            tbxName.Enabled = false;
            tbxMembership.Enabled = false;
            tbxCarRegNum.Enabled = false;
            tbxModel.Enabled = false;
            tbxPhone.Enabled = false;
            tbxYear.Enabled = false;
            tbxName.Text = "";
            tbxIc.Text = "";
            tbxDob.Text = "";
            tbxMembership.Text = "";
            tbxPhone.Text = "";
            tbxCarRegNum.Text = "";
            tbxModel.Text = "";
            tbxYear.Text = "";
            tbxSearch.Text = "";
            lblTypeOfMembership.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveData();   
        }

        private void frmCarassociation_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveData();
            MessageBox.Show("Saved successfully and quit!!");
        }

        public void saveData()
        {
            try
            {
                string typeOfMembership;
                int count = memberlist.Count;
                MessageBox.Show("There are " + count + " members in total saved!!");
                StreamWriter write = new StreamWriter("Test Data.txt");
                for (int i = 0; i < count; i++)
                {
                    if (memberlist[i] is OneYearMember)
                    {
                        member = (OneYearMember)memberlist[i];
                        typeOfMembership = "One Year Membership";
                    }
                    else
                    {
                        member = (FiveYearMember)memberlist[i];
                        typeOfMembership = "Five Year Membership";
                    }
                    write.WriteLine(member.Name);
                    write.WriteLine(member.Ic);
                    write.WriteLine(member.DateOfBirth);
                    write.WriteLine(member.PhoneNum);
                    write.WriteLine(member.Membership);
                    write.WriteLine(member.Car.CarRegNumber);
                    write.WriteLine(member.Car.Model);
                    write.WriteLine(member.Car.Year);
                    write.WriteLine(typeOfMembership);
                }
                write.Close();
            }
            catch (IOException exc)
            {
                MessageBox.Show("File error: " + exc.Message);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
