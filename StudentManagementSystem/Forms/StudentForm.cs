using StudentManagementSystem.Classes;
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

namespace StudentManagementSystem {

    public partial class StudentForm : Form {

        private Label currentSelectedLabel = null;

        public StudentForm() {
            InitializeComponent();
            currentSelectedLabel = null;
        }

        public void initProfileName() {
            Student student = (Student)User.getCurrentUser();
            if (student == null) {
                this.labelName.Text = "Invalid";
                return;
            }
            this.labelName.Text = student.Name;
        }

        // Profile Label
        private void labelProfile_Click(object sender, EventArgs e) {
            if (currentSelectedLabel == this.labelProfile) {
                return;
            }
            this.labelProfile.Focus();
            restoreAndAddAnimation(this.labelProfile);
            currentSelectedLabel = this.labelProfile;

            // Timetable
            StudentTimetableForm.hideAllComponents();
            StudentTimetableForm.resetStudentTimetableInformation();

            // Fees
            StudentViewFeesForm.hideAllComponents();
            StudentViewFeesForm.resetStudentFeesInformation();

            StudentProfileForm.showAllComponents();
            StudentProfileForm.updateStudentInformation();
        }

        private void labelProfile_MouseEnter(object sender, EventArgs e) {
            ButtonAnimation.addBold(this.labelProfile);
        }

        private void labelProfile_MouseMove(object sender, MouseEventArgs e) {
            ButtonAnimation.addBold(this.labelProfile);
        }

        private void labelProfile_MouseLeave(object sender, EventArgs e) {
            restoreAnimation(this.labelProfile);
        }

        // Timetable Label
        private void labelTimetable_Click(object sender, EventArgs e) {
            if (currentSelectedLabel == this.labelTimetable) {
                return;
            }
            this.labelTimetable.Focus();
            restoreAndAddAnimation(this.labelTimetable);
            currentSelectedLabel = this.labelTimetable;
            // Profile
            StudentProfileForm.hideAllComponents();
            StudentProfileForm.resetProfileInformation();
            StudentEditProfileForm.hideAllComponents();
            StudentEditProfileForm.resetEditProfileInformation();

            // Fees
            StudentViewFeesForm.hideAllComponents();
            StudentViewFeesForm.resetStudentFeesInformation();

            StudentTimetableForm.updateStudentInformation();
            StudentTimetableForm.showAllComponents();
        }

        private void labelTimetable_MouseEnter(object sender, EventArgs e) {
            ButtonAnimation.addBold(this.labelTimetable);
        }

        private void labelTimetable_MouseMove(object sender, MouseEventArgs e) {
            ButtonAnimation.addBold(this.labelTimetable);
        }

        private void labelTimetable_MouseLeave(object sender, EventArgs e) {
            restoreAnimation(this.labelTimetable);
        }
        
        // Fees Label
        private void labelFees_Click(object sender, EventArgs e) {
            if (currentSelectedLabel == this.labelFees) {
                return;
            }
            this.labelFees.Focus();
            restoreAndAddAnimation(this.labelFees);
            currentSelectedLabel = this.labelFees;
            // Profile
            StudentProfileForm.hideAllComponents();
            StudentProfileForm.resetProfileInformation();
            StudentEditProfileForm.hideAllComponents();
            StudentEditProfileForm.resetEditProfileInformation();

            // Timetable
            StudentTimetableForm.hideAllComponents();
            StudentTimetableForm.resetStudentTimetableInformation();

            StudentViewFeesForm.updateStudentInformation();
            StudentViewFeesForm.showAllComponents();
            StudentViewFeesForm.updateOutstandingBalance();
        }

        private void labelFees_MouseEnter(object sender, EventArgs e) {
            ButtonAnimation.addBold(this.labelFees);
        }

        private void labelFees_MouseMove(object sender, MouseEventArgs e) {
            ButtonAnimation.addBold(this.labelFees);
        }

        private void labelFees_MouseLeave(object sender, EventArgs e) {
            restoreAnimation(this.labelFees);
        }

        // Log out
        private void panelLogout_Click(object sender, EventArgs e) {
            logout();
        }

        private void panelLogout_MouseEnter(object sender, EventArgs e) {
            ButtonAnimation.addClickedEffect(this.panelLogout);
        }

        private void panelLogout_MouseLeave(object sender, EventArgs e) {
            ButtonAnimation.removeClickedEffect(this.panelLogout);
        }

        private void panelLogoutLogo_Click(object sender, EventArgs e) {
            logout();
        }

        private void panelLogoutLogo_MouseEnter(object sender, EventArgs e) {
            ButtonAnimation.addClickedEffect(this.panelLogout);
        }

        private void panelLogoutLogo_MouseLeave(object sender, EventArgs e) {
            ButtonAnimation.removeClickedEffect(this.panelLogout);
        }

        private void labelLogout_Click(object sender, EventArgs e) {
            logout();
        }

        private void labelLogout_MouseEnter(object sender, EventArgs e) {
            ButtonAnimation.addClickedEffect(this.panelLogout);
        }

        private void labelLogout_MouseLeave(object sender, EventArgs e) {
            ButtonAnimation.removeClickedEffect(this.panelLogout);
        }

        private void restoreAndAddAnimation(Label label) {
            if (currentSelectedLabel != null && currentSelectedLabel != label) {
                ButtonAnimation.restore(currentSelectedLabel);
            }
            ButtonAnimation.addAnimation(label);
        }

        private void restoreAnimation(Label label) {
            if (currentSelectedLabel == null) {
                ButtonAnimation.restore(label);
                return;
            }
            if (currentSelectedLabel != label)
                ButtonAnimation.restore(label);
        }

        public void setCurrentSelectedLabel(int index) {
            Label newLabel = null;
            switch (index) {
                case 1:
                    newLabel = this.labelProfile;
                    break;
                case 2:
                    newLabel = this.labelTimetable;
                    break;
                case 3:
                    newLabel = this.labelFees;
                    break;
            }
            if (newLabel == null) {
                return;
            }
            restoreAndAddAnimation(newLabel);
            currentSelectedLabel = newLabel;
        }

        public void logout() {
            this.panelLogout.Focus();
            // Profile
            StudentProfileForm.disposeAllComponents();
            StudentEditProfileForm.disposeAllComponents();

            // Timetable
            StudentTimetableForm.disposeAllComponents();
            StudentTimetableForm.resetStudentTimetableInformation();

            // Fees
            StudentViewFeesForm.disposeAllComponents();
            StudentViewFeesForm.resetStudentFeesInformation();

            Program.getStudentForm().Hide();
            Program.initLoginForm();
            Program.getLoginForm().ShowDialog();
            Program.getStudentForm().Close();
            User.setCurrentUser(null);
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void StudentForm_Load(object sender, EventArgs e) {

        }
    }
}
