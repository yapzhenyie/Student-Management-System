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
    class TutorClassScheduleForm {

        private static List<System.Windows.Forms.Control> components = new List<System.Windows.Forms.Control>();

        private static Label labelClassScheduleTitle;
        private static Button buttonNewSchedule;
        private static Panel panelSchedule;
        private static TableLayoutPanel tableLayoutPanelSchedule;


        private static Tutor selectedTutor = null;

        private static bool initialized = false;

        public static void initComponents() {
            if (initialized == true) {
                return;
            }
            labelClassScheduleTitle = new Label();
            buttonNewSchedule = new Button();
            panelSchedule = new Panel();
            tableLayoutPanelSchedule = new TableLayoutPanel();

            panelSchedule.SuspendLayout();
            // 
            // labelClassScheduleTitle
            // 
            labelClassScheduleTitle.AutoSize = true;
            labelClassScheduleTitle.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelClassScheduleTitle.Location = new System.Drawing.Point(187, 58);
            labelClassScheduleTitle.Name = "labelClassScheduleTitle";
            labelClassScheduleTitle.Size = new System.Drawing.Size(208, 37);
            labelClassScheduleTitle.TabIndex = 0;
            labelClassScheduleTitle.Text = "Class Schedule";
            components.Add(labelClassScheduleTitle);
            // 
            // buttonNewSchedule
            // 
            buttonNewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonNewSchedule.Location = new System.Drawing.Point(736, 105);
            buttonNewSchedule.Name = "buttonNewSchedule";
            buttonNewSchedule.Size = new System.Drawing.Size(110, 30);
            buttonNewSchedule.TabIndex = 1;
            buttonNewSchedule.Text = "New Schedule";
            buttonNewSchedule.UseVisualStyleBackColor = true;
            buttonNewSchedule.Click += new System.EventHandler(buttonNewSchedule_Click);
            components.Add(buttonNewSchedule);
            // 
            // panelSchedule
            // 
            panelSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelSchedule.Controls.Add(tableLayoutPanelSchedule);
            panelSchedule.Location = new System.Drawing.Point(215, 200);
            panelSchedule.Name = "panelSchedule";
            panelSchedule.Size = new System.Drawing.Size(630, 300);
            panelSchedule.TabIndex = 2;
            components.Add(panelSchedule);
            // 
            // tableLayoutPanelSchedule
            // 
            tableLayoutPanelSchedule.AutoScroll = true;
            tableLayoutPanelSchedule.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanelSchedule.ColumnCount = 3;
            tableLayoutPanelSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            tableLayoutPanelSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanelSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            tableLayoutPanelSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelSchedule.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelSchedule.Name = "tableLayoutPanelSchedule";
            tableLayoutPanelSchedule.RowCount = 3;
            tableLayoutPanelSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanelSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelSchedule.Size = new System.Drawing.Size(630, 300);
            tableLayoutPanelSchedule.TabIndex = 3;
            tableLayoutPanelSchedule.Controls.Add(newLabel("Course", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 0, 0);
            tableLayoutPanelSchedule.Controls.Add(newLabel("Date", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 1, 0);
            tableLayoutPanelSchedule.Controls.Add(newLabel("Time", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 2, 0);
            updateTimetable(true);

            panelSchedule.ResumeLayout(false);

            initialized = true;
        }

        public static void showAllComponents() {
            if (initialized == false) {
                initComponents();
                foreach (var component in components) {
                    Program.getTutorForm().Controls.Add(component);
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

        public static void resetClassScheduleInformation() {
            if (initialized == true) {
                tableLayoutPanelSchedule.Controls.Clear();
                tableLayoutPanelSchedule.RowStyles.Clear();
                tableLayoutPanelSchedule.RowCount = 3;
                tableLayoutPanelSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
                tableLayoutPanelSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tableLayoutPanelSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tableLayoutPanelSchedule.Controls.Add(newLabel("Course", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 0, 0);
                tableLayoutPanelSchedule.Controls.Add(newLabel("Date", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 1, 0);
                tableLayoutPanelSchedule.Controls.Add(newLabel("Time", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 2, 0);
            }
            selectedTutor = null;
        }

        public static void updateTimetable(bool forceUpdate) {
            if (!forceUpdate && initialized == false) {
                return;
            }
            if (selectedTutor == null) {
                return;
            }
            tableLayoutPanelSchedule.Hide();
            List<Timetable> timetables = selectedTutor.getTimetables();
            if (timetables == null || timetables.Count == 0) {
                tableLayoutPanelSchedule.Show();
                return;
            }
            int rows = timetables.Count;
            tableLayoutPanelSchedule.RowCount = rows + 2;
            int i = 1;
            Course.loadCourses();
            foreach (var timetable in timetables) {
                Course course = Course.getCourseById(timetable.getCourseId());
                if(course == null) {
                    continue;
                }
                tableLayoutPanelSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tableLayoutPanelSchedule.Controls.Add(newLabel(course.getCourseName(), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleLeft), 0, i);
                tableLayoutPanelSchedule.Controls.Add(newLabel(timetable.Date.Date.ToString("dd MMM yyyy"), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 1, i);
                tableLayoutPanelSchedule.Controls.Add(newLabel(timetable.StartTime.ToString("hh:mm tt") + " - " + timetable.EndTime.ToString("hh:mm tt"), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 2, i);
                i++;
            }
            tableLayoutPanelSchedule.Show();
        }

        private static void buttonNewSchedule_Click(object sender, EventArgs e) {
            hideAllComponents();
            resetClassScheduleInformation();
            TutorNewClassScheduleForm.showAllComponents();
            TutorNewClassScheduleForm.updateTutorInformation();
        }

        public static void updateTutorInformation() {
            Tutor tutor = (Tutor) User.getCurrentUser();
            if (tutor == null) {
                MessageBox.Show("An error occurred while doing this process.");
                return;
            }
            selectedTutor = tutor;
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
