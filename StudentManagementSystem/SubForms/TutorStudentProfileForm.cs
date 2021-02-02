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

    class TutorStudentProfileForm {

        private static List<System.Windows.Forms.Control> components = new List<System.Windows.Forms.Control>();

        private static Label labelStudentProfileTitle;
        private static Label labelCourse;
        private static ComboBox comboBoxCourse;
        private static Panel panelStudents;
        private static TableLayoutPanel tableLayoutPanelStudents;


        private static Tutor selectedTutor = null;
        private static Course selectedCourse = null;

        private static bool initialized = false;

        public static void initComponents() {
            if (initialized == true) {
                return;
            }
            labelStudentProfileTitle = new Label();
            labelCourse = new Label();
            comboBoxCourse = new ComboBox();
            panelStudents = new Panel();
            tableLayoutPanelStudents = new TableLayoutPanel();

            panelStudents.SuspendLayout();
            // 
            // labelStudentProfileTitle
            // 
            labelStudentProfileTitle.AutoSize = true;
            labelStudentProfileTitle.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentProfileTitle.Location = new System.Drawing.Point(187, 58);
            labelStudentProfileTitle.Name = "labelStudentProfileTitle";
            labelStudentProfileTitle.Size = new System.Drawing.Size(218, 37);
            labelStudentProfileTitle.TabIndex = 0;
            labelStudentProfileTitle.Text = "Student Profile";
            components.Add(labelStudentProfileTitle);
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCourse.Location = new System.Drawing.Point(230, 120);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new System.Drawing.Size(57, 16);
            labelCourse.TabIndex = 1;
            labelCourse.Text = "Course :";
            components.Add(labelCourse);
            // 
            // comboBoxCourse
            // 
            comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBoxCourse.FormattingEnabled = true;
            comboBoxCourse.Location = new System.Drawing.Point(300, 117);
            comboBoxCourse.Name = "comboBoxCourse";
            comboBoxCourse.Size = new System.Drawing.Size(145, 24);
            comboBoxCourse.TabIndex = 2;
            comboBoxCourse.SelectedIndexChanged += new System.EventHandler(comboBoxCourse_SelectedIndexChanged);
            components.Add(comboBoxCourse);
            // 
            // panelStudents
            // 
            panelStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelStudents.Controls.Add(tableLayoutPanelStudents);
            panelStudents.Location = new System.Drawing.Point(230, 150);
            panelStudents.Name = "panelStudents";
            panelStudents.Size = new System.Drawing.Size(600, 360);
            panelStudents.TabIndex = 3;
            components.Add(panelStudents);
            // 
            // tableLayoutPanelStudents
            // 
            tableLayoutPanelStudents.AutoScroll = true;
            tableLayoutPanelStudents.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanelStudents.ColumnCount = 4;
            tableLayoutPanelStudents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanelStudents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            tableLayoutPanelStudents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            tableLayoutPanelStudents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanelStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelStudents.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelStudents.Name = "tableLayoutPanelStudents";
            tableLayoutPanelStudents.RowCount = 3;
            tableLayoutPanelStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanelStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelStudents.Size = new System.Drawing.Size(600, 360);
            tableLayoutPanelStudents.TabIndex = 4;
            tableLayoutPanelStudents.Controls.Add(newLabel("No", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 0, 0);
            tableLayoutPanelStudents.Controls.Add(newLabel("Student Name", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 1, 0);
            tableLayoutPanelStudents.Controls.Add(newLabel("Enroll Date", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 2, 0);
            tableLayoutPanelStudents.Controls.Add(newLabel("Profile", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 3, 0);
            updateStudentProfileTable(true);

            panelStudents.ResumeLayout(false);

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

        public static void resetStudentProfileInformation() {
            if (initialized == true) {
                clearStudentProfileTable();
                comboBoxCourse.Items.Clear();
            }
            selectedTutor = null;
            selectedCourse = null;
        }

        private static void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboBoxCourse.SelectedItem == null) {
                return;
            }
            selectedCourse = Course.getCourseByName(comboBoxCourse.SelectedItem.ToString());
            if (selectedCourse == null) {
                return;
            }
            updateStudentProfileTable(false);
        }

        public static void updateStudentProfileTable(bool forceUpdate) {
            if (!forceUpdate && initialized == false) {
                return;
            }
            if (selectedTutor == null || selectedCourse == null) {
                return;
            }
            tableLayoutPanelStudents.Hide();
            clearStudentProfileTable();
            List<Profile> profiles = selectedTutor.getStudentProfile(selectedCourse.getCourseId());
            if (profiles == null || profiles.Count == 0) {
                tableLayoutPanelStudents.Show();
                return;
            }
            profiles.Sort((x, y) => string.Compare(x.getStudentName(), y.getStudentName()));
            int rows = profiles.Count;
            tableLayoutPanelStudents.RowCount = rows + 2;
            int i = 1;
            Course.loadCourses();
            foreach (Profile profile in profiles) {
                tableLayoutPanelStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tableLayoutPanelStudents.Controls.Add(newLabel(i.ToString() + ".", System.Drawing.FontStyle.Regular, ContentAlignment.MiddleLeft), 0, i);
                string name = profile.getStudentName();
                if(name == null || name == "") {
                    name = "Invalid Name";
                }
                tableLayoutPanelStudents.Controls.Add(newLabel(name, System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 1, i);
                tableLayoutPanelStudents.Controls.Add(newLabel(profile.getEnrollDate().Date.ToString("dd/MM/yyyy"), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 2, i);
                tableLayoutPanelStudents.Controls.Add(newLinkLabel("View Profile", profile.getStudentId()), 3, i);
                i++;
            }
            tableLayoutPanelStudents.Show();
        }

        public static void clearStudentProfileTable() {
            if(tableLayoutPanelStudents == null) {
                return;
            }
            tableLayoutPanelStudents.Controls.Clear();
            tableLayoutPanelStudents.RowStyles.Clear();
            tableLayoutPanelStudents.RowCount = 3;
            tableLayoutPanelStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanelStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelStudents.Controls.Add(newLabel("No", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 0, 0);
            tableLayoutPanelStudents.Controls.Add(newLabel("Student Name", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 1, 0);
            tableLayoutPanelStudents.Controls.Add(newLabel("Enroll Date", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 2, 0);
            tableLayoutPanelStudents.Controls.Add(newLabel("Profile", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 3, 0);
        }


        public static void updateTutorInformation() {
            Tutor tutor = (Tutor)User.getCurrentUser();
            if (tutor == null) {
                MessageBox.Show("An error occurred while doing this process.");
                return;
            }
            selectedTutor = tutor;
            Course.loadCourses();
            comboBoxCourse.Items.Clear();
            foreach (Course course in Course.courses()) {
                if (course.getTutorId() == tutor.TutorID)
                    comboBoxCourse.Items.Add(course.getCourseName());
            }
            if (comboBoxCourse.Items.Count == 0) {
                return;
            }
            comboBoxCourse.SelectedItem = comboBoxCourse.Items[0];
            selectedCourse = Course.getCourseByName(comboBoxCourse.Items[0].ToString());
            if (selectedCourse == null) {
                return;
            }
            updateStudentProfileTable(false);
        }

        private static Label newLabel(string text, FontStyle style, ContentAlignment textAlign) {
            Label label = new Label();
            label.Text = text;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, style, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.TextAlign = textAlign;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            return label;
        }

        private static Label newLinkLabel(string text, int studentId) {
            LinkLabel label = new LinkLabel();
            label.TabStop = true;
            label.Text = text;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel_LinkClicked);
            label.Links.Add(0, 12, studentId);
            return label;
        }
        private static void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Student student = Program.getDatabaseUtils().getStudentInformation(Program.getDatabaseUtils().getUserIdByUniqueId("Student", "StudentID", (int)e.Link.LinkData));
            if (student == null) {
                MessageBox.Show("Failed to view student profile!");
                return;
            }
            hideAllComponents();
            TutorViewStudentProfileForm.showAllComponents();
            TutorViewStudentProfileForm.updateStudentInformation(student);
        }

        public static List<System.Windows.Forms.Control> getFormComponents() {
            return components;
        }
    }
}
