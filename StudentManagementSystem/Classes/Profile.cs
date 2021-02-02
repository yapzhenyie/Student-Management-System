using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Classes {
    class Profile {

        private int studentId;
        private string studentName;
        private DateTime enrollDate;
        private int courseId;

        public Profile(int studentId, string studentName, DateTime enrollDate, int courseId) {
            this.studentId = studentId;
            this.studentName = studentName;
            this.enrollDate = enrollDate;
            this.courseId = courseId;
        }

        public int getStudentId() {
            return this.studentId;
        }

        public string getStudentName() {
            return this.studentName;
        }

        public DateTime getEnrollDate() {
            return this.enrollDate;
        }

        public int getCourseId() {
            return this.courseId;
        }
    }
}
