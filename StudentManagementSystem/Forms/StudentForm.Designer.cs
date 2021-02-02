namespace StudentManagementSystem
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFees = new System.Windows.Forms.Label();
            this.labelTimetable = new System.Windows.Forms.Label();
            this.labelProfile = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panelUserLogo = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelAPUTuitionCentre = new System.Windows.Forms.Label();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.panelLogoutLogo = new System.Windows.Forms.Panel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelLogout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.labelFees);
            this.panel1.Controls.Add(this.labelTimetable);
            this.panel1.Controls.Add(this.labelProfile);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 561);
            this.panel1.TabIndex = 12;
            // 
            // labelFees
            // 
            this.labelFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.labelFees.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFees.Font = new System.Drawing.Font("Microsoft NeoGothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFees.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelFees.Location = new System.Drawing.Point(0, 135);
            this.labelFees.Name = "labelFees";
            this.labelFees.Size = new System.Drawing.Size(180, 40);
            this.labelFees.TabIndex = 6;
            this.labelFees.Text = "Fees";
            this.labelFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFees.Click += new System.EventHandler(this.labelFees_Click);
            this.labelFees.MouseEnter += new System.EventHandler(this.labelFees_MouseEnter);
            this.labelFees.MouseLeave += new System.EventHandler(this.labelFees_MouseLeave);
            this.labelFees.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelFees_MouseMove);
            // 
            // labelTimetable
            // 
            this.labelTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.labelTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTimetable.Font = new System.Drawing.Font("Microsoft NeoGothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimetable.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelTimetable.Location = new System.Drawing.Point(0, 95);
            this.labelTimetable.Name = "labelTimetable";
            this.labelTimetable.Size = new System.Drawing.Size(180, 40);
            this.labelTimetable.TabIndex = 5;
            this.labelTimetable.Text = "Timetable";
            this.labelTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTimetable.Click += new System.EventHandler(this.labelTimetable_Click);
            this.labelTimetable.MouseEnter += new System.EventHandler(this.labelTimetable_MouseEnter);
            this.labelTimetable.MouseLeave += new System.EventHandler(this.labelTimetable_MouseLeave);
            this.labelTimetable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTimetable_MouseMove);
            // 
            // labelProfile
            // 
            this.labelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.labelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft NeoGothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProfile.Location = new System.Drawing.Point(0, 55);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(180, 40);
            this.labelProfile.TabIndex = 4;
            this.labelProfile.Text = "Profile";
            this.labelProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProfile.Click += new System.EventHandler(this.labelProfile_Click);
            this.labelProfile.MouseEnter += new System.EventHandler(this.labelProfile_MouseEnter);
            this.labelProfile.MouseLeave += new System.EventHandler(this.labelProfile_MouseLeave);
            this.labelProfile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelProfile_MouseMove);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelAPUTuitionCentre
            // 
            this.labelAPUTuitionCentre.AutoSize = true;
            this.labelAPUTuitionCentre.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAPUTuitionCentre.Location = new System.Drawing.Point(6, 9);
            this.labelAPUTuitionCentre.Name = "labelAPUTuitionCentre";
            this.labelAPUTuitionCentre.Size = new System.Drawing.Size(273, 37);
            this.labelAPUTuitionCentre.TabIndex = 9;
            this.labelAPUTuitionCentre.Text = "APU Tuition Centre";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelLogout);
            this.panel2.Controls.Add(this.labelAPUTuitionCentre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 55);
            this.panel2.TabIndex = 13;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentForm";
            this.Text = "Student Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelLogout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFees;
        private System.Windows.Forms.Label labelTimetable;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelUserLogo;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Panel panelLogoutLogo;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Label labelAPUTuitionCentre;
    }
}