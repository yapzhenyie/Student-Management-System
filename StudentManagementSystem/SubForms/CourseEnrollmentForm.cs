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
    class CourseEnrollmentForm {

        private static List<System.Windows.Forms.Control> components = new List<System.Windows.Forms.Control>();

        private static Label labelCourseEnrollmentTitle;
        private static Panel panelTable;
        private static TableLayoutPanel tableLayoutPanel1;
        private static TextBox textBoxSearchBox;
        private static Button buttonSearch;
        private static Label labelStudentName;
        private static Label labelResultStudentName;
        private static Label labelStudentID;
        private static Label labelResultStudentID;
        private static Label labelCourseEnroll;
        private static ListBox listBoxCourseEnroll;
        private static Button buttonContinue;
        private static Button buttonUnenroll;


        private static ListBox listBoxSearchResult = new ListBox();

        private static Dictionary<int, String> searchResults = new Dictionary<int, String>();
        private static List<Course> courseEnroll = new List<Course>();
        private static Student selectedStudent = null;

        private static bool initialized = false;

        public static void initComponents() {
            if (initialized == true) {
                return;
            }
            labelCourseEnrollmentTitle = new Label();
            panelTable = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxSearchBox = new TextBox();
            buttonSearch = new Button();
            labelStudentName = new Label();
            labelResultStudentName = new Label();
            labelStudentID = new Label();
            labelResultStudentID = new Label();
            labelCourseEnroll = new Label();
            listBoxCourseEnroll = new ListBox();
            buttonContinue = new Button();
            buttonUnenroll = new Button();
            listBoxSearchResult = new ListBox();

            panelTable.SuspendLayout();
            // 
            // labelCourseEnrollmentTitle
            // 
            labelCourseEnrollmentTitle.AutoSize = true;
            labelCourseEnrollmentTitle.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCourseEnrollmentTitle.Location = new System.Drawing.Point(196, 58);
            labelCourseEnrollmentTitle.Name = "labelCourseEnrollmentTitle";
            labelCourseEnrollmentTitle.Size = new System.Drawing.Size(262, 37);
            labelCourseEnrollmentTitle.TabIndex = 0;
            labelCourseEnrollmentTitle.Text = "Course Enrollment";
            components.Add(labelCourseEnrollmentTitle);
            // 
            // panelTable
            // 
            panelTable.Controls.Add(tableLayoutPanel1);
            panelTable.Location = new System.Drawing.Point(195, 120);
            panelTable.Name = "panelTable";
            panelTable.Size = new System.Drawing.Size(460, 320);
            panelTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelTable.TabIndex = 1;
            components.Add(panelTable);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(460, 320);
            tableLayoutPanel1.TabIndex = 2;
            updateCoursesTable(true);
            // 
            // textBoxSearchBox
            // 
            textBoxSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxSearchBox.Location = new System.Drawing.Point(660, 85);
            textBoxSearchBox.Name = "textBoxSearchBox";
            textBoxSearchBox.Size = new System.Drawing.Size(139, 22);
            textBoxSearchBox.TabIndex = 3;
            textBoxSearchBox.Text = "Student ID";
            textBoxSearchBox.ForeColor = System.Drawing.Color.Gray;
            textBoxSearchBox.Enter += new System.EventHandler(textBoxSearchBox_Enter);
            textBoxSearchBox.Leave += new System.EventHandler(textBoxSearchBox_Leave);
            textBoxSearchBox.TextChanged += new System.EventHandler(textBoxSearchBox_TextChanged);
            components.Add(textBoxSearchBox);
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSearch.Location = new System.Drawing.Point(797, 84);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(75, 24);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += new System.EventHandler(buttonSearch_Click);
            components.Add(buttonSearch);
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentName.Location = new System.Drawing.Point(665, 130);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new System.Drawing.Size(99, 16);
            labelStudentName.TabIndex = 5;
            labelStudentName.Text = "Student Name :";
            labelStudentName.Hide();
            components.Add(labelStudentName);
            // 
            // labelResultStudentName
            // 
            labelResultStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultStudentName.Location = new System.Drawing.Point(770, 130);
            labelResultStudentName.Name = "labelResultStudentName";
            labelResultStudentName.Size = new System.Drawing.Size(110, 16);
            labelResultStudentName.TabIndex = 6;
            labelResultStudentName.Text = "";
            labelResultStudentName.Hide();
            components.Add(labelResultStudentName);
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentID.Location = new System.Drawing.Point(689, 165);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new System.Drawing.Size(99, 16);
            labelStudentID.TabIndex = 5;
            labelStudentID.Text = "Student ID :";
            labelStudentID.Hide();
            components.Add(labelStudentID);
            // 
            // labelResultStudentID
            // 
            labelResultStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultStudentID.Location = new System.Drawing.Point(770, 165);
            labelResultStudentID.Name = "labelResultStudentID";
            labelResultStudentID.Size = new System.Drawing.Size(110, 16);
            labelResultStudentID.TabIndex = 6;
            labelResultStudentID.Text = "";
            labelResultStudentID.Hide();
            components.Add(labelResultStudentID);
            // 
            // labelCourseEnroll
            // 
            labelCourseEnroll.AutoSize = true;
            labelCourseEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCourseEnroll.Location = new System.Drawing.Point(670, 200);
            labelCourseEnroll.Name = "labelCourseEnroll";
            labelCourseEnroll.Size = new System.Drawing.Size(94, 16);
            labelCourseEnroll.TabIndex = 7;
            labelCourseEnroll.Text = "Course Enroll :";
            labelCourseEnroll.Hide();
            components.Add(labelCourseEnroll);
            // 
            // listBoxCourseEnroll
            // 
            listBoxCourseEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listBoxCourseEnroll.FormattingEnabled = true;
            listBoxCourseEnroll.ItemHeight = 16;
            listBoxCourseEnroll.Location = new System.Drawing.Point(693, 220);
            listBoxCourseEnroll.Name = "listBoxCourseEnroll";
            listBoxCourseEnroll.Size = new System.Drawing.Size(150, 84);
            listBoxCourseEnroll.TabIndex = 8;
            listBoxCourseEnroll.Hide();
            components.Add(listBoxCourseEnroll);
            // 
            // buttonContinue
            // 
            buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonContinue.Location = new System.Drawing.Point(672, 340);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new System.Drawing.Size(75, 30);
            buttonContinue.TabIndex = 9;
            buttonContinue.Text = "Continue";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += new System.EventHandler(buttonContinue_Click);
            buttonContinue.Hide();
            components.Add(buttonContinue);
            // 
            // buttonUnenroll
            // 
            buttonUnenroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonUnenroll.Location = new System.Drawing.Point(772, 340);
            buttonUnenroll.Name = "buttonUnenroll";
            buttonUnenroll.Size = new System.Drawing.Size(75, 30);
            buttonUnenroll.TabIndex = 10;
            buttonUnenroll.Text = "Unenroll";
            buttonUnenroll.UseVisualStyleBackColor = true;
            buttonUnenroll.Click += new System.EventHandler(buttonUnenroll_Click);
            buttonUnenroll.Hide();
            components.Add(buttonUnenroll);
            // 
            // listBoxSearchResult
            // 
            listBoxSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listBoxSearchResult.FormattingEnabled = true;
            listBoxSearchResult.ItemHeight = 16;
            listBoxSearchResult.Location = new System.Drawing.Point(660, 106);
            listBoxSearchResult.Name = "listBoxSearchResult";
            listBoxSearchResult.Size = new System.Drawing.Size(139, 85);
            listBoxSearchResult.SelectedIndexChanged += new System.EventHandler(listBoxSearchResult_SelectedIndexChanged);
            listBoxSearchResult.TabIndex = 11;
            listBoxSearchResult.Hide();
            components.Add(listBoxSearchResult);

            panelTable.ResumeLayout(false);
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
                if (component == listBoxSearchResult) {
                    continue;
                }
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

        public static void resetCourseEnrollmentInformation() {
            if (initialized == true) {
                textBoxSearchBox.Text = "Student ID";
                textBoxSearchBox.ForeColor = System.Drawing.Color.Gray;
                labelResultStudentName.Text = "";
                labelResultStudentID.Text = "";
                resetCoursesTable();
                labelStudentName.Hide();
                labelResultStudentName.Hide();
                labelStudentID.Hide();
                labelResultStudentID.Hide();
                labelCourseEnroll.Hide();
                listBoxCourseEnroll.Items.Clear();
                listBoxCourseEnroll.Hide();
                buttonContinue.Hide();
                buttonUnenroll.Hide();
                listBoxSearchResult.Items.Clear();
                listBoxSearchResult.Hide();
            }

            searchResults.Clear();
            courseEnroll.Clear();
            selectedStudent = null;
        }

        public static void hideSomeComponents() {
            labelStudentName.Hide();
            labelResultStudentName.Hide();
            labelStudentID.Hide();
            labelResultStudentID.Hide();
            labelCourseEnroll.Hide();
            listBoxCourseEnroll.Hide();
            buttonContinue.Hide();
            buttonUnenroll.Hide();
            listBoxSearchResult.Hide();
        }

        public static void resetCoursesTable() {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        }

        public static void updateCoursesTable(bool forceUpdate) {
            if(!forceUpdate && initialized == false) {
                return;
            }
            tableLayoutPanel1.Hide();
            resetCoursesTable();
            tableLayoutPanel1.Controls.Add(newLabel("Course", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 0, 0);
            tableLayoutPanel1.Controls.Add(newLabel("Tutor Name", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 1, 0);
            tableLayoutPanel1.Controls.Add(newLabel("Fees", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 2, 0);
            tableLayoutPanel1.Controls.Add(newLabel("Enrollable", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 3, 0);
            Course.loadCourses();
            int rows = Course.courses().Count;
            tableLayoutPanel1.RowCount = rows + 2;
            int i = 1;
            foreach (var course in Course.courses()) {
                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tableLayoutPanel1.Controls.Add(newLabel(course.getCourseName(), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleLeft), 0, i);
                string tutorName = course.getTutorName();
                if (tutorName == null) {
                    tutorName = "Invalid";
                }
                tableLayoutPanel1.Controls.Add(newLabel(tutorName, System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 1, i);
                tableLayoutPanel1.Controls.Add(newLabel(course.getFee().ToString(), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 2, i);
                if (course.isEnrollable()) {
                    tableLayoutPanel1.Controls.Add(newLinkLabel(course.getEnrollableStatus(), course.getCourseId()), 3, i);
                } else {
                    tableLayoutPanel1.Controls.Add(new Label() { Text = course.getEnrollableStatus(), Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), ForeColor = System.Drawing.Color.Red, TextAlign = ContentAlignment.MiddleCenter, Dock = System.Windows.Forms.DockStyle.Fill }, 3, i);
                }
                i++;
            }
            tableLayoutPanel1.Show();
        }

        private static void textBoxSearchBox_Enter(object sender, EventArgs e) {
            if (textBoxSearchBox.Text == "Student ID") {
                textBoxSearchBox.Text = "";
                textBoxSearchBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private static void textBoxSearchBox_Leave(object sender, EventArgs e) {
            if (textBoxSearchBox.Text == "") {
                textBoxSearchBox.Text = "Student ID";
                textBoxSearchBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private static void textBoxSearchBox_TextChanged(object sender, EventArgs e) {
            lookForResult(false);
        }

        private static void buttonSearch_Click(object sender, EventArgs e) {
            lookForResult(true);
            if(searchResults.Count == 1) {
                updateStudentInformation(0);
            }
        }

        private static void listBoxSearchResult_SelectedIndexChanged(object sender, EventArgs e) {
            int index = listBoxSearchResult.SelectedIndex;
            if (index == -1) {
                listBoxSearchResult.Hide();
                return;
            }
            if (listBoxSearchResult.Text == "No Result Found!") {
                return;
            }
            if (searchResults.Count == 0) {
                MessageBox.Show("An error occurred while doing this process.");
                return;
            }
            updateStudentInformation(index);
        }

        private static void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (selectedStudent == null) {
                MessageBox.Show("No student is selected!");
                return;
            }
            if (listBoxCourseEnroll.Items.Count < 4) {
                Course course = Course.getCourseById((int) e.Link.LinkData);
                if(course == null) {
                    MessageBox.Show("Failed to enroll this course!");
                    return;
                }
                if(courseEnroll.Contains(course)) {
                    MessageBox.Show("You cannot enroll the same course twice!");
                    return;
                }
                listBoxCourseEnroll.Items.Add(course.getCourseName());
                courseEnroll.Add(course);
           } else {
                MessageBox.Show("Student can only enroll up to 4 courses only!");
           }
        }

        private static void buttonContinue_Click(object sender, EventArgs e) {
            if(selectedStudent == null) {
                MessageBox.Show("No student is selected!");
                return;
            }
            if(courseEnroll.Count == 0) {
                MessageBox.Show("Student must enroll at least one course before proceed to next step!");
                return;
            }
            if (courseEnroll.Count > 4) {
                MessageBox.Show("Student can only enroll up to 4 courses!");
                return;
            }
            selectedStudent.getCacheUnenrollCourses().Clear();
            selectedStudent.getCacheEnrollCourses().Clear();
            List<Course> cacheCoursesEnroll = new List<Course>(courseEnroll);
            List<Course> enrolledCourses = new List<Course>(selectedStudent.getEnrolledCourses());
            if (enrolledCourses != null && enrolledCourses.Count != 0) {
                foreach (Course course in selectedStudent.getEnrolledCourses()) {
                    if (cacheCoursesEnroll.Contains(course))
                        enrolledCourses.Remove(course);
                    cacheCoursesEnroll.Remove(course);
                }
            }
            selectedStudent.getCacheUnenrollCourses().AddRange(enrolledCourses);
            selectedStudent.getCacheEnrollCourses().AddRange(cacheCoursesEnroll);

            Program.getStaffForm().setCurrentSelectedLabel(3);
            hideAllComponents();
            FeePaymentForm.showAllComponents();
            FeePaymentForm.hideSomeComponents();
            FeePaymentForm.setSelectedStudent(selectedStudent);
        }

        private static void buttonUnenroll_Click(object sender, EventArgs e) {
            if (selectedStudent == null) {
                MessageBox.Show("No student is selected!");
                return;
            }
            if (courseEnroll.Count == 0) {
                MessageBox.Show("Student do not enroll in any course!");
                return;
            }
            int index = listBoxCourseEnroll.SelectedIndex;
            if (index == -1) {
                MessageBox.Show("You must select a course to unenroll!");
                return;
            }
            Course unenrollCourse = courseEnroll.ElementAt(index);
            courseEnroll.Remove(unenrollCourse);
            listBoxCourseEnroll.Items.Remove(unenrollCourse.getCourseName());
        }

        private static void lookForResult(bool showsError) {
            string studentID = textBoxSearchBox.Text;
            if (studentID == "" || studentID.Replace(" ", "") == "" || studentID == "Student ID") {
                if(showsError)
                    MessageBox.Show("You must enter a student's ID before doing the searching!");
                listBoxSearchResult.Hide();
                return;
            }
            int studentIDResult;
            if (!int.TryParse(studentID, out studentIDResult)) {
                if (showsError) {
                    MessageBox.Show("This is not a valid student ID!");
                } else {
                    listBoxSearchResult.Show();
                    listBoxSearchResult.BringToFront();
                    listBoxSearchResult.Items.Clear();
                    listBoxSearchResult.Items.Add("No Result Found!");
                }
                return;
            }
            Dictionary<int, String> studentList = Program.getDatabaseUtils().getSimilarStudentName(studentIDResult);
            if (studentList == null || studentList.Count == 0) {
                if (showsError) {
                    MessageBox.Show("Student Not Found!");
                } else {
                    listBoxSearchResult.Show();
                    listBoxSearchResult.BringToFront();
                    listBoxSearchResult.Items.Clear();
                    listBoxSearchResult.Items.Add("No Result Found!");
                }
                return;
            }
            searchResults = studentList;
            listBoxSearchResult.Show();
            listBoxSearchResult.BringToFront();
            listBoxSearchResult.Items.Clear();
            foreach(KeyValuePair<int, String> result in studentList) {
                int studentId = Program.getDatabaseUtils().getUniqueIdByUserId("Student", "StudentID", result.Key);
                listBoxSearchResult.Items.Add(studentId + " - " + result.Value);
            }
        }

        private static void updateStudentInformation(int index) {
            Student student = Program.getDatabaseUtils().getStudentInformation(searchResults.ElementAt(index).Key);
            if (student == null) {
                MessageBox.Show("An error occurred while doing this process.");
                return;
            }

            textBoxSearchBox.Text = "Student ID";
            textBoxSearchBox.ForeColor = System.Drawing.Color.Gray;
            setSelectedStudent(student);
        }

        public static void setSelectedStudent(Student student) {
            if (student == null) {
                return;
            }
            selectedStudent = student;
            listBoxSearchResult.Hide();

            labelStudentName.Show();
            labelResultStudentName.Show();
            labelStudentID.Show();
            labelResultStudentID.Show();
            labelCourseEnroll.Show();
            listBoxCourseEnroll.Show();
            buttonContinue.Show();
            buttonUnenroll.Show();

            searchResults.Clear();
            courseEnroll.Clear();

            labelResultStudentName.Text = student.Name;
            labelResultStudentID.Text = student.StudentID.ToString();
            listBoxCourseEnroll.Items.Clear();
            List<Course> studentEnrolledCourses = student.getEnrolledCourses();
            if (studentEnrolledCourses != null && studentEnrolledCourses.Count != 0) {
                foreach (Course course in studentEnrolledCourses) {
                    listBoxCourseEnroll.Items.Add(course.getCourseName());
                    courseEnroll.Add(course);
                }
            }
        }

        private static Label newLinkLabel(string text, int courseId) {
            LinkLabel label = new LinkLabel();
            label.TabStop = true;
            label.Text = text;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel_LinkClicked);
            label.Links.Add(0, 6, courseId);
            return label;
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
