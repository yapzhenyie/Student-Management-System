using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Classes {
    class Course {

        private static List<Course> Courses = new List<Course>();

        private int courseId;
        private string courseName;
        private int tutorId;
        private int fee;

        private static bool init = false;

        public Course(int courseId, string courseName, int tutorId, int fee) {
            this.courseId = courseId;
            this.courseName = courseName;
            this.tutorId = tutorId;
            this.fee = fee;
        }

        public int getCourseId() {
            return this.courseId;
        }

        public string getCourseName() {
            return this.courseName;
        }

        public int getTutorId() {
            return this.tutorId;
        }

        public string getTutorName() {
            return Program.getDatabaseUtils().getNameByUniqueId("Tutor", "TutorID", this.tutorId);
        }

        public int getFee() {
            return this.fee;
        }

        public int getStudentEnrolled() {
            return Program.getDatabaseUtils().countStudentEnrolledInCourse(this.courseId);
        }

        public bool isEnrollable() {
            if(getStudentEnrolled() < 25) {
                return true;
            }
            return false;
        }

        public string getEnrollableStatus() {
            if(isEnrollable()) {
                return "Enroll";
            }
            return "Fulled";
        }

        public static List<Course> courses() {
            return Courses;
        }

        /*
         * Load all the cources from the database.
         */
        public static void loadCourses() {
            if (init == false) {
                Program.getDatabaseUtils().loadCourses();
                init = true;
            }
        }

        public static Course getCourseById(int id) {
            if(init == false) {
                loadCourses();
            }
            if(Courses.Count == 0) {
                return null;
            }
            foreach(var course in Courses) {
                if(course.getCourseId() == id) {
                    return course;
                }
            }
            return null;
        }

        public static Course getCourseByName(string name) {
            if (init == false) {
                loadCourses();
            }
            if (Courses.Count == 0) {
                return null;
            }
            foreach (var course in Courses) {
                if (course.getCourseName() == name) {
                    return course;
                }
            }
            return null;
        }

        public static Course getCourseByTutorId(int tutorId) {
            if (init == false) {
                loadCourses();
            }
            if (Courses.Count == 0) {
                return null;
            }
            foreach (var course in Courses) {
                if (course.getTutorId() == tutorId) {
                    return course;
                }
            }
            return null;
        }

    }
}
