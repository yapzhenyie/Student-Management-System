using StudentManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Classes
{
    class User {

        private static User currentUser = null;

        private int userId;
        private EnumUser type;
        private string username;
        private string password;

        public User(int userId, EnumUser type, string username, string password) {
            this.userId = userId;
            this.type = type;
            this.username = username;
            this.password = password;
        }

        public int getUserId() {
            return this.userId;
        }

        public EnumUser Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        /*
         * Set the current logined user which using the application.
         */
        public static void setCurrentUser(User user) {
            currentUser = user;
        }

        /*
         * Gets the current user which using the application.
         */ 
        public static User getCurrentUser() {
            return currentUser;
        }
    }
}
