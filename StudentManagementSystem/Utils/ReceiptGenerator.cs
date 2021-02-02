using StudentManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Utils {
    class ReceiptGenerator {

        /*
         * Following source code obtained from (Microsoft Documentation)
         * 
         * Print receipt in staff form.
         */
        public static void printReceipt(Receipt receipt, System.Drawing.Printing.PrintPageEventArgs e) {
            if(receipt == null) {
                return;
            }
            Bitmap bmp = Properties.Resources.receipt_logo;
            Image logo = bmp;
            e.Graphics.DrawImage(logo, 25, 25, logo.Width, logo.Height);
            e.Graphics.DrawString("OFFICIAL RECEIPT", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(25, 160));

            e.Graphics.DrawString("Receipt No", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(510, 200));
            e.Graphics.DrawString("Date", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(510, 230));
            e.Graphics.DrawString("Issue By", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(510, 260));
            e.Graphics.DrawString(":", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(610, 200));
            e.Graphics.DrawString(":", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(610, 230));
            e.Graphics.DrawString(":", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(610, 260));
            
            // Result
            e.Graphics.DrawString(receipt.getReceiptNo().ToString(), new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(640, 200));
            e.Graphics.DrawString(receipt.getDate().ToString("dd/MM/yyyy hh:mm tt"), new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(640, 230));
            e.Graphics.DrawString(receipt.getStaff().Name, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(640, 260));

            e.Graphics.DrawString("Student Name", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(30, 230));
            e.Graphics.DrawString(":", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(160, 230));
            e.Graphics.DrawString("Student ID", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(30, 260));
            e.Graphics.DrawString(":", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(160, 260));

            // Result
            e.Graphics.DrawString(receipt.getStudent().Name, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(190, 230));
            e.Graphics.DrawString(receipt.getStudent().StudentID.ToString(), new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(190, 260));


            e.Graphics.DrawLine(Pens.Black, 25, 300, 780, 300);
            e.Graphics.DrawString("No", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(30, 305));
            e.Graphics.DrawString("Item Description", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(120, 305));
            e.Graphics.DrawString("Month", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(565, 305));
            e.Graphics.DrawString("Price", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(700, 305));
            e.Graphics.DrawLine(Pens.Black, 25, 330, 780, 330);

            int no = 1;
            int inc = 30;
            foreach(Payment payment in receipt.getPayments()) {
                e.Graphics.DrawString(no + ".", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(30, 305 + inc));
                e.Graphics.DrawString(Course.getCourseById(payment.getCourseId()).getCourseName(), new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(120, 305 + inc));
                e.Graphics.DrawString(payment.getIssueDate().ToString("dd/MM/yyyy"), new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(550, 305 + inc));
                e.Graphics.DrawString(payment.getFee().ToString(), new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(700, 305 + inc));
                inc += 30;
                no++;
            }
            e.Graphics.DrawLine(Pens.Black, 25, 305 + inc, 780, 305 + inc);


            e.Graphics.DrawString("Total Price", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(550, 310 + inc));
            e.Graphics.DrawString("Cash", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(550, 340 + inc));
            e.Graphics.DrawString("Change", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(550, 370 + inc));
            e.Graphics.DrawString(":", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(650, 310 + inc));
            e.Graphics.DrawString(":", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(650, 340 + inc));
            e.Graphics.DrawString(":", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(650, 370 + inc));

            // Result
            float change = receipt.getCash() - receipt.getPayment();
            if(change < 0) {
                change = 0;
            }
            e.Graphics.DrawString("RM " + receipt.getPayment().ToString("0.00"), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(680, 310 + inc));
            e.Graphics.DrawString("RM " + receipt.getCash().ToString("0.00"), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(680, 340 + inc));
            e.Graphics.DrawString("RM " + change.ToString("0.00"), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(680, 370 + inc));
        }
    }
}
