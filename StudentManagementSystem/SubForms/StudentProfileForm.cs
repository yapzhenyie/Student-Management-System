using StudentManagementSystem.Classes;
using StudentManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.SubForms {
    class StudentProfileForm {


        private static List<Control> components = new List<Control>();

        private static Label labelProfile;
        private static Label labelStudentName;
        private static Label labelStudentID;
        private static Label labelGender;
        private static Label labelDateOfBirth;
        private static Label labelEmail;
        private static Label labelContact;
        private static Label labelAddress;
        private static Label labelDateOfRegistration;
        private static Label labelUsername;
        private static Label labelResultStudentName;
        private static Label labelResultStudentID;
        private static Label labelResultGender;
        private static Label labelResultDateOfBirth;
        private static Label labelResultEmail;
        private static Label labelResultContact;
        private static Label labelResultAddress;
        private static Label labelResultDateOfRegistration;
        private static Label labelResultUsername;
        private static Button buttonEdit;

        private static bool initialized = false;

        public static void initComponents() {
            if (initialized == true) {
                return;
            }
            labelProfile = new Label();
            labelStudentName = new Label();
            labelStudentID = new Label();
            labelGender = new Label();
            labelDateOfBirth = new Label();
            labelEmail = new Label();
            labelContact = new Label();
            labelAddress = new Label();
            labelDateOfRegistration = new Label();
            labelUsername = new Label();
            labelResultStudentName = new Label();
            labelResultStudentID = new Label();
            labelResultGender = new Label();
            labelResultDateOfBirth = new Label();
            labelResultEmail = new Label();
            labelResultContact = new Label();
            labelResultAddress = new Label();
            labelResultDateOfRegistration = new Label();
            labelResultUsername = new Label();
            buttonEdit = new Button();

            // 
            // labelProfile
            // 
            labelProfile.AutoSize = true;
            labelProfile.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelProfile.Location = new System.Drawing.Point(186, 58);
            labelProfile.Name = "labelProfile";
            labelProfile.Size = new System.Drawing.Size(107, 37);
            labelProfile.TabIndex = 0;
            labelProfile.Text = "Profile";
            components.Add(labelProfile);
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentName.Location = new System.Drawing.Point(269, 115);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new System.Drawing.Size(51, 16);
            labelStudentName.TabIndex = 1;
            labelStudentName.Text = "Name :";
            components.Add(labelStudentName);
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentID.Location = new System.Drawing.Point(245, 150);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new System.Drawing.Size(75, 16);
            labelStudentID.TabIndex = 2;
            labelStudentID.Text = "Student ID :";
            components.Add(labelStudentID);
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelGender.Location = new System.Drawing.Point(261, 185);
            labelGender.Name = "labelGender";
            labelGender.Size = new System.Drawing.Size(59, 16);
            labelGender.TabIndex = 3;
            labelGender.Text = "Gender :";
            components.Add(labelGender);
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDateOfBirth.Location = new System.Drawing.Point(232, 220);
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
            labelEmail.Location = new System.Drawing.Point(272, 255);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(48, 16);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email :";
            components.Add(labelEmail);
            // 
            // labelContact
            // 
            labelContact.AutoSize = true;
            labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelContact.Location = new System.Drawing.Point(261, 290);
            labelContact.Name = "labelContact";
            labelContact.Size = new System.Drawing.Size(59, 16);
            labelContact.TabIndex = 6;
            labelContact.Text = "Contact :";
            components.Add(labelContact);
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAddress.Location = new System.Drawing.Point(255, 325);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new System.Drawing.Size(65, 16);
            labelAddress.TabIndex = 7;
            labelAddress.Text = "Address :";
            components.Add(labelAddress);
            // 
            // labelDateOfRegistration
            // 
            labelDateOfRegistration.AutoSize = true;
            labelDateOfRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDateOfRegistration.Location = new System.Drawing.Point(186, 390);
            labelDateOfRegistration.Name = "labelDateOfRegistration";
            labelDateOfRegistration.Size = new System.Drawing.Size(134, 16);
            labelDateOfRegistration.TabIndex = 8;
            labelDateOfRegistration.Text = "Date Of Registration :";
            components.Add(labelDateOfRegistration);
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelUsername.Location = new System.Drawing.Point(595, 115);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new System.Drawing.Size(77, 16);
            labelUsername.TabIndex = 9;
            labelUsername.Text = "Username :";
            components.Add(labelUsername);
            // 
            // labelResultStudentName
            // 
            labelResultStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultStudentName.Location = new System.Drawing.Point(336, 115);
            labelResultStudentName.Name = "labelResultStudentName";
            labelResultStudentName.Size = new System.Drawing.Size(150, 16);
            labelResultStudentName.TabIndex = 10;
            labelResultStudentName.Text = "";
            components.Add(labelResultStudentName);
            // 
            // labelResultStudentID
            // 
            labelResultStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultStudentID.Location = new System.Drawing.Point(336, 150);
            labelResultStudentID.Name = "labelResultStudentID";
            labelResultStudentID.Size = new System.Drawing.Size(150, 16);
            labelResultStudentID.TabIndex = 11;
            labelResultStudentID.Text = "";
            components.Add(labelResultStudentID);
            // 
            // labelResultGender
            // 
            labelResultGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultGender.Location = new System.Drawing.Point(336, 185);
            labelResultGender.Name = "labelResultGender";
            labelResultGender.Size = new System.Drawing.Size(150, 16);
            labelResultGender.TabIndex = 12;
            labelResultGender.Text = "";
            components.Add(labelResultGender);
            // 
            // labelResultDateOfBirth
            // 
            labelResultDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultDateOfBirth.Location = new System.Drawing.Point(336, 220);
            labelResultDateOfBirth.Name = "labelResultDateOfBirth";
            labelResultDateOfBirth.Size = new System.Drawing.Size(150, 16);
            labelResultDateOfBirth.TabIndex = 13;
            labelResultDateOfBirth.Text = "";
            components.Add(labelResultDateOfBirth);
            // 
            // labelResultEmail
            // 
            labelResultEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultEmail.Location = new System.Drawing.Point(336, 255);
            labelResultEmail.Name = "labelResultEmail";
            labelResultEmail.Size = new System.Drawing.Size(200, 16);
            labelResultEmail.TabIndex = 14;
            labelResultEmail.Text = "";
            components.Add(labelResultEmail);
            // 
            // labelResultContact
            // 
            labelResultContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultContact.Location = new System.Drawing.Point(336, 290);
            labelResultContact.Name = "labelResultContact";
            labelResultContact.Size = new System.Drawing.Size(150, 16);
            labelResultContact.TabIndex = 15;
            labelResultContact.Text = "";
            components.Add(labelResultContact);
            // 
            // labelResultAddress
            // 
            labelResultAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultAddress.Location = new System.Drawing.Point(336, 325);
            labelResultAddress.Name = "labelResultAddress";
            labelResultAddress.Size = new System.Drawing.Size(200, 60);
            labelResultAddress.TabIndex = 16;
            labelResultAddress.Text = "";
            components.Add(labelResultAddress);
            // 
            // labelResultDateOfRegistration
            // 
            labelResultDateOfRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultDateOfRegistration.Location = new System.Drawing.Point(336, 390);
            labelResultDateOfRegistration.Name = "labelResultDateOfRegistration";
            labelResultDateOfRegistration.Size = new System.Drawing.Size(150, 16);
            labelResultDateOfRegistration.TabIndex = 17;
            labelResultDateOfRegistration.Text = "";
            components.Add(labelResultDateOfRegistration);
            // 
            // labelResultUsername
            // 
            labelResultUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultUsername.Location = new System.Drawing.Point(690, 115);
            labelResultUsername.Name = "labelResultUsername";
            labelResultUsername.Size = new System.Drawing.Size(150, 16);
            labelResultUsername.TabIndex = 18;
            labelResultUsername.Text = "";
            components.Add(labelResultUsername);
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonEdit.Location = new System.Drawing.Point(785, 70);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new System.Drawing.Size(75, 30);
            buttonEdit.TabIndex = 19;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += new System.EventHandler(buttonEdit_Click);
            components.Add(buttonEdit);

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
            if (initialized == false) {
                return;
            }
            labelResultStudentName.Hide();
            labelResultGender.Hide();
            labelResultDateOfBirth.Hide();
            labelResultEmail.Hide();
            labelResultContact.Hide();
            labelResultAddress.Hide();
            buttonEdit.Hide();
        }

        public static void disposeAllComponents() {
            foreach (var component in components) {
                component.Dispose();
            }
            components.Clear();
            initialized = false;
        }

        public static void resetProfileInformation() {
            if (initialized == true) {
                labelResultStudentName.Text = "";
                labelResultStudentID.Text = "";
                labelResultGender.Text = "";
                labelResultDateOfBirth.Text = "";
                labelResultEmail.Text = "";
                labelResultContact.Text = "";
                labelResultAddress.Text = "";
                labelResultDateOfRegistration.Text = "";
                labelResultUsername.Text = "";
            }
        }

        private static void buttonEdit_Click(object sender, EventArgs e) {
            hideSomeComponents();
            StudentEditProfileForm.showAllComponents();
            StudentEditProfileForm.updateStudentInformation();
        }

        public static void updateStudentInformation() {
            Student student = (Student)User.getCurrentUser();
            if(student == null) {
                return;
            }
            labelResultStudentName.Text = student.Name;
            labelResultStudentID.Text = student.StudentID.ToString();
            labelResultGender.Text = Enum.GetName(typeof(EnumGender), student.Gender);
            labelResultDateOfBirth.Text = student.DateOfBirth.Date.ToString("dd/MM/yyyy");
            labelResultEmail.Text = student.Email;
            labelResultContact.Text = student.Contact;
            labelResultAddress.Text = student.Address;
            labelResultDateOfRegistration.Text = student.DateOfRegistration.Date.ToString("dd/MM/yyyy");
            labelResultUsername.Text = student.Username;
        }

        public static List<Control> getFormComponents() {
            return components;
        }
    }
}
