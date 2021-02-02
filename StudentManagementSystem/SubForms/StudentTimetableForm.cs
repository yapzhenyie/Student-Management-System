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
    class StudentTimetableForm {

        private static List<System.Windows.Forms.Control> components = new List<System.Windows.Forms.Control>();


        private static Label labelTimetableTitle;
        private static Panel panelTimetable;
        private static TableLayoutPanel tableLayoutPanelTimetable;


        private static Student selectedStudent = null;

        private static bool initialized = false;

        public static void initComponents() {
            if (initialized == true) {
                return;
            }
            labelTimetableTitle = new Label();
            panelTimetable = new Panel();
            tableLayoutPanelTimetable = new TableLayoutPanel();

            panelTimetable.SuspendLayout();
            // 
            // labelTimetableTitle
            // 
            labelTimetableTitle.AutoSize = true;
            labelTimetableTitle.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTimetableTitle.Location = new System.Drawing.Point(187, 58);
            labelTimetableTitle.Name = "labelTimetableTitle";
            labelTimetableTitle.Size = new System.Drawing.Size(149, 37);
            labelTimetableTitle.TabIndex = 0;
            labelTimetableTitle.Text = "Timetable";
            components.Add(labelTimetableTitle);
            // 
            // panelTimetable
            // 
            panelTimetable.Controls.Add(tableLayoutPanelTimetable);
            panelTimetable.Location = new System.Drawing.Point(194, 180);
            panelTimetable.Name = "panelTimetable";
            panelTimetable.Size = new System.Drawing.Size(630, 310);
            panelTimetable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelTimetable.TabIndex = 1;
            components.Add(panelTimetable);
            // 
            // tableLayoutPanelTimetable
            // 
            tableLayoutPanelTimetable.AutoScroll = true;
            tableLayoutPanelTimetable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanelTimetable.ColumnCount = 4;
            tableLayoutPanelTimetable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            tableLayoutPanelTimetable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            tableLayoutPanelTimetable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanelTimetable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            tableLayoutPanelTimetable.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelTimetable.Name = "tableLayoutPanelTimetable";
            tableLayoutPanelTimetable.RowCount = 3;
            tableLayoutPanelTimetable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanelTimetable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelTimetable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelTimetable.Size = new System.Drawing.Size(630, 310);
            tableLayoutPanelTimetable.TabIndex = 1;
            tableLayoutPanelTimetable.Controls.Add(newLabel("Course", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 0, 0);
            tableLayoutPanelTimetable.Controls.Add(newLabel("Tutor Name", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 1, 0);
            tableLayoutPanelTimetable.Controls.Add(newLabel("Date", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 2, 0);
            tableLayoutPanelTimetable.Controls.Add(newLabel("Time", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 3, 0);
            updateTimetable(true);

            panelTimetable.ResumeLayout(false);

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

        public static void resetStudentTimetableInformation() {
            if (initialized == true) {
                tableLayoutPanelTimetable.Controls.Clear();
                tableLayoutPanelTimetable.RowStyles.Clear();
                tableLayoutPanelTimetable.RowCount = 3;
                tableLayoutPanelTimetable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
                tableLayoutPanelTimetable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tableLayoutPanelTimetable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tableLayoutPanelTimetable.Controls.Add(newLabel("Course", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 0, 0);
                tableLayoutPanelTimetable.Controls.Add(newLabel("Tutor Name", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 1, 0);
                tableLayoutPanelTimetable.Controls.Add(newLabel("Date", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 2, 0);
                tableLayoutPanelTimetable.Controls.Add(newLabel("Time", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 3, 0);
            }
            selectedStudent = null;
        }

        public static void updateTimetable(bool forceUpdate) {
            if (!forceUpdate && initialized == false) {
                return;
            }
            if (selectedStudent == null) {
                return;
            }
            List<Timetable> timetables = selectedStudent.getTimetables();
            if (timetables == null || timetables.Count == 0) {
                return;
            }
            int rows = timetables.Count;
            tableLayoutPanelTimetable.RowCount = rows + 2;
            int i = 1;
            Course.loadCourses();
            foreach (var timetable in timetables) {
                Course course = Course.getCourseById(timetable.getCourseId());
                if(course == null) {
                    continue;
                }
                tableLayoutPanelTimetable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tableLayoutPanelTimetable.Controls.Add(newLabel(course.getCourseName(), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleLeft), 0, i);
                string tutorName = course.getTutorName();
                if (tutorName == null) {
                    tutorName = "Invalid";
                }
                tableLayoutPanelTimetable.Controls.Add(newLabel(tutorName, System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 1, i);
                tableLayoutPanelTimetable.Controls.Add(newLabel(timetable.Date.Date.ToString("dd MMM yyyy"), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 2, i);
                tableLayoutPanelTimetable.Controls.Add(newLabel(timetable.StartTime.ToString("hh:mm tt") + " - " + timetable.EndTime.ToString("hh:mm tt"), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 3, i);
                i++;
            }
        }

        public static void updateStudentInformation() {
            Student student = (Student) User.getCurrentUser();
            if (student == null) {
                MessageBox.Show("An error occurred while doing this process.");
                return;
            }
            selectedStudent = student;
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

        public static List<System.Windows.Forms.Control> getFormComponents() {
            return components;
        }
    }
}
