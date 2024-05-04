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
    public partial class Form1 : Form
    {
        public ArrayList firstNameList = new ArrayList();
        public ArrayList surnameList = new ArrayList();
        public ArrayList phoneNumList = new ArrayList();
        public ArrayList emailList = new ArrayList();

        //ArrayLists used in caputre form
        public List<DateTime> dateList = new List<DateTime>();
        public ArrayList causeList = new ArrayList();
        public ArrayList amountList = new ArrayList();


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Size = new Size(200, 20);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Add Donor":
                    AddForm addForm = new AddForm(firstNameList, surnameList, phoneNumList, emailList);
                    addForm.Show();
                    break;
                case "Capture a donation":
                    captureForm capForm = new captureForm(firstNameList, surnameList, phoneNumList, emailList, dateList, causeList, amountList);
                    capForm.Show();
                    break;
                case "Search for  a donor":
                    ViewFrom viewForm2 = new ViewFrom(firstNameList, surnameList, phoneNumList, emailList, dateList, causeList, amountList);
                    viewForm2.Show();
                    break;
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}


// References
// https://stackoverflow.com/questions/37801907/how-to-add-a-gridview-to-a-c-sharp-winforms-project-with-a-list-of-objects-as-th
// https://stackoverflow.com/questions/8148156/winforms-global-exception-handling
// https://stackoverflow.com/questions/9725510/how-to-store-data-in-a-net-windows-application
// https://stackoverflow.com/questions/42021980/how-to-update-form-after-it-has-started
