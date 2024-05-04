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
    public partial class captureForm : Form
    {

        ArrayList firstNameList;
        ArrayList surnameList;
        ArrayList phoneNumList;
        ArrayList emailList;

        List<DateTime> dateList;
        ArrayList causeList;
        ArrayList amountList;



        public captureForm(ArrayList firstNameList, ArrayList surnameList, ArrayList phoneNumList, ArrayList emailList, List<DateTime> dateList, ArrayList causeList, ArrayList amountList)
        {
            InitializeComponent();
            this.firstNameList = firstNameList;
            this.surnameList = surnameList;
            this.phoneNumList = phoneNumList;
            this.emailList = emailList;

            this.dateList = dateList;
            this.causeList = causeList;
            this.amountList = amountList;

        }

        //The first name should match with a name in the firstNameList from the add from
        private void firstName_TextChanged(object sender, EventArgs e)
        {


        }

        //The surname should match with a surname in the surnameList add form
        private void surname_TextChanged(object sender, EventArgs e)
        {




        }

        //the user can select a date which the donation is made and adds to dateList
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {


        }

        //the user can select an amount to donate this should only be a double value and adds to amountList
        private void amount_TextChanged(object sender, EventArgs e)
        {


        }

        //this allows the user to input a cause to donate to and adds to causeList
        private void cause_TextChanged(object sender, EventArgs e)
        {

        }






        // this button adds the above to the arrayLists if the above values are valid
        private void captureBtn_Click(object sender, EventArgs e)
        {


            if (firstNameList.Contains(firstName.Text) && surnameList.Contains(surname.Text))
            {
                MessageBox.Show("Donor name is valid, donation has been captured");

                DateTime selectedDate = datePicker.Value;

                dateList.Add(selectedDate);


                amountList.Add(amount.Text);


                causeList.Add(cause.Text);



                this.Close();


            }

            else
            {
                MessageBox.Show("Donor not found. Please add donor");
            }




        }



        private bool ValidateInputs()
        {
            return

                   !string.IsNullOrWhiteSpace(cause.Text);
        }



    }
}


// References
// https://stackoverflow.com/questions/37801907/how-to-add-a-gridview-to-a-c-sharp-winforms-project-with-a-list-of-objects-as-th
// https://stackoverflow.com/questions/8148156/winforms-global-exception-handling
// https://stackoverflow.com/questions/9725510/how-to-store-data-in-a-net-windows-application
// https://stackoverflow.com/questions/42021980/how-to-update-form-after-it-has-started