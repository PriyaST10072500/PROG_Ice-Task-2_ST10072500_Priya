using System;

namespace PROG_Ice_Task_2_ST10072500_Priya
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userFirstName = new System.Windows.Forms.TextBox();
            this.userSuname = new System.Windows.Forms.TextBox();
            this.userPhoneNum = new System.Windows.Forms.TextBox();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.addDonorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add A Donor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Please enter the following details";
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(167, 128);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.Size = new System.Drawing.Size(158, 20);
            this.userFirstName.TabIndex = 6;
            this.userFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userSuname
            // 
            this.userSuname.Location = new System.Drawing.Point(167, 173);
            this.userSuname.Name = "userSuname";
            this.userSuname.Size = new System.Drawing.Size(158, 20);
            this.userSuname.TabIndex = 7;
            this.userSuname.TextChanged += new System.EventHandler(this.userSuname_TextChanged);
            // 
            // userPhoneNum
            // 
            this.userPhoneNum.Location = new System.Drawing.Point(167, 220);
            this.userPhoneNum.Name = "userPhoneNum";
            this.userPhoneNum.Size = new System.Drawing.Size(158, 20);
            this.userPhoneNum.TabIndex = 8;
            this.userPhoneNum.TextChanged += new System.EventHandler(this.userPhoneNum_TextChanged);
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(167, 261);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(158, 20);
            this.userEmail.TabIndex = 9;
            this.userEmail.TextChanged += new System.EventHandler(this.userEmail_TextChanged);
            // 
            // addDonorBtn
            // 
            this.addDonorBtn.Location = new System.Drawing.Point(167, 312);
            this.addDonorBtn.Name = "addDonorBtn";
            this.addDonorBtn.Size = new System.Drawing.Size(75, 23);
            this.addDonorBtn.TabIndex = 10;
            this.addDonorBtn.Text = "Add Donor";
            this.addDonorBtn.UseVisualStyleBackColor = true;
            this.addDonorBtn.Click += new System.EventHandler(this.addDonorBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 365);
            this.Controls.Add(this.addDonorBtn);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.userPhoneNum);
            this.Controls.Add(this.userSuname);
            this.Controls.Add(this.userFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userFirstName;
        private System.Windows.Forms.TextBox userSuname;
        private System.Windows.Forms.TextBox userPhoneNum;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.Button addDonorBtn;
        

    }
}