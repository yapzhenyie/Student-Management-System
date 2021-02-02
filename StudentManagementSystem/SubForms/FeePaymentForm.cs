using StudentManagementSystem.Classes;
using StudentManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.SubForms {
    class FeePaymentForm {


        private static List<System.Windows.Forms.Control> components = new List<System.Windows.Forms.Control>();


        private static Label labelStudentFeePayment;
        private static Label labelStudentName;
        private static Label labelStudentID;
        private static Label labelDate;
        private static Label labelColon1;
        private static Label labelColon2;
        private static Label labelColon3;
        private static Label labelResultStudentName;
        private static Label labelResultStudentID;
        private static Label labelResultDate;
        private static TextBox textBoxSearchBox2;
        private static Button buttonSearch;
        private static ListBox listBoxSearchResult2;
        private static Panel panelTable;
        private static TableLayoutPanel tableLayoutPanel1;
        private static Button buttonPay;
        private static Button buttonGoBack;
        private static TextBox textBoxCash;
        private static Label labelResultTotalFee;
        private static Label labelCash;
        private static Label labelTotalFee;


        private static CheckBox selectAllCheckBox;
        private static List<CheckBox> checkBoxes = new List<CheckBox>();

        private static Dictionary<int, String> searchResults = new Dictionary<int, String>();
        private static List<Payment> pendingPayments = new List<Payment>();
        private static List<Payment> selectedPayments = new List<Payment>();
        private static Student selectedStudent = null;
        private static float cash = 0;

        private static bool initialized = false;
        private static bool goBackToCourseEnrollmentPage = false;

        private static ErrorProvider err = Program.getStaffForm().errorProvider1;

        public static void initComponents() {
            if (initialized == true) {
                return;
            }
            labelStudentFeePayment = new Label();
            labelStudentName = new Label();
            labelStudentID = new Label();
            labelDate = new Label();
            labelColon1 = new Label();
            labelColon2 = new Label();
            labelColon3 = new Label();
            labelResultStudentName = new Label();
            labelResultStudentID = new Label();
            labelResultDate = new Label();
            textBoxSearchBox2 = new TextBox();
            buttonSearch = new Button();
            listBoxSearchResult2 = new ListBox();
            panelTable = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonPay = new Button();
            buttonGoBack = new Button();
            textBoxCash = new TextBox();
            labelResultTotalFee = new Label();
            labelCash = new Label();
            labelTotalFee = new Label();

            panelTable.SuspendLayout();
            // 
            // labelStudentFeePayment
            // 
            labelStudentFeePayment.AutoSize = true;
            labelStudentFeePayment.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentFeePayment.Location = new System.Drawing.Point(196, 58);
            labelStudentFeePayment.Name = "labelStudentFeePayment";
            labelStudentFeePayment.Size = new System.Drawing.Size(299, 37);
            labelStudentFeePayment.TabIndex = 0;
            labelStudentFeePayment.Text = "Student Fee Payment";
            components.Add(labelStudentFeePayment);
            // 
            // textBoxSearchBox
            // 
            textBoxSearchBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxSearchBox2.Location = new System.Drawing.Point(660, 85);
            textBoxSearchBox2.Name = "textBoxSearchBox2";
            textBoxSearchBox2.Size = new System.Drawing.Size(139, 22);
            textBoxSearchBox2.TabIndex = 1;
            textBoxSearchBox2.Text = "Student ID";
            textBoxSearchBox2.ForeColor = System.Drawing.Color.Gray;
            textBoxSearchBox2.Enter += new System.EventHandler(textBoxSearchBox_Enter);
            textBoxSearchBox2.Leave += new System.EventHandler(textBoxSearchBox_Leave);
            textBoxSearchBox2.TextChanged += new System.EventHandler(textBoxSearchBox_TextChanged);
            components.Add(textBoxSearchBox2);
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSearch.Location = new System.Drawing.Point(797, 84);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(75, 24);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += new System.EventHandler(buttonSearch_Click);
            components.Add(buttonSearch);
            // 
            // listBoxSearchResult2
            // 
            listBoxSearchResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listBoxSearchResult2.FormattingEnabled = true;
            listBoxSearchResult2.ItemHeight = 16;
            listBoxSearchResult2.Location = new System.Drawing.Point(660, 106);
            listBoxSearchResult2.Name = "listBoxSearchResult2";
            listBoxSearchResult2.Size = new System.Drawing.Size(139, 85);
            listBoxSearchResult2.TabIndex = 3;
            listBoxSearchResult2.SelectedIndexChanged += new System.EventHandler(listBoxSearchResult_SelectedIndexChanged);
            listBoxSearchResult2.Hide();
            components.Add(listBoxSearchResult2);
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentName.Location = new System.Drawing.Point(210, 120);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new System.Drawing.Size(93, 16);
            labelStudentName.TabIndex = 4;
            labelStudentName.Text = "Student Name";
            components.Add(labelStudentName);
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelStudentID.Location = new System.Drawing.Point(210, 150);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new System.Drawing.Size(76, 16);
            labelStudentID.TabIndex = 5;
            labelStudentID.Text = "Student ID";
            components.Add(labelStudentID);
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDate.Location = new System.Drawing.Point(210, 180);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(37, 16);
            labelDate.TabIndex = 6;
            labelDate.Text = "Date";
            components.Add(labelDate);
            // 
            // labelColon1
            // 
            labelColon1.AutoSize = true;
            labelColon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelColon1.Location = new System.Drawing.Point(300, 120);
            labelColon1.Name = "labelColon1";
            labelColon1.Size = new System.Drawing.Size(11, 16);
            labelColon1.TabIndex = 7;
            labelColon1.Text = ":";
            components.Add(labelColon1);
            // 
            // labelColon2
            // 
            labelColon2.AutoSize = true;
            labelColon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelColon2.Location = new System.Drawing.Point(300, 150);
            labelColon2.Name = "labelColon2";
            labelColon2.Size = new System.Drawing.Size(11, 16);
            labelColon2.TabIndex = 8;
            labelColon2.Text = ":";
            components.Add(labelColon2);
            // 
            // labelColon3
            // 
            labelColon3.AutoSize = true;
            labelColon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelColon3.Location = new System.Drawing.Point(300, 180);
            labelColon3.Name = "labelColon3";
            labelColon3.Size = new System.Drawing.Size(11, 16);
            labelColon3.TabIndex = 9;
            labelColon3.Text = ":";
            components.Add(labelColon3);
            // 
            // labelResultStudentName
            // 
            labelResultStudentName.AutoSize = true;
            labelResultStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultStudentName.Location = new System.Drawing.Point(320, 120);
            labelResultStudentName.Name = "labelResultStudentName";
            labelResultStudentName.Size = new System.Drawing.Size(100, 16);
            labelResultStudentName.TabIndex = 10;
            labelResultStudentName.Text = "";
            labelResultStudentName.Hide();
            components.Add(labelResultStudentName);
            // 
            // labelResultStudentID
            // 
            labelResultStudentID.AutoSize = true;
            labelResultStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultStudentID.Location = new System.Drawing.Point(320, 150);
            labelResultStudentID.Name = "labelResultStudentID";
            labelResultStudentID.Size = new System.Drawing.Size(80, 16);
            labelResultStudentID.TabIndex = 11;
            labelResultStudentID.Text = "";
            labelResultStudentID.Hide();
            components.Add(labelResultStudentID);
            // 
            // labelResultDate
            // 
            labelResultDate.AutoSize = true;
            labelResultDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultDate.Location = new System.Drawing.Point(320, 180);
            labelResultDate.Name = "labelResultDate";
            labelResultDate.Size = new System.Drawing.Size(50, 16);
            labelResultDate.TabIndex = 12;
            labelResultDate.Text = "";
            labelResultDate.Hide();
            components.Add(labelResultDate);
            // 
            // panelTable
            // 
            panelTable.Controls.Add(tableLayoutPanel1);
            panelTable.Location = new System.Drawing.Point(210, 215);
            panelTable.Name = "panelTable";
            panelTable.Size = new System.Drawing.Size(600, 255);
            panelTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelTable.TabIndex = 13;
            components.Add(panelTable);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(600, 255);
            tableLayoutPanel1.Controls.Add(SelectAllCheckBox(), 0, 0);
            tableLayoutPanel1.Controls.Add(newLabel("No", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 1, 0);
            tableLayoutPanel1.Controls.Add(newLabel("Items", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 2, 0);
            tableLayoutPanel1.Controls.Add(newLabel("Month", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 3, 0);
            tableLayoutPanel1.Controls.Add(newLabel("Fee", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 4, 0);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // buttonPay
            // 
            buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonPay.Location = new System.Drawing.Point(410, 500);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new System.Drawing.Size(80, 30);
            buttonPay.TabIndex = 19;
            buttonPay.Text = "Pay Now";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += new System.EventHandler(buttonPay_Click);
            components.Add(buttonPay);
            // 
            // buttonGoBack
            // 
            buttonGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonGoBack.Location = new System.Drawing.Point(540, 500);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new System.Drawing.Size(80, 30);
            buttonGoBack.TabIndex = 20;
            buttonGoBack.Text = "Go Back";
            buttonGoBack.UseVisualStyleBackColor = true;
            buttonGoBack.Click += new System.EventHandler(buttonGoBack_Click);
            components.Add(buttonGoBack);

            // 
            // labelTotalFee
            // 
            labelTotalFee.AutoSize = true;
            labelTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTotalFee.Location = new System.Drawing.Point(660, 475);
            labelTotalFee.Name = "labelTotalFee";
            labelTotalFee.Size = new System.Drawing.Size(83, 16);
            labelTotalFee.TabIndex = 15;
            labelTotalFee.Text = "Total Fee : RM";
            components.Add(labelTotalFee);
            // 
            // labelCash
            // 
            labelCash.AutoSize = true;
            labelCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCash.Location = new System.Drawing.Point(660, 505);
            labelCash.Name = "labelCash";
            labelCash.Size = new System.Drawing.Size(90, 16);
            labelCash.TabIndex = 16;
            labelCash.Text = "Cash :         RM";
            components.Add(labelCash);
            // 
            // labelResultTotalFee
            // 
            labelResultTotalFee.AutoSize = true;
            labelResultTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelResultTotalFee.Location = new System.Drawing.Point(770, 475);
            labelResultTotalFee.Name = "labelResultTotalFee";
            labelResultTotalFee.Size = new System.Drawing.Size(45, 16);
            labelResultTotalFee.TabIndex = 17;
            labelResultTotalFee.Text = "0.00";
            components.Add(labelResultTotalFee);
            // 
            // textBoxCash
            // 
            textBoxCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxCash.Location = new System.Drawing.Point(770, 502);
            textBoxCash.Name = "textBoxCash";
            textBoxCash.Size = new System.Drawing.Size(80, 22);
            textBoxCash.TabIndex = 18;
            textBoxCash.Leave += new EventHandler(textBoxCash_Leave);
            components.Add(textBoxCash);

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
                if(component == listBoxSearchResult2) {
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

        public static void hideSomeComponents() {
            if (initialized == false) {
                return;
            }
            listBoxSearchResult2.Hide();
            labelResultStudentName.Hide();
            labelResultStudentID.Hide();
            labelResultDate.Hide();
            clearFeePaymentTable(true);
        }

        public static void resetFeePaymentInformation() {
            if (initialized == true) {
                textBoxSearchBox2.Text = "Student ID";
                textBoxSearchBox2.ForeColor = System.Drawing.Color.Gray;
                labelResultStudentName.Text = "";
                labelResultStudentID.Text = "";
                labelResultDate.Text = "";
                labelResultTotalFee.Text = "0.00";
                clearFeePaymentTable(true);
                listBoxSearchResult2.Items.Clear();
                listBoxSearchResult2.Hide();
                labelResultStudentName.Hide();
                labelResultStudentID.Hide();
                labelResultDate.Hide();
                selectAllCheckBox = null;
                textBoxCash.Text = "";
                err.SetError(textBoxCash, "");
            }

            checkBoxes.Clear();
            pendingPayments.Clear();
            selectedPayments.Clear();
            searchResults.Clear();
            selectedStudent = null;
            goBackToCourseEnrollmentPage = false;
            cash = 0;
        }

        public static void clearFeePaymentTable(bool reShow) {
            tableLayoutPanel1.Hide();
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(SelectAllCheckBox(), 0, 0);
            tableLayoutPanel1.Controls.Add(newLabel("No", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 1, 0);
            tableLayoutPanel1.Controls.Add(newLabel("Items", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 2, 0);
            tableLayoutPanel1.Controls.Add(newLabel("Month", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 3, 0);
            tableLayoutPanel1.Controls.Add(newLabel("Fee", System.Drawing.FontStyle.Bold, ContentAlignment.MiddleCenter), 4, 0);
            if(reShow)
                tableLayoutPanel1.Show();
        }

        public static void updateFeePaymentTable(bool forceUpdate) {
            if (!forceUpdate && initialized == false) {
                return;
            }
            if(selectedStudent == null) {
                return;
            }
            tableLayoutPanel1.Hide();
            clearFeePaymentTable(false);
            checkBoxes.Clear();
            pendingPayments.Clear();
            selectedPayments.Clear();
            calculateTotalFee();
            labelResultTotalFee.Text = "0.00";
            textBoxCash.Text = "";

            List<Payment> pments = new List<Payment>();
            selectedStudent.loadOldPendingPayment();
            List<Payment> oldPayments = selectedStudent.getOldPendingPayment();
            List<Payment> newPayments = selectedStudent.getNewPendingPayment();
            if (oldPayments != null && oldPayments.Count != 0) {
                pments.AddRange(oldPayments);
            }
            if (newPayments != null && newPayments.Count != 0) {
                pments.AddRange(newPayments);
            }
            if(pments == null || pments.Count == 0) {
                tableLayoutPanel1.Show();
                return;
            }
            pendingPayments = pments;
            int rows = pments.Count;
            tableLayoutPanel1.RowCount = rows + 2;
            int i = 1;
            foreach (var payment in pments) {
                if(payment.getPaidStatus() == true) {
                    continue;
                }
                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tableLayoutPanel1.Controls.Add(newCheckBox(payment), 0, i);
                tableLayoutPanel1.Controls.Add(newLabel(i.ToString(), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 1, i);
                Course.loadCourses();
                Course course = Course.getCourseById(payment.getCourseId());
                string itemName = "NaN";
                if(course != null) {
                    itemName = course.getCourseName();
                }
                tableLayoutPanel1.Controls.Add(newLabel(itemName, System.Drawing.FontStyle.Regular, ContentAlignment.MiddleLeft), 2, i);
                tableLayoutPanel1.Controls.Add(newLabel(payment.getIssueDate().ToString("dd/MM/yyyy"), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 3, i);
                tableLayoutPanel1.Controls.Add(newLabel(payment.getFee().ToString(), System.Drawing.FontStyle.Regular, ContentAlignment.MiddleCenter), 4, i);
                i++;
            }
            tableLayoutPanel1.Show();
            tableLayoutPanel1.Refresh();
        }

        private static void textBoxSearchBox_Enter(object sender, EventArgs e) {
            if (textBoxSearchBox2.Text == "Student ID") {
                textBoxSearchBox2.Text = "";
                textBoxSearchBox2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private static void textBoxSearchBox_Leave(object sender, EventArgs e) {
            if (textBoxSearchBox2.Text == "") {
                textBoxSearchBox2.Text = "Student ID";
                textBoxSearchBox2.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private static void textBoxSearchBox_TextChanged(object sender, EventArgs e) {
            lookForResult(false);
        }

        private static void buttonSearch_Click(object sender, EventArgs e) {
            lookForResult(true);
            if (searchResults.Count == 1) {
                updateStudentInformation(0);
            }
        }

        private static void listBoxSearchResult_SelectedIndexChanged(object sender, EventArgs e) {
            int index = listBoxSearchResult2.SelectedIndex;
            if (index == -1) {
                listBoxSearchResult2.Hide();
                return;
            }
            if (listBoxSearchResult2.Text == "No Result Found!") {
                return;
            }
            if (searchResults.Count == 0) {
                MessageBox.Show("An error occurred while doing this process.");
                return;
            }
            updateStudentInformation(index);
        }

        private static void buttonGoBack_Click(object sender, EventArgs e) {
            if(goBackToCourseEnrollmentPage) {
                Program.getStaffForm().setCurrentSelectedLabel(2);
                hideAllComponents();
                CourseEnrollmentForm.showAllComponents();
            } else {
                resetFeePaymentInformation();
            }
        }

        private static void buttonPay_Click(object sender, EventArgs e) {
            if(selectedStudent == null) {
                MessageBox.Show("No student is selected!");
                return;
            }
            List<Payment> sPayment = selectedPayments;
            if (sPayment == null || sPayment.Count == 0) {
                MessageBox.Show("No items selected for payment!");
                return;
            }
            if (textBoxCash.Text == "" || textBoxCash.Text.Replace(" ", "") == "") {
                err.SetError(textBoxCash, "Cash cannot be empty.");
                return;
            }
            float payment = calculateTotalFee();
            if (payment > cash) {
                MessageBox.Show("Not enough money to pay the payment!");
                return;
            }
            List<Payment> oldPayments = selectedStudent.getOldPendingPayment();
            List<Payment> newPayments = selectedStudent.getNewPendingPayment();
            foreach (Payment sP in sPayment) {
                if(oldPayments != null)
                    foreach (Payment p in oldPayments) {
                        if(p == sP) {
                            p.setPaidStatus(true);
                        }
                    }
                if (newPayments != null)
                    foreach (Payment p in newPayments) {
                        if (p == sP) {
                            p.setPaidStatus(true);
                        }
                    }
            }
            Staff staff = (Staff) User.getCurrentUser();
            if(staff == null) {
                MessageBox.Show("An error occurred while doing this process!\nPlease login and try again.");
                return;
            }
            List<Course> enrollCourses = selectedStudent.getCacheEnrollCourses();
            if(enrollCourses != null && enrollCourses.Count != 0) {
                foreach(Course eC in enrollCourses) {
                    Program.getDatabaseUtils().enrollCourse(selectedStudent.StudentID, eC);
                    if (!selectedStudent.getEnrolledCourses().Contains(eC))
                        selectedStudent.getEnrolledCourses().Add(eC);
                }
            }
            enrollCourses.Clear();
            List<Course> unenrollCourses = selectedStudent.getCacheUnenrollCourses();
            if (unenrollCourses != null && unenrollCourses.Count != 0) {
                foreach (Course uC in unenrollCourses) {
                    Program.getDatabaseUtils().unenrollCourse(selectedStudent.StudentID, uC);
                    selectedStudent.getEnrolledCourses().Remove(uC);
                }
            }
            unenrollCourses.Clear();
            DateTime dateOfPayment = DateTime.Now;
            int receiptNo = Program.getDatabaseUtils().updateTransactionData(selectedStudent.StudentID, dateOfPayment, payment, cash, staff.StaffID, oldPayments, newPayments);
            // Error occur while writing the data to database.
            if(receiptNo == -1) {
                MessageBox.Show("Something went wrong!\nFailed to pay the fees and generater receipt!");
                return;
            }
            Receipt.receipt = new Receipt(selectedStudent, staff, receiptNo, dateOfPayment, payment, cash, selectedPayments);
            Program.getStaffForm().printPreviewDialog1.Document = Program.getStaffForm().printDocument1;
            updateFeePaymentTable(false);
            Program.getStaffForm().printPreviewDialog1.ShowDialog();
        }

        private static void textBoxCash_Leave(object sender, EventArgs e) {
            if (textBoxCash.Text == "" || textBoxCash.Text.Replace(" ", "") == "") {
                return;
            }
            float cashPayment = 0;
            if(!float.TryParse(textBoxCash.Text, out cashPayment)) {
                MessageBox.Show("Invalid currency format!");
                return;
            }
            cash = cashPayment;
        }

        private static void lookForResult(bool showsError) {
            string studentID = textBoxSearchBox2.Text;
            if (studentID == "" || studentID.Replace(" ", "") == "" || studentID == "Student ID") {
                if (showsError)
                    MessageBox.Show("You must enter a student's ID before doing the searching!");
                listBoxSearchResult2.Hide();
                return;
            }
            int studentIDResult;
            if(!int.TryParse(studentID, out studentIDResult)) {
                if (showsError) { 
                    MessageBox.Show("This is not a valid student ID!");
                } else {
                    listBoxSearchResult2.Show();
                    listBoxSearchResult2.BringToFront();
                    listBoxSearchResult2.Items.Clear();
                    listBoxSearchResult2.Items.Add("No Result Found!");
                }
                return;
            }
            Dictionary<int, String> studentList = Program.getDatabaseUtils().getSimilarStudentName(studentIDResult);
            if (studentList == null || studentList.Count == 0) {
                if (showsError) {
                    MessageBox.Show("Student Not Found!");
                } else {
                    listBoxSearchResult2.Show();
                    listBoxSearchResult2.BringToFront();
                    listBoxSearchResult2.Items.Clear();
                    listBoxSearchResult2.Items.Add("No Result Found!");
                }
                return;
            }
            searchResults = studentList;
            listBoxSearchResult2.Show();
            listBoxSearchResult2.BringToFront();
            listBoxSearchResult2.Items.Clear();
            foreach (KeyValuePair<int, String> result in studentList) {
                int studentId = Program.getDatabaseUtils().getUniqueIdByUserId("Student", "StudentID", result.Key);
                listBoxSearchResult2.Items.Add(studentId + " - " + result.Value);
            }
        }

        private static void updateStudentInformation(int index) {
            Student student = Program.getDatabaseUtils().getStudentInformation(searchResults.ElementAt(index).Key);
            if (student == null) {
                MessageBox.Show("An error occurred while doing this process.");
                return;
            }

            textBoxSearchBox2.Text = "Student ID";
            textBoxSearchBox2.ForeColor = System.Drawing.Color.Gray;
            student.checkIfNeedToPayForNextPayment();
            setSelectedStudent(student);
        }

        private static CheckBox SelectAllCheckBox() {
            CheckBox checkBox2 = new CheckBox();
            checkBox2.Size = new System.Drawing.Size(80, 17);
            checkBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
            checkBox2.Tag = "SelectAll";
            selectAllCheckBox = checkBox2;
            return checkBox2;
        }


        private static CheckBox newCheckBox(Payment payment) {
            CheckBox checkBox1 = new CheckBox();
            checkBox1.Size = new System.Drawing.Size(80, 17);
            checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
            checkBox1.Tag = payment;
            checkBoxes.Add(checkBox1);
            return checkBox1;
        }

        private static void checkBox1_CheckedChanged(object sender, EventArgs e) {
            selectedPayments.Clear();
            foreach (var checkBox in checkBoxes) {
                if (checkBox.Checked) {
                    Payment payment = (Payment) checkBox.Tag;
                    selectedPayments.Add(payment);
                }
            }
            calculateTotalFee();
        }


        private static void checkBox2_CheckedChanged(object sender, EventArgs e) {
            selectedPayments.Clear();
            if(selectAllCheckBox.Checked) {
                foreach (var checkBox in checkBoxes) {
                    checkBox.Checked = true;
                    Payment pment = (Payment)checkBox.Tag;
                    if (!selectedPayments.Contains(pment))
                        selectedPayments.Add(pment);
                }
            } else {
                foreach (var checkBox in checkBoxes) {
                    checkBox.Checked = false;
                }
            }
        }

        private static float calculateTotalFee() {
            if(selectedPayments == null || selectedPayments.Count == 0) {
                labelResultTotalFee.Text = "0.00";
                return 0;
            }
            float fees = 0;
            foreach(Payment payment in selectedPayments) {
                fees += payment.getFee();
            }
            labelResultTotalFee.Text = fees.ToString("0.00");
            return fees;
        }

        private static Label newLabel(string text, FontStyle style, ContentAlignment textAlign) {
            Label label = new Label();
            label.Text = text;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, style, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.TextAlign = textAlign;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            return label;
        }

        public static void setGoBackToCourseEnrollmentPage(bool arg0) {
            goBackToCourseEnrollmentPage = arg0;
        }

        public static void setSelectedStudent(Student student) {
            if(student == null) {
                goBackToCourseEnrollmentPage = false;
                return;
            }
            selectedStudent = student;
            listBoxSearchResult2.Hide();
            goBackToCourseEnrollmentPage = true;
            labelResultStudentName.Show();
            labelResultStudentID.Show();
            labelResultDate.Show();
            labelResultStudentName.Text = student.Name;
            labelResultStudentID.Text = student.StudentID.ToString();
            labelResultDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBoxCash.Text = "";
            updateFeePaymentTable(false);
        }

        public static List<System.Windows.Forms.Control> getFormComponents() {
            return components;
        }
    }
}
