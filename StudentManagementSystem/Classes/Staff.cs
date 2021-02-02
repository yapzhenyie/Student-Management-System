using StudentManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Classes {

    class Staff : User {

        private int staffId;
        private string name;
        private EnumGender gender;
        private DateTime dateOfBirth;
        private string email;
        private string contact;
        private string address;
        private DateTime dateOfRegistration;

        public Staff(int userid, string username, string password, int staffId, string name, EnumGender gender, DateTime dateOfBirth, string email, string contact, string address, DateTime dateOfRegistration) 
            : base(userid, EnumUser.Staff, username, password) {
            this.staffId = staffId;
            this.name = name;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.contact = contact;
            this.address = address;
            this.dateOfRegistration = dateOfRegistration;
        }
        public int StaffID {
            get { return this.staffId; }
        }

        /*
         * The rest only use the get accesser. 
         */

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
    }
}
