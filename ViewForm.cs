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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROG_Ice_Task_2_ST10072500_Priya
{
    public partial class ViewFrom : Form
    {

        ArrayList firstNameList;
        ArrayList surnameList;
        ArrayList phoneNumList;
        ArrayList emailList;

        List<DateTime> dateList;
        ArrayList causeList;
        ArrayList amountList;

        public ViewFrom(ArrayList firstNameList, ArrayList surnameList, ArrayList phoneNumList, ArrayList emailList, List<DateTime> dateList, ArrayList causeList, ArrayList amountList)
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


        //user enter name to be searched   here
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //user enters surname to be searched here
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }



        //user enters date of donation from capture form here
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }


        private void textBox2_TextChanged(object sender, EventArgs e) { }



        //user enters donation amount here to be searched
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }




        //this button searchs the arrayLists for the values entered in the textBoxs above
        private void searchBtn_Click(object sender, EventArgs e)
        {


            //&& dateList.Contains(dateTimePicker1.Value) 

            if (firstNameList.Contains(textBox1.Text) && surnameList.Contains(textBox2.Text) && amountList.Contains(textBox3.Text))
            {
                int nameSearch = firstNameList.IndexOf(textBox1.Text);
                if (nameSearch != -1)
                {

                    MessageBox.Show("Name found");
                    string text = "";
                    text += firstNameList[nameSearch] + "\t";
                    text += surnameList[nameSearch];

                    dataGridView1.Rows.Add(text, amountList[nameSearch], dateList[nameSearch], causeList[nameSearch]);


                }



            }
            else { MessageBox.Show("Donor not found"); }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void ViewFrom_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }





        private void editBtn_Click(object sender, EventArgs e)
        {

            EditForm editForm = new EditForm(firstNameList, surnameList, phoneNumList, emailList, dateList, causeList, amountList);
            editForm.Show();
        }



        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(textBox1.Text) &&
                   !string.IsNullOrWhiteSpace(textBox2.Text);


        }



    }
}



// References
// https://stackoverflow.com/questions/37801907/how-to-add-a-gridview-to-a-c-sharp-winforms-project-with-a-list-of-objects-as-th
// https://stackoverflow.com/questions/8148156/winforms-global-exception-handling
// https://stackoverflow.com/questions/9725510/how-to-store-data-in-a-net-windows-application
// https://stackoverflow.com/questions/42021980/how-to-update-form-after-it-has-started