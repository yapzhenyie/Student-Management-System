using StudentManagementSystem.Classes;
using StudentManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.SubForms {
    class StudentInformationForm {


        private static List<Control> components = new List<Control>();

        private static Label labelStudentInformation;
        private static Label labelUsername;
        private static Label labelStudentName;
        private static Label labelStudentID;
        private static Label labelEmail;
        private static Label labelGender;
        private static Label labelDateOfBirth;
        private static Label labelDateOfRegistration;
        private static Label labelContactNumber;
        private static Label labelAddress;
        private static Label labelResultUsername;
        private static Label labelResultStudentName;
        private static Label labelResultStudentID;
        private static Label labelResultEmail;
        private static Label labelResultGender;
        private static Label labelResultDateOfBirth;
        private static Label labelResultDateOfRegistration;
        private static Label labelResultContactNumber;
        private static Label labelResultAddress;
        private static Button buttonNewRegistration;
        private static Button buttonEnrollCourse;

        private static Student selectedStudent = null;

        private static bool initialized = false;

        public static void initComponents() {
            if (initialized == true) {
                return;
            }
             labelStudentInformation = new Label();
             labelUsername = new Label();
             labelStudentName = new Label();
             labelStudentID = new Label();
             labelEmail = new Label();
             labelGender = new Label();
             labelDateOfBirth = new Label();
             labelDateOfRegistration = new Label();
             labelContactNumber = new Label();
             labelAddress = new Label();
             labelResultUsername = new Label();
             labelResultStudentName = new Label();
             labelResultStudentID = new Label();
             labelResultEmail = new Label();
             labelResultGender = new Label();
             labelResultDateOfBirth = new Label();
             labelResultDateOfRegistration = new Label();
             labelResultContactNumber = new Label();
             labelResultAddress = new Label();
             buttonNewRegistration = new Button();
             buttonEnrollCourse = new Button();
            // 
            // labelStudentInformation
            // 
            labelStudentInformation.AutoSize = true;
            labelStudentInformation.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentInformation.Location = new System.Drawing.Point(196, 58);
            labelStudentInformation.Name = "labelStudentInformation";
            labelStudentInformation.Size = new System.Drawing.Size(289, 37);
            labelStudentInformation.TabIndex = 0;
            labelStudentInformation.Text = "Student Information";
            components.Add(labelStudentInformation);
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelUsername.Location = new System.Drawing.Point(267, 115);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new System.Drawing.Size(77, 16);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username :";
            components.Add(labelUsername);
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentName.Location = new System.Drawing.Point(245, 150);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new System.Drawing.Size(99, 16);
            labelStudentName.TabIndex = 2;
            labelStudentName.Text = "Student Name :";
            components.Add(labelStudentName);
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentID.Location = new System.Drawing.Point(269, 185);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new System.Drawing.Size(99, 16);
            labelStudentID.TabIndex = 3;
            labelStudentID.Text = "Student ID :";
            components.Add(labelStudentID);
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelEmail.Location = new System.Drawing.Point(296, 220);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(48, 16);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email :";
            components.Add(labelEmail);
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelGender.Location = new System.Drawing.Point(285, 255);
            labelGender.Name = "labelGender";
            labelGender.Size = new System.Drawing.Size(59, 16);
            labelGender.TabIndex = 5;
            labelGender.Text = "Gender :";
            components.Add(labelGender);
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDateOfBirth.Location = new System.Drawing.Point(256, 290);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new System.Drawing.Size(88, 16);
            labelDateOfBirth.TabIndex = 6;
            labelDateOfBirth.Text = "Date Of Birth :";
            components.Add(labelDateOfBirth);
            // 
            // labelDateOfRegistration
            // 
            labelDateOfRegistration.AutoSize = true;
            labelDateOfRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDateOfRegistration.Location = new System.Drawing.Point(210, 325);
            labelDateOfRegistration.Name = "labelDateOfRegistration";
            labelDateOfRegistration.Size = new System.Drawing.Size(134, 16);
            labelDateOfRegistration.TabIndex = 7;
            labelDateOfRegistration.Text = "Date Of Registration :";
            components.Add(labelDateOfRegistration);
            // 
            // labelContactNumber
            // 
            labelContactNumber.AutoSize = true;
            labelContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelContactNumber.Location = new System.Drawing.Point(234, 360);
            labelContactNumber.Name = "labelContactNumber";
            labelContactNumber.Size = new System.Drawing.Size(110, 16);
            labelContactNumber.TabIndex = 8;
            labelContactNumber.Text = "Contact Number :";
            components.Add(labelContactNumber);
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAddress.Location = new System.Drawing.Point(279, 395);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new System.Drawing.Size(65, 16);
            labelAddress.TabIndex = 9;
            labelAddress.Text = "Address :";
            components.Add(labelAddress);
            // 
            // labelResultUsername
            // 
            labelResultUsername.AutoSize = true;
            labelResultUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultUsername.Location = new System.Drawing.Point(351, 115);
            labelResultUsername.Name = "labelResultUsername";
            labelResultUsername.Size = new System.Drawing.Size(200, 22);
            labelResultUsername.TabIndex = 10;
            components.Add(labelResultUsername);
            // 
            // labelResultStudentName
            // 
            labelResultStudentName.AutoSize = true;
            labelResultStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultStudentName.Location = new System.Drawing.Point(351, 150);
            labelResultStudentName.Name = "labelResultStudentName";
            labelResultStudentName.Size = new System.Drawing.Size(200, 22);
            labelResultStudentName.TabIndex = 11;
            components.Add(labelResultStudentName);
            // 
            // labelResultStudentID
            // 
            labelResultStudentID.AutoSize = true;
            labelResultStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultStudentID.Location = new System.Drawing.Point(351, 185);
            labelResultStudentID.Name = "labelResultStudentID";
            labelResultStudentID.Size = new System.Drawing.Size(200, 22);
            labelResultStudentID.TabIndex = 12;
            components.Add(labelResultStudentID);
            // 
            // labelResultEmail
            // 
            labelResultEmail.AutoSize = true;
            labelResultEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultEmail.Location = new System.Drawing.Point(351, 220);
            labelResultEmail.Name = "labelResultEmail";
            labelResultEmail.Size = new System.Drawing.Size(200, 22);
            labelResultEmail.TabIndex = 13;
            components.Add(labelResultEmail);
            // 
            // labelResultGender
            // 
            labelResultGender.AutoSize = true;
            labelResultGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultGender.Location = new System.Drawing.Point(351, 255);
            labelResultGender.Name = "labelResultGender";
            labelResultGender.Size = new System.Drawing.Size(56, 22);
            labelResultGender.TabIndex = 14;
            components.Add(labelResultGender);
            // 
            // labelResultDateOfBirth
            // 
            labelResultDateOfBirth.AutoSize = true;
            labelResultDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultDateOfBirth.Location = new System.Drawing.Point(350, 290);
            labelResultDateOfBirth.Name = "labelResultDateOfBirth";
            labelResultDateOfBirth.Size = new System.Drawing.Size(85, 22);
            labelResultDateOfBirth.TabIndex = 15;
            components.Add(labelResultDateOfBirth);
            // 
            // labelResultDateOfRegistration
            // 
            labelResultDateOfRegistration.AutoSize = true;
            labelResultDateOfRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultDateOfRegistration.Location = new System.Drawing.Point(351, 325);
            labelResultDateOfRegistration.Name = "labelResultDateOfRegistration";
            labelResultDateOfRegistration.Size = new System.Drawing.Size(85, 22);
            labelResultDateOfRegistration.TabIndex = 16;
            components.Add(labelResultDateOfRegistration);
            // 
            // labelResultContactNumber
            // 
            labelResultContactNumber.AutoSize = true;
            labelResultContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultContactNumber.Location = new System.Drawing.Point(351, 360);
            labelResultContactNumber.Name = "labelResultContactNumber";
            labelResultContactNumber.Size = new System.Drawing.Size(200, 22);
            labelResultContactNumber.TabIndex = 17;
            components.Add(labelResultContactNumber);
            // 
            // labelResultAddress
            // 
            labelResultAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultAddress.Location = new System.Drawing.Point(351, 395);
            //labelResultAddress.Multiline = true;
            labelResultAddress.Name = "labelResultAddress";
            labelResultAddress.Size = new System.Drawing.Size(240, 80);
            labelResultAddress.TabIndex = 18;
            components.Add(labelResultAddress);
            // 
            // buttonNewRegistration
            // 
            buttonNewRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonNewRegistration.Location = new System.Drawing.Point(340, 500);
            buttonNewRegistration.Name = "buttonNewRegistration";
            buttonNewRegistration.Size = new System.Drawing.Size(135, 30);
            buttonNewRegistration.TabIndex = 19;
            buttonNewRegistration.Text = "New Registration";
            buttonNewRegistration.UseVisualStyleBackColor = true;
            buttonNewRegistration.Click += new System.EventHandler(buttonNewRegistration_Click);
            components.Add(buttonNewRegistration);
            // 
            // buttonEnrollCourse
            // 
            buttonEnrollCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonEnrollCourse.Location = new System.Drawing.Point(550, 500);
            buttonEnrollCourse.Name = "buttonEnrollCourse";
            buttonEnrollCourse.Size = new System.Drawing.Size(110, 30);
            buttonEnrollCourse.TabIndex = 20;
            buttonEnrollCourse.Text = "Enroll Course";
            buttonEnrollCourse.UseVisualStyleBackColor = true;
            buttonEnrollCourse.Click += new System.EventHandler(buttonEnrollCourse_Click);
            components.Add(buttonEnrollCourse);

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
            if (initialized == true) {
                labelResultUsername.Text = "";
                labelResultStudentName.Text = "";
                labelResultStudentID.Text = "";
                labelResultEmail.Text = "";
                labelResultGender.Text = "";
                labelResultDateOfBirth.Text = "";
                labelResultDateOfRegistration.Text = "";
                labelResultContactNumber.Text = "";
                labelResultAddress.Text = "";
            }
            selectedStudent = null;
        }

        public static void updateStudentInformation(string username) {
            Student student = Program.getDatabaseUtils().getStudentInformation(username);
            if(student == null) {
                MessageBox.Show("An error occurred while doing this process");
                return;
            }
            selectedStudent = student;
            labelResultUsername.Text = student.Username;
            labelResultStudentName.Text = student.Name;
            labelResultStudentID.Text = student.StudentID.ToString();
            labelResultEmail.Text = student.Email;
            labelResultGender.Text = Enum.GetName(typeof(EnumGender), student.Gender);
            labelResultDateOfBirth.Text = student.DateOfBirth.ToString("dd/MM/yyyy");
            labelResultDateOfRegistration.Text = student.DateOfRegistration.ToString("dd/MM/yyyy");
            labelResultContactNumber.Text = student.Contact;
            labelResultAddress.Text = student.Address;
        }

        private static void buttonNewRegistration_Click(object sender, EventArgs e) {
            hideAllComponents();
            StudentRegistrationForm.resetStudentInformation();
            StudentAccountForm.resetAccountInformation();
            resetAccountInformation();
            StudentRegistrationForm.showAllComponents();
        }

        private static void buttonEnrollCourse_Click(object sender, EventArgs e) {
            if (selectedStudent == null) {
                MessageBox.Show("An error occurred while doing this process");
                return;
            }
            Program.getStaffForm().setCurrentSelectedLabel(2);
            hideAllComponents();
            CourseEnrollmentForm.updateCoursesTable(false);
            CourseEnrollmentForm.showAllComponents();
            CourseEnrollmentForm.setSelectedStudent(selectedStudent);

            StudentRegistrationForm.resetStudentInformation();
            StudentAccountForm.resetAccountInformation();
            resetAccountInformation();
        }


        public static List<Control> getFormComponents() {
            return components;
        }
    }
}
