using StudentManagementSystem.Database;
using StudentManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    static class Program {

        private static LoginForm loginForm;
        private static StaffForm staffForm = null;
        private static TutorForm tutorForm = null;
        private static StudentForm studentForm = null;

        private static DatabaseUtils dbUtils;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginForm = new LoginForm();

            DatabaseConnection con = new DatabaseConnection();
            bool create = con.createDatabaseFile();
            con.openConnection();
            dbUtils = new DatabaseUtils(con.getConnection());
            if (create) {
                dbUtils.createTables();
                dbUtils.addData();
            }

            Application.Run(loginForm);
            con.closeConnection();
        }

        public static LoginForm initLoginForm() {
            return loginForm = new LoginForm();
        }

        public static LoginForm getLoginForm() {
            return loginForm;
        }

        public static StaffForm initStaffForm() {
            return staffForm = new StaffForm();
        }

        public static StaffForm getStaffForm() {
            return staffForm;
        }

        public static TutorForm initTutorForm() {
            return tutorForm = new TutorForm();
        }

        public static TutorForm getTutorForm() {
            return tutorForm;
        }

        public static StudentForm initStudentForm() {
            return studentForm = new StudentForm();
        }

        public static StudentForm getStudentForm() {
            return studentForm;
        }

        public static DatabaseUtils getDatabaseUtils() {
            return dbUtils;
        }
    }
}
