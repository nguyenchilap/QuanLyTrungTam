
namespace QuanlyTrungtam
{
    partial class Teacher_Students
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
            this.StudentView = new System.Windows.Forms.ListView();
            this.ID_Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email_Teacger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT_Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Major = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.FilterClass = new System.Windows.Forms.ComboBox();
            this.FilterYear = new System.Windows.Forms.ComboBox();
            this.FilterMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.FilterCourses = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Diemthi_input = new System.Windows.Forms.TextBox();
            this.Sobuoivang_input = new System.Windows.Forms.NumericUpDown();
            this.Sobuoivang_button = new System.Windows.Forms.Button();
            this.Diemthi_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LichThiView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.Sobuoivang_input)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentView
            // 
            this.StudentView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StudentView.CheckBoxes = true;
            this.StudentView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Teacher,
            this.Name_Teacher,
            this.Email_Teacger,
            this.SDT_Teacher,
            this.Major,
            this.columnHeader1});
            this.StudentView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentView.FullRowSelect = true;
            this.StudentView.GridLines = true;
            this.StudentView.HideSelection = false;
            this.StudentView.Location = new System.Drawing.Point(41, 75);
            this.StudentView.Margin = new System.Windows.Forms.Padding(4);
            this.StudentView.Name = "StudentView";
            this.StudentView.Size = new System.Drawing.Size(786, 357);
            this.StudentView.TabIndex = 59;
            this.StudentView.UseCompatibleStateImageBehavior = false;
            this.StudentView.View = System.Windows.Forms.View.Details;
            // 
            // ID_Teacher
            // 
            this.ID_Teacher.Text = "Mã HV";
            this.ID_Teacher.Width = 61;
            // 
            // Name_Teacher
            // 
            this.Name_Teacher.Text = "Tên Học viên";
            this.Name_Teacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_Teacher.Width = 169;
            // 
            // Email_Teacger
            // 
            this.Email_Teacger.Text = "Email";
            this.Email_Teacger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email_Teacger.Width = 196;
            // 
            // SDT_Teacher
            // 
            this.SDT_Teacher.Text = "Số điện thoại";
            this.SDT_Teacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SDT_Teacher.Width = 104;
            // 
            // Major
            // 
            this.Major.Text = "Số buổi vắng";
            this.Major.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Major.Width = 99;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Điểm thi";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 92;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UVN Tin Tuc Hep", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 35);
            this.label10.TabIndex = 96;
            this.label10.Text = "DANH SÁCH HỌC VIÊN";
            // 
            // FilterClass
            // 
            this.FilterClass.FormattingEnabled = true;
            this.FilterClass.Location = new System.Drawing.Point(609, 34);
            this.FilterClass.Name = "FilterClass";
            this.FilterClass.Size = new System.Drawing.Size(218, 24);
            this.FilterClass.TabIndex = 102;
            this.FilterClass.SelectedIndexChanged += new System.EventHandler(this.FilterClass_SelectedIndexChanged);
            // 
            // FilterYear
            // 
            this.FilterYear.FormattingEnabled = true;
            this.FilterYear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.FilterYear.Location = new System.Drawing.Point(266, 34);
            this.FilterYear.Name = "FilterYear";
            this.FilterYear.Size = new System.Drawing.Size(77, 24);
            this.FilterYear.TabIndex = 103;
            this.FilterYear.SelectedIndexChanged += new System.EventHandler(this.FilterYear_SelectedIndexChanged);
            // 
            // FilterMonth
            // 
            this.FilterMonth.FormattingEnabled = true;
            this.FilterMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.FilterMonth.Location = new System.Drawing.Point(349, 34);
            this.FilterMonth.Name = "FilterMonth";
            this.FilterMonth.Size = new System.Drawing.Size(68, 24);
            this.FilterMonth.TabIndex = 104;
            this.FilterMonth.SelectedIndexChanged += new System.EventHandler(this.FilterMonth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 106;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 107;
            this.label3.Text = "Classes";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Brown;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Back.FlatAppearance.BorderSize = 5;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(41, 464);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(138, 50);
            this.Back.TabIndex = 108;
            this.Back.Text = "< Back to Menu";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // FilterCourses
            // 
            this.FilterCourses.FormattingEnabled = true;
            this.FilterCourses.Location = new System.Drawing.Point(434, 34);
            this.FilterCourses.Name = "FilterCourses";
            this.FilterCourses.Size = new System.Drawing.Size(169, 24);
            this.FilterCourses.TabIndex = 109;
            this.FilterCourses.SelectedIndexChanged += new System.EventHandler(this.FilterCourses_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 110;
            this.label4.Text = "Courses";
            // 
            // Diemthi_input
            // 
            this.Diemthi_input.Location = new System.Drawing.Point(622, 450);
            this.Diemthi_input.Name = "Diemthi_input";
            this.Diemthi_input.Size = new System.Drawing.Size(120, 22);
            this.Diemthi_input.TabIndex = 111;
            // 
            // Sobuoivang_input
            // 
            this.Sobuoivang_input.Location = new System.Drawing.Point(336, 451);
            this.Sobuoivang_input.Name = "Sobuoivang_input";
            this.Sobuoivang_input.Size = new System.Drawing.Size(120, 22);
            this.Sobuoivang_input.TabIndex = 112;
            // 
            // Sobuoivang_button
            // 
            this.Sobuoivang_button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Sobuoivang_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sobuoivang_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.Sobuoivang_button.FlatAppearance.BorderSize = 3;
            this.Sobuoivang_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sobuoivang_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sobuoivang_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sobuoivang_button.Location = new System.Drawing.Point(336, 482);
            this.Sobuoivang_button.Name = "Sobuoivang_button";
            this.Sobuoivang_button.Size = new System.Drawing.Size(120, 38);
            this.Sobuoivang_button.TabIndex = 113;
            this.Sobuoivang_button.Text = "Update";
            this.Sobuoivang_button.UseVisualStyleBackColor = false;
            this.Sobuoivang_button.Click += new System.EventHandler(this.Sobuoivang_button_Click);
            // 
            // Diemthi_button
            // 
            this.Diemthi_button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Diemthi_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Diemthi_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.Diemthi_button.FlatAppearance.BorderSize = 3;
            this.Diemthi_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diemthi_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diemthi_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Diemthi_button.Location = new System.Drawing.Point(622, 482);
            this.Diemthi_button.Name = "Diemthi_button";
            this.Diemthi_button.Size = new System.Drawing.Size(120, 38);
            this.Diemthi_button.TabIndex = 114;
            this.Diemthi_button.Text = "Update";
            this.Diemthi_button.UseVisualStyleBackColor = false;
            this.Diemthi_button.Click += new System.EventHandler(this.Diemthi_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 115;
            this.label5.Text = "Số buổi vắng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 116;
            this.label6.Text = "Điểm thi :";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Khóa học";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Môn học ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 146;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày thi";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 111;
            // 
            // LichThiView
            // 
            this.LichThiView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LichThiView.CheckBoxes = true;
            this.LichThiView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LichThiView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LichThiView.FullRowSelect = true;
            this.LichThiView.GridLines = true;
            this.LichThiView.HideSelection = false;
            this.LichThiView.Location = new System.Drawing.Point(849, 75);
            this.LichThiView.Margin = new System.Windows.Forms.Padding(4);
            this.LichThiView.Name = "LichThiView";
            this.LichThiView.Size = new System.Drawing.Size(391, 357);
            this.LichThiView.TabIndex = 117;
            this.LichThiView.UseCompatibleStateImageBehavior = false;
            this.LichThiView.View = System.Windows.Forms.View.Details;
            // 
            // Teacher_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1253, 532);
            this.Controls.Add(this.LichThiView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Diemthi_button);
            this.Controls.Add(this.Sobuoivang_button);
            this.Controls.Add(this.Sobuoivang_input);
            this.Controls.Add(this.Diemthi_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FilterCourses);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterMonth);
            this.Controls.Add(this.FilterYear);
            this.Controls.Add(this.FilterClass);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StudentView);
            this.Name = "Teacher_Students";
            this.Text = "Teacher_Students";
            this.Load += new System.EventHandler(this.Teacher_Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sobuoivang_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView StudentView;
        private System.Windows.Forms.ColumnHeader ID_Teacher;
        private System.Windows.Forms.ColumnHeader Name_Teacher;
        private System.Windows.Forms.ColumnHeader Email_Teacger;
        private System.Windows.Forms.ColumnHeader SDT_Teacher;
        private System.Windows.Forms.ColumnHeader Major;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox FilterClass;
        private System.Windows.Forms.ComboBox FilterYear;
        private System.Windows.Forms.ComboBox FilterMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox FilterCourses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Diemthi_input;
        private System.Windows.Forms.NumericUpDown Sobuoivang_input;
        private System.Windows.Forms.Button Sobuoivang_button;
        private System.Windows.Forms.Button Diemthi_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView LichThiView;
    }
}