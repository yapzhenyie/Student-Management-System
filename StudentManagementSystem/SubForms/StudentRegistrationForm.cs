using StudentManagementSystem.Forms;
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
    class StudentRegistrationForm {

        private static List<Control> components = new List<Control>();

        private static Label labelStudentName;
        private static Label labelDateOfBirth;
        private static Label labelEmail;
        private static Label labelContactNumber;
        private static Label labelAddress;
        private static DateTimePicker dateTimePicker1;
        private static TextBox textBoxStudentName;
        private static TextBox textBoxEmail;
        private static TextBox textBoxContactNumber;
        private static TextBox textBoxAddress;
        private static Button buttonNext;
        private static RadioButton radioButtonMale;
        private static RadioButton radioButtonFemale;
        private static Panel panelGender;
        private static Label labelGender;
        private static Label labelStudentRegistration;


        private static ErrorProvider err = Program.getStaffForm().errorProvider1;

        private static bool initialized = false;

        public static void initComponents() {
            if(initialized == true) {
                return;
            }
            labelStudentName = new Label();
            labelDateOfBirth = new Label();
            labelEmail = new Label();
            labelContactNumber = new Label();
            labelAddress = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBoxStudentName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxContactNumber = new TextBox();
            textBoxAddress = new TextBox();
            buttonNext = new Button();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            panelGender = new Panel();
            labelGender = new Label();
            labelStudentRegistration = new Label();

            panelGender.SuspendLayout();
            // 
            // labelStudentRegistration
            // 
            labelStudentRegistration.AutoSize = true;
            labelStudentRegistration.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentRegistration.Location = new System.Drawing.Point(196, 58);
            labelStudentRegistration.Name = "labelStudentRegistration";
            labelStudentRegistration.Size = new System.Drawing.Size(290, 37);
            labelStudentRegistration.TabIndex = 1;
            labelStudentRegistration.Text = "Student Registration";
            components.Add(labelStudentRegistration);
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentName.Location = new System.Drawing.Point(245, 115);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new System.Drawing.Size(99, 16);
            labelStudentName.TabIndex = 2;
            labelStudentName.Text = "Student Name :";
            components.Add(labelStudentName);
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDateOfBirth.Location = new System.Drawing.Point(256, 220);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new System.Drawing.Size(88, 16);
            labelDateOfBirth.TabIndex = 4;
            labelDateOfBirth.Text = "Date Of Birth :";
            components.Add(labelDateOfBirth);
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelEmail.Location = new System.Drawing.Point(296, 150);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(48, 16);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email :";
            components.Add(labelEmail);
            // 
            // labelContactNumber
            // 
            labelContactNumber.AutoSize = true;
            labelContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelContactNumber.Location = new System.Drawing.Point(234, 255);
            labelContactNumber.Name = "labelContactNumber";
            labelContactNumber.Size = new System.Drawing.Size(110, 16);
            labelContactNumber.TabIndex = 6;
            labelContactNumber.Text = "Contact Number :";
            components.Add(labelContactNumber);
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAddress.Location = new System.Drawing.Point(279, 290);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new System.Drawing.Size(65, 16);
            labelAddress.TabIndex = 7;
            labelAddress.Text = "Address :";
            components.Add(labelAddress);
            // 
            // textBoxStudentName
            // 
            textBoxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxStudentName.Location = new System.Drawing.Point(351, 112);
            textBoxStudentName.Name = "textBoxStudentName";
            textBoxStudentName.Size = new System.Drawing.Size(200, 22);
            textBoxStudentName.TabIndex = 8;
            textBoxStudentName.Validating += new System.ComponentModel.CancelEventHandler(textBoxStudentName_Validating);
            components.Add(textBoxStudentName);
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxEmail.Location = new System.Drawing.Point(351, 147);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(200, 22);
            textBoxEmail.TabIndex = 9;
            textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(textBoxEmail_Validating);
            components.Add(textBoxEmail);
            // 
            // panelGender
            // 
            panelGender.Controls.Add(radioButtonMale);
            panelGender.Controls.Add(radioButtonFemale);
            panelGender.Location = new System.Drawing.Point(351, 182);
            panelGender.Name = "panelGender";
            panelGender.Size = new System.Drawing.Size(120, 24);
            panelGender.TabIndex = 10;
            components.Add(panelGender);
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Checked = true;
            radioButtonMale.Location = new System.Drawing.Point(3, 3);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new System.Drawing.Size(48, 17);
            radioButtonMale.TabIndex = 10;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new System.Drawing.Point(57, 3);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            radioButtonFemale.TabIndex = 11;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMM yyyy";
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new System.Drawing.Point(351, 217);
            dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.Size = new System.Drawing.Size(115, 22);
            dateTimePicker1.TabIndex = 12;
            components.Add(dateTimePicker1);
            // 
            // textBoxContactNumber
            // 
            textBoxContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxContactNumber.Location = new System.Drawing.Point(351, 252);
            textBoxContactNumber.Name = "textBoxContactNumber";
            textBoxContactNumber.Size = new System.Drawing.Size(200, 22);
            textBoxContactNumber.TabIndex = 13;
            textBoxContactNumber.Validating += new System.ComponentModel.CancelEventHandler(textBoxContactNumber_Validating);
            components.Add(textBoxContactNumber);
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxAddress.Location = new System.Drawing.Point(351, 287);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new System.Drawing.Size(240, 80);
            textBoxAddress.TabIndex = 14;
            components.Add(textBoxAddress);
            // 
            // buttonNext
            // 
            buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonNext.Location = new System.Drawing.Point(351, 406);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new System.Drawing.Size(95, 30);
            buttonNext.TabIndex = 15;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += new System.EventHandler(buttonNext_Click);
            components.Add(buttonNext);
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelGender.Location = new System.Drawing.Point(285, 185);
            labelGender.Name = "labelGender";
            labelGender.Size = new System.Drawing.Size(59, 16);
            labelGender.TabIndex = 17;
            labelGender.Text = "Gender :";

            panelGender.ResumeLayout(false);
            panelGender.PerformLayout();
            components.Add(labelGender);

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

        public static void resetStudentInformation() {
            if (initialized == true) {
                dateTimePicker1.Value = DateTime.Now.Date;
                textBoxStudentName.Text = "";
                textBoxEmail.Text = "";
                radioButtonMale.Checked = true;
                radioButtonFemale.Checked = false;
                textBoxContactNumber.Text = "";
                textBoxAddress.Text = "";
                err.SetError(textBoxStudentName, "");
                err.SetError(textBoxEmail, "");
                err.SetError(textBoxContactNumber, "");
            }
        }

        private static void textBoxStudentName_Validating(object sender, CancelEventArgs e) {
            if(textBoxStudentName.Text == "" || textBoxStudentName.Text.Replace(" ", "") == "") {
                err.SetError(textBoxStudentName, "Student name cannot be empty.");
            } else {
                err.SetError(textBoxStudentName, "");
            }
        }

        private static void textBoxEmail_Validating(object sender, CancelEventArgs e) {
            string email = textBoxEmail.Text;
            if (email == "" || email.Replace(" ", "") == "") {
                err.SetError(textBoxEmail, "Email cannot be empty.");
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

        private static void textBoxContactNumber_Validating(object sender, CancelEventArgs e) {
            if (textBoxContactNumber.Text == "" || textBoxContactNumber.Text.Replace(" ", "") == "") {
                err.SetError(textBoxContactNumber, "Contact number cannot be empty.");
                return;
            } else {
                err.SetError(textBoxContactNumber, "");
            }
            Regex regex = new Regex(@"^\d{10,11}$");
            Match match = regex.Match(textBoxContactNumber.Text);
            if (match.Success) {
                err.SetError(textBoxContactNumber, "");
            } else {
                if(textBoxContactNumber.Text.Length > 11) {
                    err.SetError(textBoxContactNumber, "The number is too long.");
                    return;
                }
                err.SetError(textBoxContactNumber, "Contact number can only contains number.");
            }
        }

        private static void buttonNext_Click(object sender, EventArgs e) {
            string studentName = textBoxStudentName.Text;
            DateTime dateOfBirth = dateTimePicker1.Value;
            string email = textBoxEmail.Text;
            string contact = textBoxContactNumber.Text;
            if (studentName == "" || dateOfBirth == null || email == "" || contact == "") {
                MessageBox.Show("Please fill in student's information!");
                return;
            }
            hideAllComponents();
            StudentAccountForm.showAllComponents();

        }

        public static string getStudentName() {
            return textBoxStudentName.Text;
        }

        public static EnumGender getGender() {
            return radioButtonMale.Checked ? EnumGender.Male : EnumGender.Female;
        }

        public static DateTime getDateOfBirth() {
            return dateTimePicker1.Value;
        }

        public static string getEmail() {
            return textBoxEmail.Text;
        }

        public static string getContactNumber() {
            return textBoxContactNumber.Text;
        }

        public static string getAddress() {
            return textBoxAddress.Text;
        }

        public static List<Control> getFormComponents() {
            return components;
        }
    }
}
