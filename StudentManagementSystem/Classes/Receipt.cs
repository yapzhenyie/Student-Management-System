using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Classes {
    class Receipt {


        public static Receipt receipt = null;

        private Student student;
        private Staff staff;
        private int receiptNo;
        private DateTime date;
        private float payment;
        private float cash;
        private List<Payment> payments = new List<Payment>();

        /*
         * Use for generate receipt for print out. 
         */
        public Receipt(Student student, Staff staff, int receiptNo, DateTime date, float payment, float cash, List<Payment> payments) {
            this.student = student;
            this.staff = staff;
            this.receiptNo = receiptNo;
            this.date = date;
            this.payment = payment;
            this.cash = cash;
            this.payments.AddRange(payments);
        }

        public Student getStudent() {
            return this.student;
        }

        public Staff getStaff() {
            return this.staff;
        }

        public int getReceiptNo() {
            return this.receiptNo;
        }

        public DateTime getDate() {
            return this.date;
        }

        public float getPayment() {
            return this.payment;
        }

        public float getCash() {
            return this.cash;
        }

        /*
         * Gets the selected payments in a receipt.
         */
        public List<Payment> getPayments() {
            return this.payments;
        }
    }
}
