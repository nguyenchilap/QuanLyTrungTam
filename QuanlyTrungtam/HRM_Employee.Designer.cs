
namespace QuanlyTrungtam
{
    partial class HRM_Employee
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
            this.EmployeeView = new System.Windows.Forms.ListView();
            this.ID_NV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_NV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salary_NV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BeginDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department_State = new System.Windows.Forms.ComboBox();
            this.Name_input = new System.Windows.Forms.TextBox();
            this.Name_text = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phonenum_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateBegin_input = new System.Windows.Forms.DateTimePicker();
            this.Salary_input = new System.Windows.Forms.NumericUpDown();
            this.add_button = new System.Windows.Forms.Button();
            this.Drop_button = new System.Windows.Forms.Button();
            this.Fix_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TruongPhongban = new System.Windows.Forms.Label();
            this.DOB_input = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Manage_Acc = new System.Windows.Forms.Button();
            this.Signout = new System.Windows.Forms.Button();
            this.GrantManage = new System.Windows.Forms.Button();
            this.LeaveWork = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Salary_input)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeView
            // 
            this.EmployeeView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EmployeeView.CheckBoxes = true;
            this.EmployeeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_NV,
            this.Name_NV,
            this.Salary_NV,
            this.DOB,
            this.SDT,
            this.Email,
            this.BeginDate,
            this.EndDate});
            this.EmployeeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeView.FullRowSelect = true;
            this.EmployeeView.GridLines = true;
            this.EmployeeView.HideSelection = false;
            this.EmployeeView.Location = new System.Drawing.Point(12, 56);
            this.EmployeeView.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.Size = new System.Drawing.Size(1045, 363);
            this.EmployeeView.TabIndex = 56;
            this.EmployeeView.UseCompatibleStateImageBehavior = false;
            this.EmployeeView.View = System.Windows.Forms.View.Details;
            // 
            // ID_NV
            // 
            this.ID_NV.Text = "ID";
            this.ID_NV.Width = 72;
            // 
            // Name_NV
            // 
            this.Name_NV.Text = "Tên";
            this.Name_NV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_NV.Width = 185;
            // 
            // Salary_NV
            // 
            this.Salary_NV.Text = "Lương";
            this.Salary_NV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Salary_NV.Width = 103;
            // 
            // DOB
            // 
            this.DOB.Text = "Ngày sinh";
            this.DOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DOB.Width = 135;
            // 
            // SDT
            // 
            this.SDT.Text = "Số điện thoại";
            this.SDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SDT.Width = 122;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 185;
            // 
            // BeginDate
            // 
            this.BeginDate.Text = "Ngày bắt đầu";
            this.BeginDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BeginDate.Width = 122;
            // 
            // EndDate
            // 
            this.EndDate.Text = "Ngày kết thúc";
            this.EndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndDate.Width = 118;
            // 
            // Department_State
            // 
            this.Department_State.FormattingEnabled = true;
            this.Department_State.Location = new System.Drawing.Point(669, 19);
            this.Department_State.Name = "Department_State";
            this.Department_State.Size = new System.Drawing.Size(388, 24);
            this.Department_State.TabIndex = 58;
            this.Department_State.SelectedIndexChanged += new System.EventHandler(this.Department_State_SelectedIndexChanged);
            // 
            // Name_input
            // 
            this.Name_input.Location = new System.Drawing.Point(41, 457);
            this.Name_input.Name = "Name_input";
            this.Name_input.Size = new System.Drawing.Size(340, 22);
            this.Name_input.TabIndex = 60;
            // 
            // Name_text
            // 
            this.Name_text.AutoSize = true;
            this.Name_text.Location = new System.Drawing.Point(38, 437);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(49, 17);
            this.Name_text.TabIndex = 61;
            this.Name_text.Text = "Name:";
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(41, 507);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(249, 22);
            this.email_input.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Email:";
            // 
            // phonenum_input
            // 
            this.phonenum_input.Location = new System.Drawing.Point(41, 560);
            this.phonenum_input.Name = "phonenum_input";
            this.phonenum_input.Size = new System.Drawing.Size(340, 22);
            this.phonenum_input.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Phone Number:";
            // 
            // dateBegin_input
            // 
            this.dateBegin_input.Location = new System.Drawing.Point(437, 507);
            this.dateBegin_input.Name = "dateBegin_input";
            this.dateBegin_input.Size = new System.Drawing.Size(266, 22);
            this.dateBegin_input.TabIndex = 67;
            this.dateBegin_input.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Salary_input
            // 
            this.Salary_input.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Salary_input.Location = new System.Drawing.Point(437, 561);
            this.Salary_input.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Salary_input.Name = "Salary_input";
            this.Salary_input.Size = new System.Drawing.Size(266, 22);
            this.Salary_input.TabIndex = 68;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.add_button.FlatAppearance.BorderSize = 3;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_button.Location = new System.Drawing.Point(1094, 447);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(130, 43);
            this.add_button.TabIndex = 69;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Drop_button
            // 
            this.Drop_button.BackColor = System.Drawing.Color.Firebrick;
            this.Drop_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drop_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Drop_button.FlatAppearance.BorderSize = 2;
            this.Drop_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Drop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Drop_button.Location = new System.Drawing.Point(1094, 551);
            this.Drop_button.Name = "Drop_button";
            this.Drop_button.Size = new System.Drawing.Size(130, 40);
            this.Drop_button.TabIndex = 70;
            this.Drop_button.Text = "Drop";
            this.Drop_button.UseVisualStyleBackColor = false;
            this.Drop_button.Click += new System.EventHandler(this.Drop_button_Click);
            // 
            // Fix_button
            // 
            this.Fix_button.BackColor = System.Drawing.Color.Orange;
            this.Fix_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fix_button.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Fix_button.FlatAppearance.BorderSize = 2;
            this.Fix_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fix_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fix_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fix_button.Location = new System.Drawing.Point(1094, 500);
            this.Fix_button.Name = "Fix_button";
            this.Fix_button.Size = new System.Drawing.Size(130, 40);
            this.Fix_button.TabIndex = 71;
            this.Fix_button.Text = "Fix";
            this.Fix_button.UseVisualStyleBackColor = false;
            this.Fix_button.Click += new System.EventHandler(this.Fix_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Date Begin:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(789, 482);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(226, 22);
            this.Username.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(786, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "Username:";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(789, 541);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(226, 22);
            this.Pass.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(786, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 77;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 78;
            this.label8.Text = "Trưởng phòng :";
            // 
            // TruongPhongban
            // 
            this.TruongPhongban.AutoSize = true;
            this.TruongPhongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TruongPhongban.Location = new System.Drawing.Point(506, 19);
            this.TruongPhongban.Name = "TruongPhongban";
            this.TruongPhongban.Size = new System.Drawing.Size(57, 20);
            this.TruongPhongban.TabIndex = 79;
            this.TruongPhongban.Text = "Name";
            // 
            // DOB_input
            // 
            this.DOB_input.Location = new System.Drawing.Point(437, 457);
            this.DOB_input.Name = "DOB_input";
            this.DOB_input.Size = new System.Drawing.Size(266, 22);
            this.DOB_input.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 81;
            this.label9.Text = "Date of Birth:";
            // 
            // Manage_Acc
            // 
            this.Manage_Acc.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Manage_Acc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Manage_Acc.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.Manage_Acc.FlatAppearance.BorderSize = 2;
            this.Manage_Acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manage_Acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_Acc.ForeColor = System.Drawing.Color.Black;
            this.Manage_Acc.Location = new System.Drawing.Point(1079, 12);
            this.Manage_Acc.Name = "Manage_Acc";
            this.Manage_Acc.Size = new System.Drawing.Size(160, 47);
            this.Manage_Acc.TabIndex = 82;
            this.Manage_Acc.Text = "Manage Account";
            this.Manage_Acc.UseVisualStyleBackColor = false;
            this.Manage_Acc.Click += new System.EventHandler(this.View_Detail_Click);
            // 
            // Signout
            // 
            this.Signout.BackColor = System.Drawing.Color.DarkRed;
            this.Signout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Signout.FlatAppearance.BorderSize = 2;
            this.Signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signout.ForeColor = System.Drawing.Color.Transparent;
            this.Signout.Location = new System.Drawing.Point(1079, 76);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(160, 47);
            this.Signout.TabIndex = 84;
            this.Signout.Text = "Sign out";
            this.Signout.UseVisualStyleBackColor = false;
            this.Signout.Click += new System.EventHandler(this.Signout_Click);
            // 
            // GrantManage
            // 
            this.GrantManage.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.GrantManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrantManage.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.GrantManage.FlatAppearance.BorderSize = 4;
            this.GrantManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrantManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrantManage.ForeColor = System.Drawing.Color.Black;
            this.GrantManage.Location = new System.Drawing.Point(1079, 257);
            this.GrantManage.Name = "GrantManage";
            this.GrantManage.Size = new System.Drawing.Size(160, 42);
            this.GrantManage.TabIndex = 85;
            this.GrantManage.Text = "Grant Manage";
            this.GrantManage.UseVisualStyleBackColor = false;
            this.GrantManage.Click += new System.EventHandler(this.button2_Click);
            // 
            // LeaveWork
            // 
            this.LeaveWork.BackColor = System.Drawing.Color.Tomato;
            this.LeaveWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeaveWork.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.LeaveWork.FlatAppearance.BorderSize = 4;
            this.LeaveWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveWork.ForeColor = System.Drawing.Color.Black;
            this.LeaveWork.Location = new System.Drawing.Point(1079, 320);
            this.LeaveWork.Name = "LeaveWork";
            this.LeaveWork.Size = new System.Drawing.Size(160, 42);
            this.LeaveWork.TabIndex = 86;
            this.LeaveWork.Text = "Leave Work";
            this.LeaveWork.UseVisualStyleBackColor = false;
            this.LeaveWork.Click += new System.EventHandler(this.LeaveWork_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UVN Tin Tuc Hep", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 35);
            this.label10.TabIndex = 87;
            this.label10.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // HRM_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1251, 597);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LeaveWork);
            this.Controls.Add(this.GrantManage);
            this.Controls.Add(this.Signout);
            this.Controls.Add(this.Manage_Acc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DOB_input);
            this.Controls.Add(this.TruongPhongban);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fix_button);
            this.Controls.Add(this.Drop_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Salary_input);
            this.Controls.Add(this.dateBegin_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phonenum_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.Name_input);
            this.Controls.Add(this.Department_State);
            this.Controls.Add(this.EmployeeView);
            this.Name = "HRM_Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.HRM_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Salary_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView EmployeeView;
        private System.Windows.Forms.ColumnHeader ID_NV;
        private System.Windows.Forms.ColumnHeader Name_NV;
        private System.Windows.Forms.ColumnHeader Salary_NV;
        private System.Windows.Forms.ComboBox Department_State;
        private System.Windows.Forms.TextBox Name_input;
        private System.Windows.Forms.Label Name_text;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phonenum_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateBegin_input;
        private System.Windows.Forms.NumericUpDown Salary_input;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button Drop_button;
        private System.Windows.Forms.Button Fix_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TruongPhongban;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.ColumnHeader SDT;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader BeginDate;
        private System.Windows.Forms.ColumnHeader EndDate;
        private System.Windows.Forms.DateTimePicker DOB_input;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Manage_Acc;
        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.Button GrantManage;
        private System.Windows.Forms.Button LeaveWork;
        private System.Windows.Forms.Label label10;
    }
}