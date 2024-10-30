﻿using QuanLyNhanVienTTCSN_Nhom9.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    public partial class ProfileForm : Form
    {
        private string idAcc = null;
        private string idEmployee = null;

        public ProfileForm(string idAcc, string idEmployee)
        {
            InitializeComponent();
            this.idAcc = idAcc;
            this.idEmployee = idEmployee;
            this.showInfor();
        }

        public string IdAcc
        {
            set 
            { 
                idAcc = value;
            }
            get 
            { 
                return idAcc; 
            }   
        }

        public string Employee
        { 
            get 
            { 
                return idEmployee; 
            }
            set 
            { 
                idEmployee = value; 
            }
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            DoiMKForm changePasswordForm = new DoiMKForm(idAcc);
            changePasswordForm.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            logOutBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void logOutBtn_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void logOutBtn_MouseLeave(object sender, EventArgs e)
        {
            logOutBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void showInfor()
        {
            ProfileControl profileControl = new ProfileControl();
            DataTable table = profileControl.LoadInfor(idEmployee);
            idEmployeeTextBox.Text = table.Rows[0][0].ToString();
            fullNameTextBox.Text = table.Rows[0][1].ToString();
            addressTextBox.Text = table.Rows[0][2].ToString();
            phoneNumberTextBox.Text = table.Rows[0][3].ToString();
            identificationCardTextBox.Text = table.Rows[0][4].ToString();
            mailTextBox.Text = table.Rows[0][5].ToString();
            dateOfBirthTextBox.Text = table.Rows[0][6].ToString();
            dateJoinCompanyTextBox.Text = table.Rows[0][7].ToString();
            GenderTextBox.Text = table.Rows[0][8].ToString();
            positionTextBox.Text = table.Rows[0][11].ToString();
            DepartmentTextBox.Text = table.Rows[0][13].ToString();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>();

            // Find forms to close without closing the specified form (e.g., DangNhapForm)
            foreach (Form form in Application.OpenForms)
            {
                if (form != this && form.Name != "DangNhapForm") // Replace 'this' with the form you want to keep open
                {
                    formsToClose.Add(form);
                }
            }
            this.Hide();
            // Close the forms outside the iteration loop
            for(int i = formsToClose.Count - 1; i >-1; i--) 
            { 
                formsToClose[i].Hide(); 
            }


            DangNhapForm dangNhapForm = new DangNhapForm();
            dangNhapForm.ShowDialog();
        }

        private void logOutBtn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
