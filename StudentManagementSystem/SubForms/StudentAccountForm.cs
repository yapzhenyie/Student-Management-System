using StudentManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.SubForms {
    class StudentAccountForm {

        private static List<Control> components = new List<Control>();

        private static Label labelStudentAccount;
        private static Label labelUsername;
        private static Label labelPassword;
        private static Label labelConfirmPassword;
        private static TextBox textBoxUsername;
        private static TextBox textBoxPassword;
        private static TextBox textBoxConfirmPassword;
        private static Button buttonConfirm;
        private static Button buttonBack;

        private static ErrorProvider err = Program.getStaffForm().errorProvider1;

        private static bool initialized = false;

        public static void initComponents() {
            if (initialized == true) {
                return;
            }
            labelStudentAccount = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            labelConfirmPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            buttonConfirm = new Button();
            buttonBack = new Button();
            // 
            // labelStudentAccount
            // 
            labelStudentAccount.AutoSize = true;
            labelStudentAccount.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentAccount.Location = new System.Drawing.Point(196, 58);
            labelStudentAccount.Name = "labelStudentAccount";
            labelStudentAccount.Size = new System.Drawing.Size(236, 37);
            labelStudentAccount.TabIndex = 0;
            labelStudentAccount.Text = "Student Account";
            components.Add(labelStudentAccount);
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelUsername.Location = new System.Drawing.Point(255, 115);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new System.Drawing.Size(77, 16);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username :";
            components.Add(labelUsername);
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPassword.Location = new System.Drawing.Point(258, 150);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new System.Drawing.Size(74, 16);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password :";
            components.Add(labelPassword);
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelConfirmPassword.Location = new System.Drawing.Point(210, 185);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new System.Drawing.Size(122, 16);
            labelConfirmPassword.TabIndex = 3;
            labelConfirmPassword.Text = "Confirm Password :";
            components.Add(labelConfirmPassword);
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxUsername.Location = new System.Drawing.Point(355, 112);
            textBoxUsername.MaxLength = 50;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new System.Drawing.Size(150, 22);
            textBoxUsername.TabIndex = 4;
            textBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(textBoxUsername_Validating);
            textBoxUsername.Text = getDefaultUsername();
            if (!Program.getDatabaseUtils().isUsernameUnique(textBoxUsername.Text)) {
                err.SetError(textBoxUsername, "This Username has been taken. Please try another.");
            }
            components.Add(textBoxUsername);
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxPassword.Location = new System.Drawing.Point(355, 147);
            textBoxPassword.MaxLength = 50;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new System.Drawing.Size(150, 22);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(textBoxPassword_Validating);
            components.Add(textBoxPassword);
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxConfirmPassword.Location = new System.Drawing.Point(355, 182);
            textBoxConfirmPassword.MaxLength = 50;
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new System.Drawing.Size(150, 22);
            textBoxConfirmPassword.TabIndex = 6;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            textBoxConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(textBoxConfirmPassword_Validating);
            components.Add(textBoxConfirmPassword);
            // 
            // buttonConfirm
            // 
            buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonConfirm.Location = new System.Drawing.Point(300, 240);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new System.Drawing.Size(94, 30);
            buttonConfirm.TabIndex = 7;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += new System.EventHandler(buttonConfirm_Click);
            components.Add(buttonConfirm);
            // 
            // buttonBack
            // 
            buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBack.Location = new System.Drawing.Point(430, 240);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new System.Drawing.Size(94, 30);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += new System.EventHandler(buttonBack_Click);
            components.Add(buttonBack);

            initialized = true;
        }

        public static void showAllComponents() {
            if (initialized == false) {
                initComponents();
                foreach (var component in components) {
                    Program.getStaffForm().Controls.Add(component);
                }
                return;
            }
            foreach (var component in components) {
                component.Show();
            }
        }

        public static void hideAllComponents() {
            foreach (var component in components) {
                component.Hide();
            }
        }

        public static void disposeAllComponents() {
            foreach (var component in components) {
                component.Dispose();
            }
            components.Clear();
            initialized = false;
        }

        public static void resetAccountInformation() {
            if(initialized == false) {
                return;
            }
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
            err.SetError(textBoxUsername, "");
            err.SetError(textBoxPassword, "");
            err.SetError(textBoxConfirmPassword, "");
        }

        private static void textBoxUsername_Validating(object sender, CancelEventArgs e) {
            if (textBoxUsername.Text == "" || textBoxUsername.Text.Replace(" ", "") == "") {
                err.SetError(textBoxUsername, "Username cannot be empty.");
                return;
            } else {
                err.SetError(textBoxUsername, "");
            }
            if(!Program.getDatabaseUtils().isUsernameUnique(textBoxUsername.Text)) {
                err.SetError(textBoxUsername, "This Username has been taken. Please try another.");
            } else {
                err.SetError(textBoxUsername, "");
            }
        }

        private static void textBoxPassword_Validating(object sender, CancelEventArgs e) {
            if (textBoxPassword.Text == "" || textBoxPassword.Text.Replace(" ", "") == "") {
                err.SetError(textBoxPassword, "Password cannot be empty.");
            } else {
                err.SetError(textBoxPassword, "");
            }
        }

        private static void textBoxConfirmPassword_Validating(object sender, CancelEventArgs e) {
            if (textBoxConfirmPassword.Text == "" || textBoxConfirmPassword.Text.Replace(" ", "") == "") {
                err.SetError(textBoxConfirmPassword, "Confirm password cannot be empty.");
                return;
            } else {
                err.SetError(textBoxConfirmPassword, "");
            }
            if (textBoxPassword.Text != textBoxConfirmPassword.Text) {
                err.SetError(textBoxConfirmPassword, "Password is not match.");
            } else {
                err.SetError(textBoxConfirmPassword, "");
            }
        }

        private static void buttonConfirm_Click(object sender, EventArgs e) {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;
            if (username == "" || username.Replace(" ", "") == "") {
                MessageBox.Show("Username cannot be empty.");
                return;
            }
            if (!Program.getDatabaseUtils().isUsernameUnique(username)) {
                MessageBox.Show("This Username has been taken. Please try another.");
                return;
            }
            if (password == "" || password.Replace(" ", "") == "") {
                MessageBox.Show("Password cannot be empty.");
                return;
            }
            if (confirmPassword == "" || confirmPassword.Replace(" ", "") == "") {
                MessageBox.Show("Confirm password cannot be empty.");
                return;
            }
            if (password != confirmPassword) {
                MessageBox.Show("Password is not match.");
                return;
            }
            password = Md5Converter.encrypt(password);
            bool createAccount = Program.getDatabaseUtils().addNewUser(username, password, EnumUser.Student, StudentRegistrationForm.getStudentName(), StudentRegistrationForm.getGender(), StudentRegistrationForm.getDateOfBirth(),
                                                    StudentRegistrationForm.getEmail(), StudentRegistrationForm.getContactNumber(), StudentRegistrationForm.getAddress());
            if(!createAccount) {
                MessageBox.Show("An error occurred! Failed to create account.");
            } else {
                hideAllComponents();
                StudentInformationForm.showAllComponents();
                StudentInformationForm.updateStudentInformation(username);
            }
        }

        private static void buttonBack_Click(object sender, EventArgs e) {
            hideAllComponents();
            StudentRegistrationForm.showAllComponents();
        }

        private static string getDefaultUsername() {
            string username = StudentRegistrationForm.getStudentName();
            username = username.ToLower();
            username = username.Replace(" ", "");
            return username;
        }

        public static List<Control> getFormComponents() {
            return components;
        }
    }
}
