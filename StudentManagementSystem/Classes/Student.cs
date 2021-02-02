using StudentManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Classes {
    class Student : User {

        /*
         * Following source code obtained from (Microsoft Documentation).
         */ 
        private List<Course> enrolledCourses = new List<Course>();
        private List<Course> cacheEnrollCourses = new List<Course>();
        private List<Course> cacheUnenrollCourses = new List<Course>();

        private List<Payment> oldPayments = new List<Payment>();
        private List<Payment> newPayments = new List<Payment>();

        private int studentId;
        private string name;
        private EnumGender gender;
        private DateTime dateOfBirth;
        private string email;
        private string contact;
        private string address;
        private DateTime dateOfRegistration;

        private bool initOldPayments = false;

        public Student(int userid, string username, string password, int studentId, string name, EnumGender gender, DateTime dateOfBirth, string email, string contact, string address, DateTime dateOfRegistration) 
            : base(userid, EnumUser.Student, username, password) {
            this.studentId = studentId;
            this.name = name;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.contact = contact;
            this.address = address;
            this.dateOfRegistration = dateOfRegistration;
            loadEnrolledCourses();
        }

        public int StudentID {
            get { return this.studentId; }
        }

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public EnumGender Gender {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public DateTime DateOfBirth {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        public string Email {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Contact {
            get { return this.contact; }
            set { this.contact = value; }
        }

        public string Address {
            get { return this.address; }
            set { this.address = value; }
        }

        public DateTime DateOfRegistration {
            get { return this.dateOfRegistration; }
        }

        /*
         * Loads student enrolled cources from the database.
         */ 
        public void loadEnrolledCourses() {
            if(enrolledCourses.Count != 0) {
                enrolledCourses.Clear();
            }
            List<Course> studentEnrolledCourses = Program.getDatabaseUtils().getStudentEnrolledCourses(this.studentId);
            if (studentEnrolledCourses != null && studentEnrolledCourses.Count != 0) {
                enrolledCourses.AddRange(studentEnrolledCourses);
            }
        }

        /*
         * Gets the courses that student have already enrolled.
         */ 
        public List<Course> getEnrolledCourses() {
            return this.enrolledCourses;
        }

        /*
         * Gets the current selected courses that wants to enroll.
         */  
        public List<Course> getCacheEnrollCourses() {
            return this.cacheEnrollCourses;
        }

        /*
         * Gets the courses that student want to cancel enroll.
         */ 
        public List<Course> getCacheUnenrollCourses() {
            return this.cacheUnenrollCourses;
        }

        /*
         * Gets the course payments that student newly enrolled. 
         */ 
        public List<Payment> getNewPendingPayment() {
            if(this.cacheEnrollCourses == null || this.cacheEnrollCourses.Count == 0) {
                return null;
            }
            foreach (Course course in this.cacheEnrollCourses) {
                bool found = false;
                foreach (Payment pay in newPayments) {
                    if (pay.getCourseId() == course.getCourseId()) {
                        found = true;
                        break;
                    }
                }
                if(found == true) {
                    continue;
                }
                Payment newPayment = new Payment(this.studentId, 0, course.getCourseId(), course.getFee(), DateTime.Now.Date, false);
                newPayments.Add(newPayment);
            }
            return newPayments;
        }

        /*
         * Load old pending payment from the database..
         */ 
        public void loadOldPendingPayment() {
            initOldPayments = true;
            oldPayments = Program.getDatabaseUtils().getStudentPendingPayment(this.studentId);
        }

        /*
         * Gets old pending payment which is the courses that already enrolled.
         */
        public List<Payment> getOldPendingPayment() {
            if(initOldPayments == false) {
                initOldPayments = true;
            return oldPayments = Program.getDatabaseUtils().getStudentPendingPayment(this.studentId);
            }
            return oldPayments;
        }

        /*
         * Gets the student related timetables from the database.
         */ 
        public List<Timetable> getTimetables() {
            return Program.getDatabaseUtils().getStudentTimetables(this);
        }

        /*
         * Gets all the payments(paid/unpaid) from the database.
         */ 
        public List<Payment> getPayments() {
            return Program.getDatabaseUtils().getStudentPayments(this.studentId);
        }
       
        /*
         * Check if student need to pay for the next payment for their enrolled courses.
         * Add new transaction in the database if needed to pay.
         */
        public void checkIfNeedToPayForNextPayment() {
            Program.getDatabaseUtils().checkIfNeedToPayForNextPayment(this.studentId);
        }
    }
}
