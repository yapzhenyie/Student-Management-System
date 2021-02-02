using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Classes {
    class Payment {
        
        private int studentId;
        private int receiptNo;
        private int courseId;
        private float fee;
        private DateTime issueDate;
        private bool paid;

        public Payment(int studentId, int receiptNo, int courseId, float fee, DateTime issueDate, bool paid) {
            this.studentId = studentId;
            this.receiptNo = receiptNo;
            this.courseId = courseId;
            this.fee = fee;
            this.issueDate = issueDate;
            this.paid = paid;
        }

        public int getStudentId() {
            return this.studentId;
        }

        public int getReceiptNo() {
            return this.receiptNo;
        }

        public void setReceiptNo(int no) {
            this.receiptNo = no;
        }

        public int getCourseId() {
            return this.courseId;
        }

        public float getFee() {
            return this.fee;
        }

        public DateTime getIssueDate() {
            return this.issueDate;
        }

        public bool getPaidStatus() {
            return this.paid;
        }

        public void setPaidStatus(bool paid) {
            this.paid = paid;
        }
    }
}
