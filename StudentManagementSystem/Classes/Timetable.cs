using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Classes {
    class Timetable {

        /*
         * Following source code obtained from (Microsoft Documentation).
         */
        private static List<Timetable> timetables = new List<Timetable>();

        private int courseId;
        private int tutorId;
        private DateTime date;
        private DateTime startTime;
        private DateTime endTime;

        public Timetable(int courseId, int tutorId, DateTime date, DateTime startTime, DateTime endTime) {
            this.courseId = courseId;
            this.tutorId = tutorId;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public int getCourseId() {
            return this.courseId;
        }

        public int getTutorId() {
            return this.tutorId;
        }

        public DateTime Date {
            get { return this.date; }
            set { this.date = value; }
        }

        public DateTime StartTime {
            get { return this.startTime; }
            set { this.startTime = value; }
        }

        public DateTime EndTime {
            get { return this.endTime; }
            set { this.endTime = value; }
        }

        public static List<Timetable> getTimetables() {
            return timetables;
        }
    }
}
