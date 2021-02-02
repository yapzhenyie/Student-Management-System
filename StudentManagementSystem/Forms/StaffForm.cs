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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms {
    public partial class StaffForm : Form {

        private Label currentSelectedLabel = null;

        public StaffForm() {
            InitializeComponent();
            currentSelectedLabel = null;
        }

        public void initProfileName() {
            Staff staff = (Staff) User.getCurrentUser();
            if(staff == null) {
                this.labelName.Text = "Invalid";
                return;
            }
            this.labelName.Text = staff.Name;
        }

        // Registration Label
        private void labelRegistration_Click(object sender, EventArgs e) {
            if (currentSelectedLabel == this.labelRegistration) {
                return;
            }
            this.labelRegistration.Focus();
            restoreAndAddAnimation(this.labelRegistration);
            currentSelectedLabel = this.labelRegistration;
            // Course Enrollment
            CourseEnrollmentForm.hideAllComponents();
            CourseEnrollmentForm.resetCourseEnrollmentInformation();

            // Fee Payment
            FeePaymentForm.hideAllComponents();
            FeePaymentForm.resetFeePaymentInformation();

            StudentRegistrationForm.showAllComponents();
        }

        private void labelRegistration_MouseEnter(object sender, EventArgs e) {
            ButtonAnimation.addBold(this.labelRegistration);
        }

        private void labelRegistration_MouseMove(object sender, MouseEventArgs e) {
            ButtonAnimation.addBold(this.labelRegistration);
        }

        private void labelRegistration_MouseLeave(object sender, EventArgs e) {
            restoreAnimation(this.labelRegistration);
        }

        // Course Enrollment Label
        private void labelCourseEnrollment_Click(object sender, EventArgs e) {
            if (currentSelectedLabel == this.labelCourseEnrollment) {
                return;
            }
            this.labelCourseEnrollment.Focus();
            restoreAndAddAnimation(this.labelCourseEnrollment);
            currentSelectedLabel = this.labelCourseEnrollment;
            // Registration
            StudentRegistrationForm.hideAllComponents();
            StudentAccountForm.hideAllComponents();
            StudentInformationForm.hideAllComponents();
            resetStudentRegistrationTextBoxes();

            // Fee Payment
            FeePaymentForm.hideAllComponents();
            FeePaymentForm.resetFeePaymentInformation();

            CourseEnrollmentForm.updateCoursesTable(false);
            CourseEnrollmentForm.showAllComponents();
            CourseEnrollmentForm.hideSomeComponents();
        }

        private void labelCourseEnrollment_MouseEnter(object sender, EventArgs e) {
            ButtonAnimation.addBold(this.labelCourseEnrollment);
        }

        private void labelCourseEnrollment_MouseMove(object sender, MouseEventArgs e) {
            ButtonAnimation.addBold(this.labelCourseEnrollment);
        }

        private void labelCourseEnrollment_MouseLeave(object sender, EventArgs e) {
            restoreAnimation(this.labelCourseEnrollment);
        }

        // Fee Payment Label
        private void labelFeePayment_Click(object sender, EventArgs e) {
            if (currentSelectedLabel == this.labelFeePayment) {
                return;
            }
            this.labelFeePayment.Focus();
            restoreAndAddAnimation(this.labelFeePayment);
            currentSelectedLabel = this.labelFeePayment;
            // Registration
            StudentRegistrationForm.hideAllComponents();
            StudentAccountForm.hideAllComponents();
            StudentInformationForm.hideAllComponents();
            resetStudentRegistrationTextBoxes();

            // Course Enrollment
            CourseEnrollmentForm.hideAllComponents();
            CourseEnrollmentForm.resetCourseEnrollmentInformation();

            FeePaymentForm.showAllComponents();
            FeePaymentForm.hideSomeComponents();
        }

        private void labelFeePayment_MouseEnter(object sender, EventArgs e) {
            ButtonAnimation.addBold(this.labelFeePayment);
        }

        private void labelFeePayment_MouseMove(object sender, MouseEventArgs e) {
            ButtonAnimation.addBold(this.labelFeePayment);
        }

        private void labelFeePayment_MouseLeave(object sender, EventArgs e) {
            restoreAnimation(this.labelFeePayment);
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
            if (currentSelectedLabel !=  null && currentSelectedLabel != label) {
                ButtonAnimation.restore(currentSelectedLabel);
            }
            ButtonAnimation.addAnimation(label);
        }

        private void restoreAnimation(Label label) {
            if(currentSelectedLabel == null) {
                ButtonAnimation.restore(label);
                return;
            }
            if (currentSelectedLabel != label)
                ButtonAnimation.restore(label);
        }

        private void resetStudentRegistrationTextBoxes() {
            StudentRegistrationForm.resetStudentInformation();
            StudentAccountForm.resetAccountInformation();
        }

        public void setCurrentSelectedLabel(int index) {
            Label newLabel = null;
            switch (index) {
                case 1:
                    newLabel = this.labelRegistration;
                    break;
                case 2:
                    newLabel = this.labelCourseEnrollment;
                    break;
                case 3:
                    newLabel = this.labelFeePayment;
                    break;
            }
            if(newLabel == null) {
                return;
            }
            restoreAndAddAnimation(newLabel);
            currentSelectedLabel = newLabel;
        }

        public void logout() {
            this.panelLogout.Focus();
            // Registration
            StudentRegistrationForm.disposeAllComponents();
            StudentAccountForm.disposeAllComponents();
            StudentInformationForm.disposeAllComponents();
            resetStudentRegistrationTextBoxes();

            // Course Enrollment
            CourseEnrollmentForm.disposeAllComponents();
            CourseEnrollmentForm.resetCourseEnrollmentInformation();
            // Fee Payment
            FeePaymentForm.disposeAllComponents();
            FeePaymentForm.resetFeePaymentInformation();

            Program.getStaffForm().Hide();
            Program.initLoginForm();
            Program.getLoginForm().ShowDialog();
            Program.getStaffForm().Close();
            User.setCurrentUser(null);
        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            if(Receipt.receipt == null) {
                return;
            }
            ReceiptGenerator.printReceipt(Receipt.receipt, e);
        }
    }
}
