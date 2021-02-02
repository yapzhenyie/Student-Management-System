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
    class TutorNewClassScheduleForm {

        private static List<System.Windows.Forms.Control> components = new List<System.Windows.Forms.Control>();

        private static Label labelNewClassSchedule;
        private static Label labelCourse;
        private static Label labelClassDate;
        private static Label labelStartTime;
        private static Label labelEndTime;
        private static ComboBox comboBoxCourse;
        private static DateTimePicker dateTimePickerDate;
        private static DateTimePicker dateTimePickerStartTime;
        private static DateTimePicker dateTimePickerEndTime;
        private static Button buttonUpload;
        private static Button buttonCancel;


        private static Tutor selectedTutor = null;
        private static Course selectedCourse = null;

        private static bool initialized = false;

        public static void initComponents() {
            if (initialized == true) {
                return;
            }
            labelNewClassSchedule = new Label();
            labelCourse = new Label();
            labelClassDate = new Label();
            labelStartTime = new Label();
            labelEndTime = new Label();
            comboBoxCourse = new ComboBox();
            dateTimePickerDate = new DateTimePicker();
            dateTimePickerStartTime = new DateTimePicker();
            dateTimePickerEndTime = new DateTimePicker();
            buttonUpload = new Button();
            buttonCancel = new Button();
            // 
            // labelNewClassSchedule
            // 
            labelNewClassSchedule.AutoSize = true;
            labelNewClassSchedule.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNewClassSchedule.Location = new System.Drawing.Point(187, 58);
            labelNewClassSchedule.Name = "labelNewClassSchedule";
            labelNewClassSchedule.Size = new System.Drawing.Size(276, 37);
            labelNewClassSchedule.TabIndex = 0;
            labelNewClassSchedule.Text = "New Class Schedule";
            components.Add(labelNewClassSchedule);
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCourse.Location = new System.Drawing.Point(250, 130);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new System.Drawing.Size(57, 16);
            labelCourse.TabIndex = 1;
            labelCourse.Text = "Course :";
            components.Add(labelCourse);
            // 
            // labelClassDate
            // 
            labelClassDate.AutoSize = true;
            labelClassDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelClassDate.Location = new System.Drawing.Point(227, 170);
            labelClassDate.Name = "labelClassDate";
            labelClassDate.Size = new System.Drawing.Size(80, 16);
            labelClassDate.TabIndex = 2;
            labelClassDate.Text = "Class Date :";
            components.Add(labelClassDate);
            // 
            // labelStartTime
            // 
            labelStartTime.AutoSize = true;
            labelStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStartTime.Location = new System.Drawing.Point(232, 210);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new System.Drawing.Size(75, 16);
            labelStartTime.TabIndex = 3;
            labelStartTime.Text = "Start Time :";
            components.Add(labelStartTime);
            // 
            // labelEndTime
            // 
            labelEndTime.AutoSize = true;
            labelEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelEndTime.Location = new System.Drawing.Point(235, 250);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new System.Drawing.Size(72, 16);
            labelEndTime.TabIndex = 4;
            labelEndTime.Text = "End Time :";
            components.Add(labelEndTime);
            // 
            // comboBoxCourse
            // 
            comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBoxCourse.FormattingEnabled = true;
            comboBoxCourse.Location = new System.Drawing.Point(327, 127);
            comboBoxCourse.Name = "comboBoxCourse";
            comboBoxCourse.Size = new System.Drawing.Size(160, 24);
            comboBoxCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCourse.TabIndex = 5;
            components.Add(comboBoxCourse);
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.CustomFormat = "dd/MM/yyyy";
            dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerDate.Location = new System.Drawing.Point(330, 165);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new System.Drawing.Size(110, 22);
            dateTimePickerDate.TabIndex = 6;
            components.Add(dateTimePickerDate);
            // 
            // dateTimePickerStartTime
            // 
            dateTimePickerStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dateTimePickerStartTime.Location = new System.Drawing.Point(330, 205);
            dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            dateTimePickerStartTime.ShowUpDown = true;
            dateTimePickerStartTime.Size = new System.Drawing.Size(100, 22);
            dateTimePickerStartTime.TabIndex = 7;
            components.Add(dateTimePickerStartTime);
            // 
            // dateTimePickerEndTime
            // 
            dateTimePickerEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dateTimePickerEndTime.Location = new System.Drawing.Point(330, 245);
            dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            dateTimePickerEndTime.ShowUpDown = true;
            dateTimePickerEndTime.Size = new System.Drawing.Size(100, 22);
            dateTimePickerEndTime.TabIndex = 8;
            components.Add(dateTimePickerEndTime);
            // 
            // buttonUpload
            // 
            buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonUpload.Location = new System.Drawing.Point(380, 380);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new System.Drawing.Size(75, 35);
            buttonUpload.TabIndex = 9;
            buttonUpload.Text = "Upload";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += new System.EventHandler(buttonUpload_Click);
            components.Add(buttonUpload);
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonCancel.Location = new System.Drawing.Point(535, 380);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 35);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += new System.EventHandler(buttonCancel_Click);
            components.Add(buttonCancel);

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

        public static void resetNewClassScheduleInformation() {
            if (initialized == true) {
                dateTimePickerDate.Value = DateTime.Now.Date;
                dateTimePickerStartTime.Value = DateTime.Now;
                dateTimePickerEndTime.Value = DateTime.Now;
                comboBoxCourse.Items.Clear();
            }
            selectedTutor = null;
            selectedCourse = null;
        }

        private static void buttonUpload_Click(object sender, EventArgs e) {
            if (comboBoxCourse.SelectedItem == null) {
                MessageBox.Show("You must select a course before doing this!");
                return;
            }
            selectedCourse = Course.getCourseByName(comboBoxCourse.SelectedItem.ToString());
            if(selectedTutor == null || selectedCourse == null) {
                MessageBox.Show("An error occurred while doing this process!");
                goBackToClassScheduleForm();
                return;
            }
            if(dateTimePickerDate.Value.Date < DateTime.Now.Date) {
                MessageBox.Show("You cannot choose a date that has passed!");
                return;
            }
            if(dateTimePickerStartTime.Value == dateTimePickerEndTime.Value) {
                MessageBox.Show("Start time and End time cannot be equal!");
                return;
            }
            if (dateTimePickerStartTime.Value.Hour > dateTimePickerEndTime.Value.Hour) {
                MessageBox.Show("End time must higher than Start time!");
                return;
            }
            Timetable ttable = new Timetable(selectedCourse.getCourseId(), selectedTutor.TutorID, dateTimePickerDate.Value.Date, dateTimePickerStartTime.Value, dateTimePickerEndTime.Value);
            if(Program.getDatabaseUtils().isTimetableExistInDatabase(ttable)) {
                MessageBox.Show("This timetable already exist in the class schedule!");
                return;
            }
            Program.getDatabaseUtils().addTimetable(ttable);
            goBackToClassScheduleForm();
        }

        private static void buttonCancel_Click(object sender, EventArgs e) {
            goBackToClassScheduleForm();
        }

        private static void goBackToClassScheduleForm() {
            hideAllComponents();
            resetNewClassScheduleInformation();
            TutorClassScheduleForm.updateTutorInformation();
            TutorClassScheduleForm.showAllComponents();
        }

        public static void updateTutorInformation() {
            Tutor tutor = (Tutor) User.getCurrentUser();
            if (tutor == null) {
                MessageBox.Show("An error occurred while doing this process.");
                return;
            }
            selectedTutor = tutor;
            Course.loadCourses();
            comboBoxCourse.Items.Clear();
            foreach (Course course in Course.courses()) {
                if(course.getTutorId() == tutor.TutorID)
                    comboBoxCourse.Items.Add(course.getCourseName());
            }
            if(comboBoxCourse.Items.Count == 0) {
                MessageBox.Show("You didn't teach any course!");
                return;
            }
            comboBoxCourse.SelectedItem = comboBoxCourse.Items[0];
            selectedCourse = Course.getCourseByName(comboBoxCourse.Items[0].ToString());
            if (selectedCourse == null) {
                MessageBox.Show("You didn't teach any course!");
                return;
            }
            dateTimePickerDate.Value = DateTime.Now.Date;
            dateTimePickerStartTime.Value = new DateTime(2020, 1, 1, DateTime.Now.Hour, 0, 0);
            try {
                dateTimePickerEndTime.Value = new DateTime(2020, 1, 1, DateTime.Now.Hour + 2, 0, 0);
            } catch (ArgumentOutOfRangeException e) {
                dateTimePickerEndTime.Value = new DateTime(2020, 1, 1, DateTime.Now.Hour, 0, 0);
            }
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
