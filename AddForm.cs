using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_Ice_Task_2_ST10072500_Priya
{
        public partial class AddForm : Form
        {

            ArrayList firstNameList;
            ArrayList surnameList;
            ArrayList phoneNumList;
            ArrayList emailList;



            public AddForm(ArrayList firstNameList, ArrayList surnameList, ArrayList phoneNumList, ArrayList emailList)
            {
                InitializeComponent();
                this.firstNameList = firstNameList;
                this.surnameList = surnameList;
                this.phoneNumList = phoneNumList;
                this.emailList = emailList;
            }

            //this adds to the firstNameList
            private void textBox1_TextChanged(object sender, EventArgs e)
            {


            }

            //this adds to the surnanmeList
            private void userSuname_TextChanged(object sender, EventArgs e)
            {


            }

            //this adds to the phoneNumList
            private void userPhoneNum_TextChanged(object sender, EventArgs e)
            {

            }


            private void AddForm_Load(object sender, EventArgs e)
            {

            }


            //this adds to the emailList
            private void userEmail_TextChanged(object sender, EventArgs e)
            {


            }

            //this adds the donor when all textBoxs all filled with vaild values
            private void addDonorBtn_Click(object sender, EventArgs e)
            {
                if (ValidateInputs())
                {
                    // Here you can add the donor to your data structure or database
                    MessageBox.Show("Donor added successfully!");

                    firstNameList.Add(userFirstName.Text);
                    surnameList.Add(userSuname.Text);
                    phoneNumList.Add(userPhoneNum.Text);
                    emailList.Add(userEmail.Text);



                    // Close the form after adding the donor
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Please fill in all the fields with valid values.");
                }

            }

            private bool ValidateInputs()
            {
                return !string.IsNullOrWhiteSpace(userFirstName.Text) &&
                       !string.IsNullOrWhiteSpace(userSuname.Text) &&
                       !string.IsNullOrWhiteSpace(userPhoneNum.Text) &&
                       !string.IsNullOrWhiteSpace(userEmail.Text);

            }


        }
}


// References
// https://stackoverflow.com/questions/37801907/how-to-add-a-gridview-to-a-c-sharp-winforms-project-with-a-list-of-objects-as-th
// https://stackoverflow.com/questions/8148156/winforms-global-exception-handling
// https://stackoverflow.com/questions/9725510/how-to-store-data-in-a-net-windows-application
// https://stackoverflow.com/questions/42021980/how-to-update-form-after-it-has-started
