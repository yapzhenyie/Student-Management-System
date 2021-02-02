using StudentManagementSystem.Classes;
using StudentManagementSystem.Database;
using StudentManagementSystem.SubForms;
using StudentManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class LoginForm : Form
    {
        private bool rememberMe = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            login();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e) {
            //Press enter
            if (e.KeyChar == (char) 13) {
                login();
            }
        }

        public void clearTextboxes() {
            this.textBoxUsername.Text = "";
            this.textBoxPassword.Text = "";
        }

        public void login() {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (password == "") {
                MessageBox.Show("Username cannot be empty.");
                return;
            }
            if (password == "") {
                MessageBox.Show("Password cannot be empty.");
                return;
            }
            password = Md5Converter.encrypt(password);
            User user = Program.getDatabaseUtils().verifyUser(username, password);
            if (user == null) {
                this.textBoxPassword.Text = "";
                return;
            }
            User.setCurrentUser(user);
            clearTextboxes();
            switch (user.Type) {
                case EnumUser.Staff:
                    Program.getLoginForm().Hide();
                    Program.initStaffForm();
                    Program.getStaffForm().initProfileName();
                    Program.getStaffForm().setCurrentSelectedLabel(1);
                    StudentRegistrationForm.showAllComponents();
                    Program.getStaffForm().ShowDialog();
                    Program.getLoginForm().Close();
                    break;
                case EnumUser.Tutor:
                    Program.getLoginForm().Hide();
                    Program.initTutorForm();
                    Program.getTutorForm().initProfileName();
                    Program.getTutorForm().setCurrentSelectedLabel(1);
                    TutorClassScheduleForm.showAllComponents();
                    TutorClassScheduleForm.updateTutorInformation();
                    Program.getTutorForm().ShowDialog();
                    Program.getLoginForm().Close();
                    break;
                case EnumUser.Student:
                    Program.getLoginForm().Hide();
                    Program.initStudentForm();
                    Program.getStudentForm().initProfileName();
                    Program.getStudentForm().setCurrentSelectedLabel(1);
                    StudentProfileForm.showAllComponents();
                    StudentProfileForm.updateStudentInformation();
                    Program.getStudentForm().ShowDialog();
                    Program.getLoginForm().Close();
                    break;
                default:
                    MessageBox.Show("An error occurred while logging in.");
                    break;
            }
        }

        /*private void labelForgotPassword_Click(object sender, EventArgs e) {
            MessageBox.Show("Please inform the administrator to change new password!");
        }

        private void checkBoxRemember_CheckedChanged(object sender, EventArgs e) {
            if(checkBoxRemember.Checked) {
                rememberMe = true;
            }
        }*/

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
