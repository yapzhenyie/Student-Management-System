using StudentManagementSystem.Classes;
using StudentManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Database
{
    class DatabaseUtils
    {

        private OleDbConnection connection;

        public DatabaseUtils(OleDbConnection connection) {
            this.connection = connection;
        }

        public User verifyUser(string username, string password) {
            if(this.connection == null) {
                MessageBox.Show("Failed to communicate with the database.");
                return null;
            }
            if(username == "" || password == "") {
                MessageBox.Show("Username and Password cannbot be empty");
                return null;
            }

            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT * FROM [User] WHERE Username='" + username + "';";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    if (password == reader.GetString(2)) {
                        int userId = reader.GetInt32(0);
                        string pw = reader.GetString(2);
                        EnumUser userType;
                        try {
                            userType = (EnumUser) Enum.Parse(typeof(EnumUser), reader.GetString(3));
                        } catch (ArgumentException e) {
                            MessageBox.Show("This account is invalid!\nPlease ask for the administrator for help.");
                            return null;
                        }
                        reader.Close();
                        command.CommandText = "SELECT * FROM [" + getTableNameByUserType(userType) + "] WHERE UserID=" + userId + ";";
                        reader = command.ExecuteReader();
                        if (reader.Read()) {
                            int uniqueId = reader.GetInt32(0);
                            string name = reader.GetString(2);
                            EnumGender gender;
                            try {
                                gender = (EnumGender)Enum.Parse(typeof(EnumGender), reader.GetString(3));
                            } catch (ArgumentException e) {
                                gender = EnumGender.Male;
                            }
                            DateTime dateOfBirth;
                            try {
                                dateOfBirth = reader.GetDateTime(4);
                            } catch (InvalidCastException ex) {
                                dateOfBirth = DateTime.Now;
                            }
                            string email = "";
                            try {
                                email = reader.GetString(5);
                            } catch (InvalidCastException ex) {
                            }
                            string contact = "";
                            try {
                                contact = reader.GetString(6);
                            } catch (InvalidCastException ex) {
                            }
                            string address = "";
                            try {
                                address = reader.GetString(7);
                            } catch (InvalidCastException ex) {
                            }
                            DateTime dateOfRegistration;
                            try {
                                dateOfRegistration = reader.GetDateTime(8);
                            } catch (InvalidCastException ex) {
                                dateOfRegistration = DateTime.Now;
                            }
                            switch (userType) {
                                case EnumUser.Staff:
                                    return new Staff(userId, username, pw, uniqueId, name, gender, dateOfBirth, email, contact, address, dateOfRegistration);
                                case EnumUser.Tutor:
                                    return new Tutor(userId, username, pw, uniqueId, name, gender, dateOfBirth, email, contact, address, dateOfRegistration);
                                case EnumUser.Student:
                                    return new Student(userId, username, pw, uniqueId, name, gender, dateOfBirth, email, contact, address, dateOfRegistration);
                            }
                            return null;
                        }
                        MessageBox.Show("This account is invalid!\nPlease ask for the administrator for help.");
                        return null;
                    } else {
                        MessageBox.Show("The password is incorrect!");
                        return null;
                    }
                } else {
                    MessageBox.Show("Wrong username or password!");
                    return null;
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message + e.GetType());
                return null;
            }
        }

        public bool isUsernameUnique(string username) {
            if (this.connection == null) {
                return false;
            }
            if (username == "") {
                return false;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT [Username] FROM [User] WHERE Username='" + username + "';";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    return false;
                }
                return true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string getNameByUserId(int id) {
            if (this.connection == null) {
                return null;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT [UserType] FROM [User] WHERE ID=" + id + ";";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    EnumUser userType;
                    try {
                        userType = (EnumUser)Enum.Parse(typeof(EnumUser), reader.GetString(0));
                    } catch (ArgumentException e) {
                        MessageBox.Show("An error occurred while doing this process.");
                        return null;
                    }
                    reader.Close();
                    command.CommandText = "SELECT [Name] FROM [" + getTableNameByUserType(userType) + "] WHERE UserID=" + id + ";";
                    reader = command.ExecuteReader();
                    if (reader.Read()) {
                        return reader.GetString(0);
                    }
                }
                return null;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public int getUserIdByUniqueId(string tableName, string columnName, int uniqueId) {
            if (this.connection == null) {
                return -1;
            }
            if (tableName == "" || columnName == "") {
                return -1;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT [UserID] FROM [" + tableName + "] WHERE " + columnName + " = " + uniqueId + ";";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    return reader.GetInt32(0);
                }
                return -1;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public int getUniqueIdByUserId(string tableName, string columnName, int userId) {
            if (this.connection == null) {
                return -1;
            }
            if (tableName == "" || columnName == "") {
                return -1;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT [" + columnName + "] FROM [" + tableName + "] WHERE [UserID] = " + userId + ";";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    return reader.GetInt32(0);
                }
                return -1;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public string getNameByUniqueId(string tableName, string columnName, int uniqueId) {
            if (this.connection == null) {
                return null;
            }
            if(tableName == "" || columnName == "") {
                return null;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT [Name] FROM [" + tableName + "] WHERE " + columnName + " = " + uniqueId + ";";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                     return reader.GetString(0);
                }
                return null;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public int getIdByName(string username) {
            if (this.connection == null) {
                return 0;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT [ID] FROM [User] WHERE Username='" + username + "';";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    return reader.GetInt32(0);
                }
                return 0;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int getLargestValueOfPrimaryKey(string tableName, string primaryKey) {
            if (this.connection == null) {
                return -1;
            }
            if(tableName == "" || primaryKey == "") {
                return -1;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT MAX(" + primaryKey + ") FROM [" + tableName + "];";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    return reader.GetInt32(0);
                }
                return -1;
            } catch (System.InvalidCastException ex) {
                return -1;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public Dictionary<int, String> getSimilarStudentName(string name) {
            if (this.connection == null) {
                return null;
            }
            if(name == "") {
                return null;
            }
            Dictionary<int, String> list = new Dictionary<int, String>();
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT [UserID], [Name] FROM [Student] WHERE Name LIKE '%" + name + "%';";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    int userId = reader.GetInt32(0);
                    string similarName = reader.GetString(1);
                    if (similarName != null) {
                        list.Add(userId, similarName);
                    }
                }
                if(list == null || list.Count == 0) {
                    return null;
                }
                return list;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Dictionary<int, String> getSimilarStudentName(int studentId) {
            if (this.connection == null) {
                return null;
            }
            Dictionary<int, String> list = new Dictionary<int, String>();
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT [UserID], [Name] FROM [Student] WHERE StudentID LIKE '%" + studentId + "%';";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    int userId = reader.GetInt32(0);
                    string similarName = reader.GetString(1);
                    if (similarName != null) {
                        list.Add(userId, similarName);
                    }
                }
                if (list == null || list.Count == 0) {
                    return null;
                }
                return list;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Dictionary<int, String> getSimilarStudentUsername(string username) {//TODO
            if (this.connection == null) {
                return null;
            }
            Dictionary<int, String> list = new Dictionary<int, String>();
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT [UserID], [Name] FROM [User] WHERE Username LIKE '%" + username + "%' AND UserType = 'Student';";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    int userId = reader.GetInt32(0);
                    string similarName = reader.GetString(1);
                    if (similarName != null) {
                        list.Add(userId, similarName);
                    }
                }
                if (list == null || list.Count == 0) {
                    return null;
                }
                return list;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string getStudentNameByUserId(int id) {//TODO
            if (this.connection == null) {
                return null;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT [Name] FROM [Student] WHERE UserID=" + id + ";";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                     return reader.GetString(0);
                }
                return null;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Student getStudentInformation(int id) {
            if (this.connection == null) {
                return null;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT * FROM [User] WHERE ID=" + id + ";";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    string userName = reader.GetString(1);
                    string password = reader.GetString(2);
                    EnumUser userType;
                    try {
                        userType = (EnumUser)Enum.Parse(typeof(EnumUser), reader.GetString(3));
                    } catch (ArgumentException e) {
                        return null;
                    }
                    if (userType != EnumUser.Student) {
                        return null;
                    }
                    reader.Close();
                    command.CommandText = "SELECT * FROM [Student] WHERE UserID=" + id + ";";
                    reader = command.ExecuteReader();
                    if (reader.Read()) {
                        int studentId = reader.GetInt32(0);
                        string name = reader.GetString(2);
                        EnumGender gender;
                        try {
                            gender = (EnumGender)Enum.Parse(typeof(EnumGender), reader.GetString(3));
                        } catch (ArgumentException e) {
                            gender = EnumGender.Male;
                        }
                        DateTime dateOfBirth;
                        try {
                            dateOfBirth = reader.GetDateTime(4);
                        } catch (InvalidCastException ex) {
                            dateOfBirth = DateTime.Now;
                        }
                        string email = reader.GetString(5);
                        string contact = reader.GetString(6);
                        string address = reader.GetString(7);
                        DateTime dateOfRegistration;
                        try {
                            dateOfRegistration = reader.GetDateTime(8);
                        } catch (InvalidCastException ex) {
                            dateOfRegistration = DateTime.Now;
                        }
                        return new Student(id, userName, password, studentId, name, gender, dateOfBirth, email, contact, address, dateOfRegistration);
                    }
                }
                return null;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Student getStudentInformation(string username) {
            if (this.connection == null) {
                return null;
            }
            if (username == "") {
                return null;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT * FROM [User] WHERE Username='" + username + "';";
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    int userId = reader.GetInt32(0);
                    string userName = reader.GetString(1);
                    string password = reader.GetString(2);
                    EnumUser userType;
                    try {
                        userType = (EnumUser)Enum.Parse(typeof(EnumUser), reader.GetString(3));
                    } catch (ArgumentException e) {
                        return null;
                    }
                    if(userType != EnumUser.Student) {
                        return null;
                    }
                    reader.Close();
                    command.CommandText = "SELECT * FROM [Student] WHERE UserID=" + userId + ";";
                    reader = command.ExecuteReader();
                    if (reader.Read()) {
                        int studentId = reader.GetInt32(0);
                        string name = reader.GetString(2);
                        EnumGender gender;
                        try {
                            gender = (EnumGender)Enum.Parse(typeof(EnumGender), reader.GetString(3));
                        } catch (ArgumentException e) {
                            gender = EnumGender.Male;
                        }
                        DateTime dateOfBirth;
                        try {
                            dateOfBirth = reader.GetDateTime(4);
                        } catch (InvalidCastException ex) {
                            dateOfBirth = DateTime.Now;
                        }
                        string email = reader.GetString(5);
                        string contact = reader.GetString(6);
                        string address = reader.GetString(7);
                        DateTime dateOfRegistration;
                        try {
                            dateOfRegistration = reader.GetDateTime(8);
                        } catch (InvalidCastException ex) {
                            dateOfRegistration = DateTime.Now;
                        }
                        return new Student(userId, userName, password, studentId, name, gender, dateOfBirth, email, contact, address, dateOfRegistration);
                    }
                }
                return null;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void updateStudentInformation(Student student, bool updatePassword) {
            if (this.connection == null) {
                return;
            }
            if (student == null) {
                return;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                if (updatePassword) {
                    command.CommandText = "UPDATE [User] SET [Password] = @Password WHERE ID = @UserID;";
                    command.Parameters.AddWithValue("@Password", student.Password);
                    command.Parameters.AddWithValue("@UserID", student.getUserId());
                    command.ExecuteNonQuery();
                }
                command.CommandText = "UPDATE [Student] SET [Name] = @Name, [Gender] = @Gender, [DateOfBirth] = @DateOfBirth, [Email] = @Email, [Contact] = @Contact, [Address] = @Address WHERE StudentID = @StudentID;";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Gender", Enum.GetName(typeof(EnumGender), student.Gender));
                command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth.Date.ToString());
                command.Parameters.AddWithValue("@Email", student.Email);
                command.Parameters.AddWithValue("@Contact", student.Contact);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@StudentID", student.StudentID);
                command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public bool addNewUser(string username, string encryptedPassword, EnumUser user, string name, EnumGender gender, DateTime dateOfBirth, string email, string contact, string address) {
            if (this.connection == null) {
                return false;
            }
            if (username == "" || encryptedPassword == "" || name == "" || dateOfBirth == null || email == "" || contact == "") {
                return false;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO [User]([Username], [Password], [UserType]) VALUES (?, ?, ?);";
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", encryptedPassword);
                command.Parameters.AddWithValue("@UserType", Enum.GetName(typeof(EnumUser), user));
                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "INSERT INTO [" + getTableNameByUserType(user) + "]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES (?, ?, ?, ?, ?, ?, ?, ?);";
                command.Parameters.AddWithValue("@UserID", getIdByName(username));
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Gender", Enum.GetName(typeof(EnumGender), gender));
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.Date.ToString());
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Contact", contact);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@DateOfRegistration", DateTime.Now.Date.ToString());
                command.ExecuteNonQuery();
                return true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void loadCourses() {
            if (this.connection == null) {
                return;
            }
            List<Course> courses = Course.courses();
            courses.Clear(); //take note that each new class has its unique hashcode even the values are same.
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT * FROM [Course] ORDER BY CourseName ASC;";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    Course course = new Course(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                    courses.Add(course);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public int countStudentEnrolledInCourse(int courseId) {
            if (this.connection == null) {
                return 0;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT COUNT(CourseID) FROM [CourseEnrolled] WHERE [CourseID] = " + courseId + ";";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    return reader.GetInt32(0);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        public List<Course> getStudentEnrolledCourses(int studentId) {
            if (this.connection == null) {
                return null;
            }
            List<Course> courses = new List<Course>();
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT [CourseID] FROM [CourseEnrolled] WHERE StudentID=" + studentId + ";";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    courses.Add(Course.getCourseById(reader.GetInt32(0)));
                }
                return courses;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Payment> getStudentPendingPayment(int studentId) {
            if (this.connection == null) {
                return null;
            }
            List<Payment> payments = new List<Payment>();
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT * FROM [Transaction] WHERE StudentID=" + studentId + ";";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    int studentID = reader.GetInt32(1);
                    int receiptId = reader.GetInt32(2);
                    int courseId = reader.GetInt32(3);
                    int fee = reader.GetInt32(4);
                    DateTime issueDate = reader.GetDateTime(5);
                    bool paid = reader.GetBoolean(6);
                    if(paid) {
                        continue;
                    }
                    Payment payment = new Payment(studentID, receiptId, courseId, fee, issueDate, paid);
                    if(payment == null) {
                        continue;
                    }
                    payments.Add(payment);
                }
                if(payments.Count == 0) {
                    return null;
                }
                return payments;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Payment> getStudentPayments(int studentId) {
            if (this.connection == null) {
                return null;
            }
            List<Payment> payments = new List<Payment>();
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT * FROM [Transaction] WHERE StudentID=" + studentId + ";";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    int studentID = reader.GetInt32(1);
                    int receiptId = reader.GetInt32(2);
                    int courseId = reader.GetInt32(3);
                    int fee = reader.GetInt32(4);
                    DateTime issueDate = reader.GetDateTime(5);
                    bool paid = reader.GetBoolean(6);
                    Payment payment = new Payment(studentID, receiptId, courseId, fee, issueDate, paid);
                    if (payment == null) {
                        continue;
                    }
                    payments.Add(payment);
                }
                if (payments.Count == 0) {
                    return null;
                }
                return payments;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /*
         * Add new receipt in Receipt table.
         * Update transaction details.
         * 
         * @return The receiptNo.
         * Return -1 if no receiptNo found.
         */
        public int updateTransactionData(int studentId, DateTime date, float payment, float cash, int staffId, List<Payment> oldPayments, List<Payment> newPayments) {
            if (this.connection == null) {
                return -1;
            }
            int receiptNo = -1;
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO [Receipt]([StudentID], [IssueDate], [Payment], [Cash], [StaffID]) VALUES (?, ?, ?, ?, ?);";
                command.Parameters.AddWithValue("@StudentID", studentId);
                command.Parameters.AddWithValue("@IssueDate", date.ToString());
                command.Parameters.AddWithValue("@Payment", payment);
                command.Parameters.AddWithValue("@Cash", cash);
                command.Parameters.AddWithValue("@StaffID", staffId);
                command.ExecuteNonQuery();


                receiptNo = getLargestValueOfPrimaryKey("Receipt", "ReceiptNo");
                if(receiptNo == -1) {
                    MessageBox.Show("Failed to write record into database!");
                    return -1;
                }
                //receiptNo no need to add 1 as the new record is written into the database.
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                if (oldPayments != null && oldPayments.Count != 0) {
                    foreach (Payment pment in oldPayments) {
                        if(pment.getPaidStatus() == false) {
                            continue;
                        }
                        command.CommandText = "UPDATE [Transaction] SET [ReceiptNo] = @ReceiptNo, [Paid] = @Paid WHERE StudentID = @StudentID AND CourseID = @CourseID AND IssueDate = @IssueDate;";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@ReceiptNo", receiptNo);
                        command.Parameters.AddWithValue("@Paid", true);
                        command.Parameters.AddWithValue("@StudentID", pment.getStudentId());
                        command.Parameters.AddWithValue("@CourseID", pment.getCourseId());
                        command.Parameters.AddWithValue("@IssueDate", pment.getIssueDate());
                        command.ExecuteNonQuery();
                    }
                }
                if (newPayments != null && newPayments.Count != 0) {
                    foreach (Payment pment in newPayments) {
                        command.CommandText = "INSERT INTO [Transaction]([StudentID], [ReceiptNo], [CourseId], [Fee], [IssueDate], [Paid]) VALUES (?, ?, ?, ?, ?, ?);";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@StudentID", pment.getStudentId());
                        command.Parameters.AddWithValue("@ReceiptNo", receiptNo);
                        command.Parameters.AddWithValue("@CourseId", pment.getCourseId());
                        command.Parameters.AddWithValue("@Fee", pment.getFee());
                        command.Parameters.AddWithValue("@IssueDate", pment.getIssueDate().Date.ToString());
                        command.Parameters.AddWithValue("@Paid", pment.getPaidStatus());
                        command.ExecuteNonQuery();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return receiptNo;
        }

        public void enrollCourse(int studentId, Course course) {
            if (this.connection == null) {
                return;
            }
            if (course == null) {
                return;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES (?, ?, ?, ?);";
                command.Parameters.AddWithValue("@StudentID", studentId);
                command.Parameters.AddWithValue("@CourseID", course.getCourseId());
                command.Parameters.AddWithValue("@EnrollDate", DateTime.Now.Date.ToString());
                command.Parameters.AddWithValue("@NextPaymentDate", DateTime.Now.AddMonths(1).Date.ToString());
                command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void unenrollCourse(int studentId, Course course) {
            if (this.connection == null) {
                return;
            }
            if (course == null) {
                return;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM [CourseEnrolled] WHERE [StudentID] = @StudentID AND [CourseID] = @CourseID;";
                command.Parameters.AddWithValue("@StudentID", studentId);
                command.Parameters.AddWithValue("@CourseID", course.getCourseId());
                command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void checkIfNeedToPayForNextPayment(int studentId) {
            if (this.connection == null) {
                return;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT [CourseID], [NextPaymentDate] FROM [CourseEnrolled] WHERE StudentID = @StudentID;";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@StudentID", studentId);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    Course course = Course.getCourseById(reader.GetInt32(0));
                    if(course == null) {
                        continue;
                    }
                    DateTime nextPaymentDate = reader.GetDateTime(1);
                    if (DateTime.Now.Ticks >= nextPaymentDate.Ticks) {
                        addNewTransaction(studentId, course);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void addNewTransaction(int studentId, Course course) {
            if (this.connection == null) {
                return;
            }
            if (course == null) {
                return;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE [CourseEnrolled] SET [NextPaymentDate] = @NextPaymentDate WHERE StudentID = @StudentID AND CourseID = @CourseID;";
                command.Parameters.AddWithValue("@NextPaymentDate", DateTime.Now.AddMonths(1).Date);
                command.Parameters.AddWithValue("@StudentID", studentId);
                command.Parameters.AddWithValue("@CourseID", course.getCourseId());
                command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO [Transaction]([StudentID], [ReceiptNo], [CourseId], [Fee], [IssueDate], [Paid]) VALUES (?, ?, ?, ?, ?, ?);";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@StudentID", studentId);
                command.Parameters.AddWithValue("@ReceiptNo", 0);
                command.Parameters.AddWithValue("@CourseId", course.getCourseId());
                command.Parameters.AddWithValue("@Fee", course.getFee());
                command.Parameters.AddWithValue("@IssueDate", DateTime.Now.Date.ToString());
                command.Parameters.AddWithValue("@Paid", false);
                command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Timetable> getStudentTimetables(Student student) {
            if (this.connection == null) {
                return null;
            }
            if(student == null) {
                return null;
            }
            student.loadEnrolledCourses();
            if(student.getEnrolledCourses().Count == 0) {
                return null;
            }
            StringBuilder sb = new StringBuilder();
            foreach(Course c in student.getEnrolledCourses()) {
                sb.Append(c.getCourseId() + ", ");
            }
            if (sb.ToString().EndsWith(", "))
                sb.Remove(sb.Length - 2, 2);
            List<Timetable> timetables = new List<Timetable>();
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM [Timetable] WHERE CourseID IN (" + sb.ToString() + ") ORDER BY ClassDate ASC;";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    int courseId = reader.GetInt32(1);
                    int tutorId = reader.GetInt32(2);
                    DateTime date = reader.GetDateTime(3);
                    DateTime startTime = reader.GetDateTime(4);
                    DateTime endTime = reader.GetDateTime(5);
                    if(date.Date <= DateTime.Now.Date) {
                        if (date.Day != DateTime.Now.Day) {
                            continue;
                        }
                    }
                    Timetable timetable = new Timetable(courseId, tutorId, date, startTime, endTime);
                    timetables.Add(timetable);
                }
                if(timetables.Count == 0) {
                    return null;
                }
                return timetables;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Timetable> getTutorTimetables(Tutor tutor) {
            if (this.connection == null) {
                return null;
            }
            if (tutor == null) {
                return null;
            }
            List<Timetable> timetables = new List<Timetable>();
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM [Timetable] WHERE TutorID = " + tutor.TutorID + " ORDER BY ClassDate ASC;";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    int courseId = reader.GetInt32(1);
                    int tutorId = reader.GetInt32(2);
                    DateTime date = reader.GetDateTime(3);
                    DateTime startTime = reader.GetDateTime(4);
                    DateTime endTime = reader.GetDateTime(5);
                    Timetable timetable = new Timetable(courseId, tutorId, date, startTime, endTime);
                    timetables.Add(timetable);
                }
                if (timetables.Count == 0) {
                    return null;
                }
                return timetables;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void addTimetable(Timetable timetable) {
            if (this.connection == null) {
                return;
            }
            if (timetable == null) {
                return;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO [Timetable]([CourseID], [TutorID], [ClassDate], [StartTime], [EndTime]) VALUES (?, ?, ?, ?, ?);";
                command.Parameters.AddWithValue("@CourseID", timetable.getCourseId());
                command.Parameters.AddWithValue("@TutorID", timetable.getTutorId());
                command.Parameters.AddWithValue("@ClassDate", timetable.Date.Date.ToString());
                command.Parameters.AddWithValue("@StartTime", timetable.StartTime.ToString("hh:mm tt"));
                command.Parameters.AddWithValue("@EndTime", timetable.EndTime.ToString("hh:mm tt"));
                command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public bool isTimetableExistInDatabase(Timetable timetable) {
            if (this.connection == null) {
                return false;
            }
            if (timetable == null) {
                return false;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM [Timetable] WHERE [CourseID] = @CourseID AND [TutorID] = @TutorID AND [ClassDate] = @Date AND [StartTime] = @StartTime AND [EndTime] = @EndTime;";
                command.Parameters.AddWithValue("@CourseID", timetable.getCourseId());
                command.Parameters.AddWithValue("@TutorID", timetable.getTutorId());
                command.Parameters.AddWithValue("@ClassDate", timetable.Date.Date.ToString());
                command.Parameters.AddWithValue("@StartTime", timetable.StartTime.ToString("hh:mm tt"));
                command.Parameters.AddWithValue("@EndTime", timetable.EndTime.ToString("hh:mm tt"));
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    return true;
                }
                return false;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<Profile> getStudentProfile(int courseId) {
            List<Profile> profiles = new List<Profile>();
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT [StudentID], [EnrollDate] FROM [CourseEnrolled] WHERE CourseID = " + courseId + ";";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    int studentId = reader.GetInt32(0);
                    Profile profile = new Profile(studentId, getNameByUniqueId("Student", "StudentID", studentId), reader.GetDateTime(1), courseId);
                    profiles.Add(profile);
                }
                if (profiles.Count == 0) {
                    return null;
                }
                return profiles;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void createTables() {
            if (this.connection == null) {
                return;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "CREATE TABLE [User]([ID] AUTOINCREMENT NOT NULL PRIMARY KEY, [Username] VARCHAR(255) NOT NULL, [Password] VARCHAR(255) NOT NULL, [UserType] VARCHAR(7) NOT NULL);";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE [Student]([StudentID] AUTOINCREMENT NOT NULL PRIMARY KEY, [UserID] INT UNIQUE, [Name] VARCHAR(255), [Gender] VARCHAR(6), [DateOfBirth] DATE, [Email] VARCHAR(255), [Contact] VARCHAR(11), [Address] MEMO, [DateOfRegistration] DATE);";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE [Staff]([StaffID] AUTOINCREMENT NOT NULL PRIMARY KEY, [UserID] INT UNIQUE, [Name] VARCHAR(255), [Gender] VARCHAR(6), [DateOfBirth] DATE, [Email] VARCHAR(255), [Contact] VARCHAR(11), [Address] MEMO, [DateOfRegistration] DATE);";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE [Tutor]([TutorID] AUTOINCREMENT NOT NULL PRIMARY KEY, [UserID] INT UNIQUE, [Name] VARCHAR(255), [Gender] VARCHAR(6), [DateOfBirth] DATE, [Email] VARCHAR(255), [Contact] VARCHAR(11), [Address] MEMO, [DateOfRegistration] DATE);";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE [Course]([CourseID] AUTOINCREMENT NOT NULL PRIMARY KEY, [CourseName] VARCHAR(255), [TutorID] INT, [Fee] INT);";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE [CourseEnrolled]([ID] AUTOINCREMENT NOT NULL PRIMARY KEY, [StudentID] INT, [CourseID] INT, [EnrollDate] DATE, [NextPaymentDate] DATE);";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE [Timetable]([ID] AUTOINCREMENT NOT NULL PRIMARY KEY, [CourseID] INT, [TutorID] INT, [ClassDate] Date, [StartTime] TIME, [EndTime] TIME);";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE [Transaction]([TransactionID] AUTOINCREMENT NOT NULL PRIMARY KEY, [StudentID] INT, [ReceiptNo] INT, [CourseID] INT, [Fee] INT, [IssueDate] TIME, [Paid] BIT);";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE [Receipt]([ReceiptNo] AUTOINCREMENT NOT NULL PRIMARY KEY, [StudentID] INT, [IssueDate] DATE, [Payment] INT, [Cash] INT, [StaffID] INT);";
                command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void addData() {
            if (this.connection == null) {
                return;
            }
            try {
                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandType = CommandType.Text;
                for(int i = 1;i <= 3; i++) {
                    string text = "staff" + i;
                    command.CommandText = "INSERT INTO [User]([Username], [Password], [UserType]) VALUES ('" + text + "', '" + text + "', 'Staff');";
                    command.ExecuteNonQuery();
                }
                for (int i = 1; i <= 10; i++) {
                    string text = "tutor" + i;
                    command.CommandText = "INSERT INTO [User]([Username], [Password], [UserType]) VALUES ('" + text + "', '" + text + "', 'Tutor');";
                    command.ExecuteNonQuery();
                }
                for (int i = 1; i <= 5; i++) {
                    string text = "student" + i;
                    command.CommandText = "INSERT INTO [User]([Username], [Password], [UserType]) VALUES ('" + text + "', '" + text + "', 'Student');";
                    command.ExecuteNonQuery();
                }
                command.CommandText = "INSERT INTO [Staff]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(1, 'Yap Zhen Yie', 'Male', '12/1/2000', 'yapzhenyie@gmail.com', '0162358716', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Staff]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(2, 'Tey Tat Tze', 'Male', '8/17/2000', 'teytattze@gmail.com', '0186424641', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/2/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Staff]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(3, 'Lim Jia Yen', 'Female', '9/6/2000', 'limjiayen@gmail.com', '0161386452', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/3/2020');";
                command.ExecuteNonQuery();

                //Tutor
                command.CommandText = "INSERT INTO [Tutor]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(4, 'Mr. Tutor1', 'Male', '1/1/2000', 'tutor1@gmail.com', '0161386401', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Tutor]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(5, 'Mr. Tutor2', 'Female', '1/1/2000', 'tutor2@gmail.com', '0161386402', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Tutor]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(6, 'Mr. Tutor3', 'Male', '1/1/2000', 'tutor3@gmail.com', '0161386403', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Tutor]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(7, 'Mr. Tutor4', 'Male', '1/1/2000', 'tutor4@gmail.com', '0161386404', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Tutor]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(8, 'Mr. Tutor5', 'Male', '1/1/2000', 'tutor5@gmail.com', '0161386405', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Tutor]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(9, 'Mr. Tutor6', 'Male', '1/1/2000', 'tutor6@gmail.com', '0161386406', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Tutor]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(10, 'Mr. Tutor7', 'Female', '1/1/2000', 'tutor7@gmail.com', '0161386407', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Tutor]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(11, 'Mr. Tutor8', 'Female', '1/1/2000', 'tutor8@gmail.com', '0161386408', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Tutor]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(12, 'Mr. Tutor9', 'Male', '1/1/2000', 'tutor9@gmail.com', '0161386409', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Tutor]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(13, 'Mr. Tutor10', 'Male', '1/1/2000', 'tutor10@gmail.com', '0161386410', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();

                //Student
                command.CommandText = "INSERT INTO [Student]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(14, 'Marlon Quarterman', 'Male', '2/3/2000', 'student1@gmail.com', '0121364801', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/200');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Student]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(15, 'Preeta Krishnan', 'Female', '8/16/2000', 'student2@gmail.com', '0121364802', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Student]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(16, 'Alane Mollica', 'Female', '7/30/2000', 'student3@gmail.com', '0121364804', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Student]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(17, 'Shan Dhillon', 'Male', '8/19/2000', 'student4@gmail.com', '0121364805', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Student]([UserID], [Name], [Gender], [DateOfBirth], [Email], [Contact], [Address], [DateOfRegistration]) VALUES " +
                                        "(18, 'Goh Lo En', 'Female', '5/14/2000', 'student5@gmail.com', '0121364852', 'Technology Park Malaysia, Bukit Jalil, 57000 Kuala Lumpur.', '1/1/2020');";
                command.ExecuteNonQuery();

                //Course
                command.CommandText = "INSERT INTO [Course]([CourseName], [TutorID], [Fee]) VALUES " +
                                        "('Chinese', 1, 100);";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Course]([CourseName], [TutorID], [Fee]) VALUES " +
                                        "('Bahasa Malaysia', 2, 100);";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Course]([CourseName], [TutorID], [Fee]) VALUES " +
                                        "('English', 3, 100);";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Course]([CourseName], [TutorID], [Fee]) VALUES " +
                                        "('Mathematics', 4, 140);";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Course]([CourseName], [TutorID], [Fee]) VALUES " +
                                        "('Additional Mathematics', 5, 140);";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Course]([CourseName], [TutorID], [Fee]) VALUES " +
                                        "('Physics', 6, 120);";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Course]([CourseName], [TutorID], [Fee]) VALUES " +
                                        "('Chemistry', 7, 120);";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Course]([CourseName], [TutorID], [Fee]) VALUES " +
                                        "('Biology', 8, 120);";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Course]([CourseName], [TutorID], [Fee]) VALUES " +
                                        "('Geography', 9, 100);";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Course]([CourseName], [TutorID], [Fee]) VALUES " +
                                        "('History', 10, 100);";
                command.ExecuteNonQuery();

                // Student 1 Enroll Course
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(1, 3, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(1, 6, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(1, 9, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(1, 1, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();

                // Student 2 Enroll Course
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(2, 2, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(2, 5, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(2, 10, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(2, 7, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();

                // Student 3 Enroll Course
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(3, 4, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(3, 8, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(3, 2, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(3, 7, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();

                // Student 4 Enroll Course
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(4, 3, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(4, 9, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(4, 6, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(4, 2, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();

                // Student 5 Enroll Course
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(5, 7, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(5, 1, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(5, 2, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [CourseEnrolled]([StudentID], [CourseID], [EnrollDate], [NextPaymentDate]) VALUES " +
                                        "(5, 3, '1/1/2020', '2/1/2020');";
                command.ExecuteNonQuery();

                // Timetable
                command.CommandText = "INSERT INTO [Timetable]([CourseID], [TutorID], [ClassDate], [StartTime], [EndTime]) VALUES " +
                                        "(1, 1, '3/2/2020', '5:30PM', '7:30PM');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Timetable]([CourseID], [TutorID], [ClassDate], [StartTime], [EndTime]) VALUES " +
                                        "(3, 3, '5/2/2020', '5:30PM', '7:30PM');";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO [Timetable]([CourseID], [TutorID], [ClassDate], [StartTime], [EndTime]) VALUES " +
                                        "(7, 7, '6/2/2020', '5:30PM', '7:30PM');";
                command.ExecuteNonQuery();


                /*command.CommandText = "";
                command.ExecuteNonQuery();
                command.CommandText = "";
                command.ExecuteNonQuery();
                command.CommandText = "";
                command.ExecuteNonQuery();
                command.CommandText = "";
                command.ExecuteNonQuery();*/
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private static string getTableNameByUserType(EnumUser user) {
            switch (user) {
                case EnumUser.Staff:
                    return "Staff";
                case EnumUser.Tutor:
                    return "Tutor";
                case EnumUser.Student:
                    return "Student";
            }
            return null;
        }
    }
}
