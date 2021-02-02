using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    partial class StaffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFeePayment = new System.Windows.Forms.Label();
            this.labelCourseEnrollment = new System.Windows.Forms.Label();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panelUserLogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.panelLogoutLogo = new System.Windows.Forms.Panel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.labelStudentManagementSystem = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.labelFeePayment);
            this.panel1.Controls.Add(this.labelCourseEnrollment);
            this.panel1.Controls.Add(this.labelRegistration);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 561);
            this.panel1.TabIndex = 2;
            // 
            // labelFeePayment
            // 
            this.labelFeePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.labelFeePayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFeePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFeePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeePayment.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelFeePayment.Location = new System.Drawing.Point(0, 135);
            this.labelFeePayment.Name = "labelFeePayment";
            this.labelFeePayment.Size = new System.Drawing.Size(190, 40);
            this.labelFeePayment.TabIndex = 6;
            this.labelFeePayment.Text = "Fee Payment";
            this.labelFeePayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFeePayment.Click += new System.EventHandler(this.labelFeePayment_Click);
            this.labelFeePayment.MouseEnter += new System.EventHandler(this.labelFeePayment_MouseEnter);
            this.labelFeePayment.MouseLeave += new System.EventHandler(this.labelFeePayment_MouseLeave);
            this.labelFeePayment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelFeePayment_MouseMove);
            // 
            // labelCourseEnrollment
            // 
            this.labelCourseEnrollment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.labelCourseEnrollment.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCourseEnrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCourseEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseEnrollment.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCourseEnrollment.Location = new System.Drawing.Point(0, 95);
            this.labelCourseEnrollment.Name = "labelCourseEnrollment";
            this.labelCourseEnrollment.Size = new System.Drawing.Size(190, 40);
            this.labelCourseEnrollment.TabIndex = 5;
            this.labelCourseEnrollment.Text = "Course Enrollment";
            this.labelCourseEnrollment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCourseEnrollment.Click += new System.EventHandler(this.labelCourseEnrollment_Click);
            this.labelCourseEnrollment.MouseEnter += new System.EventHandler(this.labelCourseEnrollment_MouseEnter);
            this.labelCourseEnrollment.MouseLeave += new System.EventHandler(this.labelCourseEnrollment_MouseLeave);
            this.labelCourseEnrollment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelCourseEnrollment_MouseMove);
            // 
            // labelRegistration
            // 
            this.labelRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.labelRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistration.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelRegistration.Location = new System.Drawing.Point(0, 55);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(190, 40);
            this.labelRegistration.TabIndex = 4;
            this.labelRegistration.Text = "Registration";
            this.labelRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRegistration.Click += new System.EventHandler(this.labelRegistration_Click);
            this.labelRegistration.MouseEnter += new System.EventHandler(this.labelRegistration_MouseEnter);
            this.labelRegistration.MouseLeave += new System.EventHandler(this.labelRegistration_MouseLeave);
            this.labelRegistration.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelRegistration_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Controls.Add(this.panelUserLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 55);
            this.panel3.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(56, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(120, 20);
            this.labelName.TabIndex = 1;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUserLogo
            // 
            this.panelUserLogo.BackColor = System.Drawing.Color.White;
            this.panelUserLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelUserLogo.BackgroundImage")));
            this.panelUserLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelUserLogo.Location = new System.Drawing.Point(8, 6);
            this.panelUserLogo.Name = "panelUserLogo";
            this.panelUserLogo.Size = new System.Drawing.Size(45, 40);
            this.panelUserLogo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelLogout);
            this.panel2.Controls.Add(this.labelStudentManagementSystem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(190, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 55);
            this.panel2.TabIndex = 8;
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.panelLogoutLogo);
            this.panelLogout.Controls.Add(this.labelLogout);
            this.panelLogout.Location = new System.Drawing.Point(649, 3);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(43, 47);
            this.panelLogout.TabIndex = 9;
            this.panelLogout.Click += new System.EventHandler(this.panelLogout_Click);
            this.panelLogout.MouseEnter += new System.EventHandler(this.panelLogout_MouseEnter);
            this.panelLogout.MouseLeave += new System.EventHandler(this.panelLogout_MouseLeave);
            // 
            // panelLogoutLogo
            // 
            this.panelLogoutLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogoutLogo.BackgroundImage")));
            this.panelLogoutLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogoutLogo.Location = new System.Drawing.Point(1, 0);
            this.panelLogoutLogo.Name = "panelLogoutLogo";
            this.panelLogoutLogo.Size = new System.Drawing.Size(40, 34);
            this.panelLogoutLogo.TabIndex = 10;
            this.panelLogoutLogo.Click += new System.EventHandler(this.panelLogoutLogo_Click);
            this.panelLogoutLogo.MouseEnter += new System.EventHandler(this.panelLogoutLogo_MouseEnter);
            this.panelLogoutLogo.MouseLeave += new System.EventHandler(this.panelLogoutLogo_MouseLeave);
            // 
            // labelLogout
            // 
            this.labelLogout.BackColor = System.Drawing.Color.Transparent;
            this.labelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.Location = new System.Drawing.Point(0, 32);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(45, 13);
            this.labelLogout.TabIndex = 10;
            this.labelLogout.Text = "Log Out";
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            this.labelLogout.MouseEnter += new System.EventHandler(this.labelLogout_MouseEnter);
            this.labelLogout.MouseLeave += new System.EventHandler(this.labelLogout_MouseLeave);
            // 
            // labelStudentManagementSystem
            // 
            this.labelStudentManagementSystem.AutoSize = true;
            this.labelStudentManagementSystem.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentManagementSystem.Location = new System.Drawing.Point(6, 9);
            this.labelStudentManagementSystem.Name = "labelStudentManagementSystem";
            this.labelStudentManagementSystem.Size = new System.Drawing.Size(407, 37);
            this.labelStudentManagementSystem.TabIndex = 9;
            this.labelStudentManagementSystem.Text = "Student Management System";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffForm";
            this.Text = "Student Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserLogo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCourseEnrollment;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label labelFeePayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelLogoutLogo;
        private System.Windows.Forms.Label labelStudentManagementSystem;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private Label labelLogout;
        private Panel panelLogout;
        public System.Drawing.Printing.PrintDocument printDocument1;
        public PrintPreviewDialog printPreviewDialog1;
    }
}