namespace StudentManagementSystem.Forms
{
    partial class TutorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.panelLogoutLogo = new System.Windows.Forms.Panel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.labelStudentManagementSystem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStudentProfile = new System.Windows.Forms.Label();
            this.labelClassSchedule = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panelUserLogo = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelLogout);
            this.panel2.Controls.Add(this.labelStudentManagementSystem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 55);
            this.panel2.TabIndex = 24;
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.panelLogoutLogo);
            this.panelLogout.Controls.Add(this.labelLogout);
            this.panelLogout.Location = new System.Drawing.Point(649, 3);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(43, 47);
            this.panelLogout.TabIndex = 10;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.labelStudentProfile);
            this.panel1.Controls.Add(this.labelClassSchedule);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 561);
            this.panel1.TabIndex = 23;
            // 
            // labelStudentProfile
            // 
            this.labelStudentProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.labelStudentProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStudentProfile.Font = new System.Drawing.Font("Microsoft NeoGothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentProfile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelStudentProfile.Location = new System.Drawing.Point(0, 95);
            this.labelStudentProfile.Name = "labelStudentProfile";
            this.labelStudentProfile.Size = new System.Drawing.Size(180, 40);
            this.labelStudentProfile.TabIndex = 6;
            this.labelStudentProfile.Text = "Student Profile";
            this.labelStudentProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStudentProfile.Click += new System.EventHandler(this.labelStudentProfile_Click);
            this.labelStudentProfile.MouseEnter += new System.EventHandler(this.labelStudentProfile_MouseEnter);
            this.labelStudentProfile.MouseLeave += new System.EventHandler(this.labelStudentProfile_MouseLeave);
            this.labelStudentProfile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelStudentProfile_MouseMove);
            // 
            // labelClassSchedule
            // 
            this.labelClassSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.labelClassSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelClassSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelClassSchedule.Font = new System.Drawing.Font("Microsoft NeoGothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassSchedule.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelClassSchedule.Location = new System.Drawing.Point(0, 55);
            this.labelClassSchedule.Name = "labelClassSchedule";
            this.labelClassSchedule.Size = new System.Drawing.Size(180, 40);
            this.labelClassSchedule.TabIndex = 5;
            this.labelClassSchedule.Text = "Class Schedule";
            this.labelClassSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClassSchedule.Click += new System.EventHandler(this.labelClassSchedule_Click);
            this.labelClassSchedule.MouseEnter += new System.EventHandler(this.labelClassSchedule_MouseEnter);
            this.labelClassSchedule.MouseLeave += new System.EventHandler(this.labelClassSchedule_MouseLeave);
            this.labelClassSchedule.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelClassSchedule_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Controls.Add(this.panelUserLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 55);
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
            // TutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TutorForm";
            this.Text = "TutorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TutorForm_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelLogout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Panel panelLogoutLogo;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Label labelStudentManagementSystem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStudentProfile;
        private System.Windows.Forms.Label labelClassSchedule;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelUserLogo;
    }
}