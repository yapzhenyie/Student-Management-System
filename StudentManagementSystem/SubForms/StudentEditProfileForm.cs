using StudentManagementSystem.Classes;
using StudentManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.SubForms {
    class StudentEditProfileForm {


        private static List<Control> components = new List<Control>();

        private static TextBox textBoxStudentName;
        private static Panel panelGender;
        private static RadioButton radioButtonMale;
        private static RadioButton radioButtonFemale;
        private static DateTimePicker dateTimePicker1;
        private static TextBox textBoxEmail;
        private static TextBox textBoxContact;
        private static TextBox textBoxAddress;
        private static Label labelOldPassword;
        private static Label labelNewPassword;
        private static Label labelConfirmPassword;
        private static TextBox textBoxOldPassword;
        private static TextBox textBoxNewPassword;
        private static TextBox textBoxConfirmPassword;
        private static Button buttonSave;
        private static Button buttonCancel;

        private static ErrorProvider err = Program.getStudentForm().errorProvider1;

        private static bool initialized = false;

        public static void initComponents() {
            if (initialized == true) {
                return;
            }
            textBoxStudentName = new TextBox();
            panelGender = new Panel();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBoxEmail = new TextBox();
            textBoxContact = new TextBox();
            textBoxAddress = new TextBox();
            labelOldPassword = new Label();
            labelNewPassword = new Label();
            labelConfirmPassword = new Label();
            textBoxOldPassword = new TextBox();
            textBoxNewPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();

            panelGender.SuspendLayout();
            // 
            // textBoxStudentName
            // 
            textBoxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxStudentName.Location = new System.Drawing.Point(339, 112);
            textBoxStudentName.Name = "textBoxStudentName";
            textBoxStudentName.Size = new System.Drawing.Size(150, 22);
            textBoxStudentName.TabIndex = 10;
            textBoxStudentName.Validating += new System.ComponentModel.CancelEventHandler(textBoxStudentName_Validating);
            components.Add(textBoxStudentName);
            // 
            // panelGender
            // 
            panelGender.AutoSize = true;
            panelGender.Controls.Add(radioButtonFemale);
            panelGender.Controls.Add(radioButtonMale);
            panelGender.Location = new System.Drawing.Point(339, 182);
            panelGender.Name = "panelGender";
            panelGender.Size = new System.Drawing.Size(148, 24);
            panelGender.TabIndex = 11;
            components.Add(panelGender);
            // 
            // radioButtonMale
            // 
            radioButtonMale.Dock = DockStyle.Left;
            radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radioButtonMale.Location = new System.Drawing.Point(0, 0);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new System.Drawing.Size(63, 24);
            radioButtonMale.TabIndex = 11;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.Dock = DockStyle.Right;
            radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radioButtonFemale.Location = new System.Drawing.Point(63, 0);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new System.Drawing.Size(85, 24);
            radioButtonFemale.TabIndex = 11;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePicker1.CustomFormat = "dd MMM yyyy";
            dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new System.Drawing.Point(339, 217);
            dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(115, 22);
            dateTimePicker1.TabIndex = 12;
            components.Add(dateTimePicker1);
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxEmail.Location = new System.Drawing.Point(339, 252);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(200, 22);
            textBoxEmail.TabIndex = 13;
            textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(textBoxEmail_Validating);
            components.Add(textBoxEmail);
            // 
            // textBoxContact
            // 
            textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxContact.Location = new System.Drawing.Point(339, 287);
            textBoxContact.Name = "textBoxContact";
            textBoxContact.Size = new System.Drawing.Size(150, 22);
            textBoxContact.TabIndex = 14;
            textBoxContact.Validating += new System.ComponentModel.CancelEventHandler(textBoxContact_Validating);
            components.Add(textBoxContact);
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxAddress.Location = new System.Drawing.Point(339, 322);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new System.Drawing.Size(200, 60);
            textBoxAddress.TabIndex = 15;
            components.Add(textBoxAddress);
            // 
            // labelOldPassword
            // 
            labelOldPassword.AutoSize = true;
            labelOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelOldPassword.Location = new System.Drawing.Point(574, 150);
            labelOldPassword.Name = "labelOldPassword";
            labelOldPassword.Size = new System.Drawing.Size(98, 16);
            labelOldPassword.TabIndex = 16;
            labelOldPassword.Text = "Old Password :";
            components.Add(labelOldPassword);
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNewPassword.Location = new System.Drawing.Point(568, 185);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new System.Drawing.Size(104, 16);
            labelNewPassword.TabIndex = 17;
            labelNewPassword.Text = "New Password :";
            components.Add(labelNewPassword);
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelConfirmPassword.Location = new System.Drawing.Point(550, 220);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new System.Drawing.Size(122, 16);
            labelConfirmPassword.TabIndex = 18;
            labelConfirmPassword.Text = "Confirm Password :";
            components.Add(labelConfirmPassword);
            // 
            // textBoxOldPassword
            // 
            textBoxOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxOldPassword.Location = new System.Drawing.Point(690, 147);
            textBoxOldPassword.Name = "textBoxOldPassword";
            textBoxOldPassword.Size = new System.Drawing.Size(150, 22);
            textBoxOldPassword.TabIndex = 19;
            textBoxOldPassword.UseSystemPasswordChar = true;
            components.Add(textBoxOldPassword);
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxNewPassword.Location = new System.Drawing.Point(690, 182);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new System.Drawing.Size(150, 22);
            textBoxNewPassword.TabIndex = 20;
            textBoxNewPassword.UseSystemPasswordChar = true;
            components.Add(textBoxNewPassword);
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxConfirmPassword.Location = new System.Drawing.Point(690, 217);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new System.Drawing.Size(150, 22);
            textBoxConfirmPassword.TabIndex = 21;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            textBoxConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(textBoxConfirmPassword_Validating);
            components.Add(textBoxConfirmPassword);
            // 
            // buttonSave
            // 
            buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSave.Location = new System.Drawing.Point(380, 460);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(75, 30);
            buttonSave.TabIndex = 22;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += new System.EventHandler(buttonSave_Click);
            components.Add(buttonSave);
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonCancel.Location = new System.Drawing.Point(550, 460);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 30);
            buttonCancel.TabIndex = 23;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += new System.EventHandler(buttonCancel_Click);
            components.Add(buttonCancel);

            panelGender.ResumeLayout(false);
            initialized = true;
        }

        public static void showAllComponents() {
            if (initialized == false) {
                initComponents();
                foreach (var component in components) {
                    Program.getStudentForm().Controls.Add(component);
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

        public static void hideSomeComponents() {
            if(initialized == false) {
                return;
            }
            textBoxStudentName.Hide();
            panelGender.Hide();
            dateTimePicker1.Hide();
            textBoxEmail.Hide();
            textBoxContact.Hide();
            textBoxAddress.Hide();
            labelOldPassword.Hide();
            labelNewPassword.Hide();
            labelConfirmPassword.Hide();
            textBoxOldPassword.Hide();
            textBoxNewPassword.Hide();
            textBoxConfirmPassword.Hide();
            buttonSave.Hide();
            buttonCancel.Hide();
        }

        public static void disposeAllComponents() {
            foreach (var component in components) {
                component.Dispose();
            }
            components.Clear();
            initialized = false;
        }

        public static void resetEditProfileInformation() {
            if (initialized == true) {
                textBoxStudentName.Text = "";
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = false;
                dateTimePicker1.Value = DateTime.Now.Date;
                textBoxEmail.Text = "";
                textBoxContact.Text = "";
                textBoxAddress.Text = "";
                textBoxOldPassword.Text = "";
                textBoxNewPassword.Text = "";
                textBoxConfirmPassword.Text = "";
                err.SetError(textBoxStudentName, "");
                err.SetError(textBoxEmail, "");
                err.SetError(textBoxContact, "");
                err.SetError(textBoxOldPassword, "");
                err.SetError(textBoxConfirmPassword, "");
            }
        }

        private static void textBoxStudentName_Validating(object sender, CancelEventArgs e) {
            if (textBoxStudentName.Text == "" || textBoxStudentName.Text.Replace(" ", "") == "") {
                err.SetError(textBoxStudentName, "Student name cannot be empty.");
            } else {
                err.SetError(textBoxStudentName, "");
            }
        }

        private static void textBoxEmail_Validating(object sender, CancelEventArgs e) {
            string email = textBoxEmail.Text;
            if (email == "" || email.Replace(" ", "") == "") {
                return;
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success) {
                err.SetError(textBoxEmail, "");
            } else {
                err.SetError(textBoxEmail, "Invalid email format.");
            }
        }

        private static void textBoxContact_Validating(object sender, CancelEventArgs e) {
            if (textBoxContact.Text == "" || textBoxContact.Text.Replace(" ", "") == "") {
                return;
            }

            Regex regex = new Regex(@"^\d{10,11}$");
            Match match = regex.Match(textBoxContact.Text);
            if (match.Success) {
                err.SetError(textBoxContact, "");
            } else {
                if (textBoxContact.Text.Length > 11) {
                    err.SetError(textBoxContact, "The number is too long.");
                    return;
                }
                err.SetError(textBoxContact, "Contact number can only contains number.");
            }
        }

        private static void textBoxConfirmPassword_Validating(object sender, CancelEventArgs e) {
            if ((textBoxNewPassword.Text == "" || textBoxNewPassword.Text.Replace(" ", "") == "") && 
                (textBoxConfirmPassword.Text == "" || textBoxConfirmPassword.Text.Replace(" ", "") == "")) {
                return;
            }
            if (textBoxOldPassword.Text == "" || textBoxOldPassword.Text.Replace(" ", "") == "") {
                err.SetError(textBoxOldPassword, "Old Password cannot be empty");
            } else {
                err.SetError(textBoxOldPassword, "");
            }
            if (textBoxNewPassword.Text != textBoxConfirmPassword.Text) {
                err.SetError(textBoxConfirmPassword, "New Password is not match.");
            } else {
                err.SetError(textBoxConfirmPassword, "");
            }
        }

        private static void buttonSave_Click(object sender, EventArgs e) {
            Student student = (Student)User.getCurrentUser();
            if(student == null) {
                MessageBox.Show("An error occurred while doing this process.");
                return;
            }
            if (textBoxStudentName.Text == "" || textBoxStudentName.Text.Replace(" ", "") == "") {
                err.SetError(textBoxStudentName, "Student name cannot be empty.");
                return;
            }
            bool changePassword = false;
            if ((textBoxOldPassword.Text != "" || textBoxOldPassword.Text.Replace(" ", "") != "") && 
                (textBoxNewPassword.Text != "" || textBoxNewPassword.Text.Replace(" ", "") != "") &&
               (textBoxConfirmPassword.Text != "" || textBoxConfirmPassword.Text.Replace(" ", "") != "")) {
                if(Md5Converter.encrypt(textBoxOldPassword.Text) != student.Password) {
                    err.SetError(textBoxOldPassword, "Wrong password.");
                    MessageBox.Show("Old password is wrong!");
                    return;
                } else {
                    err.SetError(textBoxOldPassword, "");
                }

                if (textBoxNewPassword.Text != textBoxConfirmPassword.Text) {
                    err.SetError(textBoxConfirmPassword, "New Password is not match.");
                    MessageBox.Show("New Password is not match.!");
                    return;
                } else {
                    err.SetError(textBoxConfirmPassword, "");
                }
                changePassword = true;
            } else if (textBoxOldPassword.Text != "" || textBoxOldPassword.Text.Replace(" ", "") != "" 
                || (textBoxNewPassword.Text != "" || textBoxNewPassword.Text.Replace(" ", "") != "") 
                || textBoxConfirmPassword.Text != "" || textBoxConfirmPassword.Text.Replace(" ", "") != "") {
                MessageBox.Show("You must fill in the passwords to change the new password!");
                return;
            }
            student.Password = Md5Converter.encrypt(textBoxNewPassword.Text);
            student.Name = textBoxStudentName.Text;
            student.Gender = radioButtonMale.Checked ? EnumGender.Male : EnumGender.Female;
            student.DateOfBirth = dateTimePicker1.Value.Date;
            student.Email = textBoxEmail.Text;
            student.Contact = textBoxContact.Text;
            student.Address = textBoxAddress.Text;
            Program.getDatabaseUtils().updateStudentInformation(student, changePassword);
            hideSomeComponents();
            StudentProfileForm.showAllComponents();
            StudentProfileForm.updateStudentInformation();
            Program.getStudentForm().initProfileName();
        }

        private static void buttonCancel_Click(object sender, EventArgs e) {
            hideSomeComponents();
            StudentProfileForm.showAllComponents();
            StudentProfileForm.updateStudentInformation();
        }

        public static void updateStudentInformation() {
            Student student = (Student)User.getCurrentUser();
            if (student == null) {
                return;
            }
            textBoxStudentName.Text = student.Name;
            if(student.Gender == EnumGender.Male) {
                radioButtonMale.Checked = true;
                radioButtonFemale.Checked = false;
            } else {
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = true;
            }
            dateTimePicker1.Value = student.DateOfBirth.Date;
            textBoxEmail.Text = student.Email;
            textBoxContact.Text = student.Contact;
            textBoxAddress.Text = student.Address;
        }

        public static List<Control> getFormComponents() {
            return components;
        }
    }
}
