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
    public partial class EditForm : Form
    {
        ArrayList firstNameList;
        ArrayList surnameList;
        ArrayList phoneNumList;
        ArrayList emailList;

        List<DateTime> dateList;
        ArrayList causeList;
        ArrayList amountList;

        private int nameSearch;

        public EditForm(ArrayList firstNameList, ArrayList surnameList, ArrayList phoneNumList, ArrayList emailList, List<DateTime> dateList, ArrayList causeList, ArrayList amountList)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }







        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void newSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void newEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void newFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }





        private void SearchBtn_Click(object sender, EventArgs e)
        {

            nameSearch = firstNameList.IndexOf(oldFirstName.Text);
            if (nameSearch != -1)
            {

                MessageBox.Show("Donor found");
                string text = "";

                text += "Donor first name is:" + "\t";
                text += firstNameList[nameSearch] + "\n";

                text += "Donor surname is:" + "\t";
                text += surnameList[nameSearch] + "\n";

                text += "Donor email is:" + "\t";
                text += phoneNumList[nameSearch] + "\n";

                text += "Donor phone number is:" + "\t";
                text += emailList[nameSearch] + "\n";

                oldDisplay.Text = text;


            }
            else { MessageBox.Show("Donor not found"); }


        }

        private void ConfirmEditBtn_Click(object sender, EventArgs e)
        {

            firstNameList[nameSearch] = newFirstName.Text;
            surnameList[nameSearch] = newSurname.Text;
            phoneNumList[nameSearch] = newPhone.Text;
            emailList[nameSearch] = newEmail.Text;

            string text = "";

            text += "Donor first name is:" + "\t";
            text += firstNameList[nameSearch] + "\n";

            text += "Donor surname is:" + "\t";
            text += surnameList[nameSearch] + "\n";

            text += "Donor email is:" + "\t";
            text += phoneNumList[nameSearch] + "\n";

            text += "Donor phone number is:" + "\t";
            text += emailList[nameSearch] + "\n";

            newDisplay.Text = text;

        }

    }

}


// References
// https://stackoverflow.com/questions/37801907/how-to-add-a-gridview-to-a-c-sharp-winforms-project-with-a-list-of-objects-as-th
// https://stackoverflow.com/questions/8148156/winforms-global-exception-handling
// https://stackoverflow.com/questions/9725510/how-to-store-data-in-a-net-windows-application
// https://stackoverflow.com/questions/42021980/how-to-update-form-after-it-has-started