using StudentManagementSystem.Classes;
using StudentManagementSystem.Properties;
using StudentManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.SubForms {

    class StudentViewFeesForm {

        private static List<System.Windows.Forms.Control> components = new List<System.Windows.Forms.Control>();

        private static Label labelFeesTitle;
        private static Label labelResultOutstandingBalance;
        private static Label labelOutstandingBalance;
        private static Panel panelFees;
        private static TableLayoutPanel tableLayoutPanelFees;

        private static Student selectedStudent = null;
        private static float outstandingBalance = 0;

        private static bool initialized = false;

        public static void initComponents() {
            if (initialized == true) {
                return;
            }
            labelFeesTitle = new Label();
            labelResultOutstandingBalance = new Label();
            labelOutstandingBalance = new Label();
            panelFees = new Panel();
            tableLayoutPanelFees = new TableLayoutPanel();

            panelFees.SuspendLayout();

            // 
            // labelFeesTitle
            // 
            labelFeesTitle.AutoSize = true;
            labelFeesTitle.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFeesTitle.Location = new System.Drawing.Point(187, 58);
            labelFeesTitle.Name = "labelFeesTitle";
            labelFeesTitle.Size = new System.Drawing.Size(75, 37);
            labelFeesTitle.TabIndex = 0;
            labelFeesTitle.Text = "Fees";
            components.Add(labelFeesTitle);
            // 
            // labelOutstandingBalance
            // 
            labelOutstandingBalance.AutoSize = true;
            labelOutstandingBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelOutstandingBalance.Location = new System.Drawing.Point(530, 120);
            labelOutstandingBalance.Name = "labelOutstandingBalance";
            labelOutstandingBalance.Size = new System.Drawing.Size(138, 16);
            labelOutstandingBalance.TabIndex = 1;
            labelOutstandingBalance.Text = "Outstanding Balance :";
            components.Add(labelOutstandingBalance);
            // 
            // labelResultOutstandingBalance
            // 
            labelResultOutstandingBalance.AutoSize = true;
            labelResultOutstandingBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultOutstandingBalance.Location = new System.Drawing.Point(720, 120);
            labelResultOutstandingBalance.Name = "labelResultOutstandingBalance";
            labelResultOutstandingBalance.Size = new System.Drawing.Size(56, 16);
            labelResultOutstandingBalance.TabIndex = 2;
            labelResultOutstandingBalance.Text = "RM 0.00";
            components.Add(labelResultOutstandingBalance);
            // 
            // panelFees
            // 
            panelFees.Controls.Add(tableLayoutPanelFees);
            panelFees.Location = new System.Drawing.Point(215, 180);
            panelFees.Name = "panelFees";
            panelFees.Size = new System.Drawing.Size(620, 300);
            panelFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelFees.TabIndex = 3;
            components.Add(panelFees);
            // 
            // tableLayoutPanelFees
            // 
            tableLayoutPanelFees.AutoScroll = true;
            tableLayoutPanelFees.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanelFees.ColumnCount = 5;
            tableLayoutPanelFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanelFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            tableLayoutPanelFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            tableLayoutPanelFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanelFees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanelFees.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelFees.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelFees.Name = "tableLayoutPanelFees";
            tableLayoutPanelFees.RowCount = 3;
            tableLayoutPanelFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanelFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelFees.Size = new System.Drawing.Size(620, 300);
            tableLayoutPanelFees.TabIndex = 4;
            tableLayoutPanelFees.Controls.Add(newLabel("No", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 0, 0);
            tableLayoutPanelFees.Controls.Add(newLabel("Items", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 1, 0);
            tableLayoutPanelFees.Controls.Add(newLabel("Date", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 2, 0);
            tableLayoutPanelFees.Controls.Add(newLabel("Fees", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 3, 0);
            tableLayoutPanelFees.Controls.Add(newLabel("Status", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 4, 0);
            updateTimetable(true);

            panelFees.ResumeLayout(false);
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

        public static void disposeAllComponents() {
            foreach (var component in components) {
                component.Dispose();
            }
            components.Clear();
            initialized = false;
        }

        public static void resetStudentFeesInformation() {
            if (initialized == true) {
                tableLayoutPanelFees.Controls.Clear();
                tableLayoutPanelFees.RowStyles.Clear();
                tableLayoutPanelFees.RowCount = 3;
                tableLayoutPanelFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
                tableLayoutPanelFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tableLayoutPanelFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tableLayoutPanelFees.Controls.Add(newLabel("No", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 0, 0);
                tableLayoutPanelFees.Controls.Add(newLabel("Items", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 1, 0);
                tableLayoutPanelFees.Controls.Add(newLabel("Date", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 2, 0);
                tableLayoutPanelFees.Controls.Add(newLabel("Fees", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 3, 0);
                tableLayoutPanelFees.Controls.Add(newLabel("Status", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 4, 0);
                labelResultOutstandingBalance.Text = "RM 0.00";
            }
            selectedStudent = null;
            outstandingBalance = 0;
        }

        public static void updateTimetable(bool forceUpdate) {
            if (!forceUpdate && initialized == false) {
                return;
            }
            if (selectedStudent == null) {
                return;
            }
            List<Payment> payments = selectedStudent.getPayments();
            if (payments == null || payments.Count == 0) {
                return;
            }
            int rows = payments.Count;
            tableLayoutPanelFees.RowCount = rows + 2;
            int i = 1;
            foreach (Payment payment in payments) {
                Course course = Course.getCourseById(payment.getCourseId());
                if(course == null) {
                    continue;
                }
                tableLayoutPanelFees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tableLayoutPanelFees.Controls.Add(newLabel(i.ToString() + ".", System.Drawing.FontStyle.Regular, ContentAlignment.MiddleLeft), 0, i);
                tableLayoutPanelFees.Controls.Add(newLabel(course.getCourseName(), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleLeft), 1, i);
                tableLayoutPanelFees.Controls.Add(newLabel(payment.getIssueDate().Date.ToString("dd MMM yyyy"), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 2, i);
                tableLayoutPanelFees.Controls.Add(newLabel(payment.getFee().ToString(), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 3, i);
                bool paid = payment.getPaidStatus();
                tableLayoutPanelFees.Controls.Add(newLabel(paid ? "Paid" : "Unpaid", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter, paid ? Color.Green : Color.Red), 4, i);
                if(!paid) {
                    outstandingBalance += payment.getFee();
                }
                i++;
            }
        }

        public static void updateOutstandingBalance() {
            if(labelResultOutstandingBalance == null) {
                return;
            }
            labelResultOutstandingBalance.Text = "RM " + outstandingBalance.ToString("0.00");
        }

        public static void updateStudentInformation() {
            Student student = (Student) User.getCurrentUser();
            if (student == null) {
                MessageBox.Show("An error occurred while doing this process.");
                return;
            }
            selectedStudent = student;
            selectedStudent.checkIfNeedToPayForNextPayment();
            updateTimetable(false);
        }

        private static Label newLabel(string text, FontStyle style, ContentAlignment textAlign) {
            Label label = new Label();
            label.Text = text;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, style, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.TextAlign = textAlign;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            return label;
        }

        private static Label newLabel(string text, FontStyle style, ContentAlignment textAlign, Color color) {
            Label label = new Label();
            label.Text = text;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, style, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.TextAlign = textAlign;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            label.ForeColor = color;
            return label;
        }

        public static List<System.Windows.Forms.Control> getFormComponents() {
            return components;
        }
    }
}
