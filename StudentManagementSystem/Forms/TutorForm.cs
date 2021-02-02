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

namespace StudentManagementSystem.Forms {
    public partial class TutorForm : Form {

        private Label currentSelectedLabel = null;

        public TutorForm() {
            InitializeComponent();
            currentSelectedLabel = null;
        }

        public void initProfileName() {
            Tutor tutor = (Tutor)User.getCurrentUser();
            if (tutor == null) {
                this.labelName.Text = "Invalid";
                return;
            }
            this.labelName.Text = tutor.Name;
        }

        // Class Schedule Label
        private void labelClassSchedule_Click(object sender, EventArgs e) {
            if (currentSelectedLabel == this.labelClassSchedule) {
                return;
            }
            this.labelClassSchedule.Focus();
            restoreAndAddAnimation(this.labelClassSchedule);
            currentSelectedLabel = this.labelClassSchedule;

            // Student Profile
            TutorStudentProfileForm.hideAllComponents();
            TutorStudentProfileForm.resetStudentProfileInformation();
            TutorViewStudentProfileForm.hideAllComponents();
            TutorViewStudentProfileForm.resetStudentProfileInformation();


            TutorClassScheduleForm.showAllComponents();
            TutorClassScheduleForm.updateTutorInformation();
        }

        private void labelClassSchedule_MouseEnter(object sender, EventArgs e) {
            ButtonAnimation.addBold(this.labelClassSchedule);
        }

        private void labelClassSchedule_MouseMove(object sender, MouseEventArgs e) {
            ButtonAnimation.addBold(this.labelClassSchedule);
        }

        private void labelClassSchedule_MouseLeave(object sender, EventArgs e) {
            restoreAnimation(this.labelClassSchedule);
        }

        // Student Profile Label
        private void labelStudentProfile_Click(object sender, EventArgs e) {
            if (currentSelectedLabel == this.labelStudentProfile) {
                return;
            }
            this.labelStudentProfile.Focus();
            restoreAndAddAnimation(this.labelStudentProfile);
            currentSelectedLabel = this.labelStudentProfile;

            // Class Schedule
            TutorClassScheduleForm.hideAllComponents();
            TutorClassScheduleForm.resetClassScheduleInformation();
            TutorNewClassScheduleForm.hideAllComponents();
            TutorNewClassScheduleForm.resetNewClassScheduleInformation();

            TutorStudentProfileForm.showAllComponents();
            TutorStudentProfileForm.updateTutorInformation();
        }

        private void labelStudentProfile_MouseEnter(object sender, EventArgs e) {
            ButtonAnimation.addBold(this.labelStudentProfile);
        }

        private void labelStudentProfile_MouseMove(object sender, MouseEventArgs e) {
            ButtonAnimation.addBold(this.labelStudentProfile);
        }

        private void labelStudentProfile_MouseLeave(object sender, EventArgs e) {
            restoreAnimation(this.labelStudentProfile);
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
                    newLabel = this.labelClassSchedule;
                    break;
                case 2:
                    newLabel = this.labelStudentProfile;
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
            // Class Schedule
            TutorClassScheduleForm.disposeAllComponents();
            TutorClassScheduleForm.resetClassScheduleInformation();
            TutorNewClassScheduleForm.disposeAllComponents();
            TutorNewClassScheduleForm.resetNewClassScheduleInformation();

            // Student Profile
            TutorStudentProfileForm.disposeAllComponents();
            TutorStudentProfileForm.resetStudentProfileInformation();
            TutorViewStudentProfileForm.disposeAllComponents();

            Program.getTutorForm().Hide();
            Program.initLoginForm();
            Program.getLoginForm().ShowDialog();
            Program.getTutorForm().Close();
            User.setCurrentUser(null);
        }

        private void TutorForm_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
