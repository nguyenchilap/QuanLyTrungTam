
namespace QuanlyTrungtam
{
    partial class Teacher_Manage
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
            this.ID_Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email_Teacger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT_Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Major = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.ClassView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MajorText = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterMonth = new System.Windows.Forms.ComboBox();
            this.FilterCourse = new System.Windows.Forms.ComboBox();
            this.FilterYear = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.Detail_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Swap_LopHoc = new System.Windows.Forms.Button();
            this.Swap_LichThi = new System.Windows.Forms.Button();
            this.GrantButton = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // EmployeeView
            // 
            this.EmployeeView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EmployeeView.CheckBoxes = true;
            this.EmployeeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Teacher,
            this.Name_Teacher,
            this.Email_Teacger,
            this.SDT_Teacher,
            this.Major});
            this.EmployeeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeView.FullRowSelect = true;
            this.EmployeeView.GridLines = true;
            this.EmployeeView.HideSelection = false;
            this.EmployeeView.Location = new System.Drawing.Point(22, 70);
            this.EmployeeView.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.Size = new System.Drawing.Size(650, 304);
            this.EmployeeView.TabIndex = 58;
            this.EmployeeView.UseCompatibleStateImageBehavior = false;
            this.EmployeeView.View = System.Windows.Forms.View.Details;
            // 
            // ID_Teacher
            // 
            this.ID_Teacher.Text = "Mã GV";
            this.ID_Teacher.Width = 61;
            // 
            // Name_Teacher
            // 
            this.Name_Teacher.Text = "Tên GV";
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
            this.Major.Text = "Chuyên môn";
            this.Major.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Major.Width = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UVN Tin Tuc Hep", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 35);
            this.label10.TabIndex = 95;
            this.label10.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // ClassView
            // 
            this.ClassView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClassView.CheckBoxes = true;
            this.ClassView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ClassView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassView.FullRowSelect = true;
            this.ClassView.GridLines = true;
            this.ClassView.HideSelection = false;
            this.ClassView.Location = new System.Drawing.Point(765, 70);
            this.ClassView.Margin = new System.Windows.Forms.Padding(4);
            this.ClassView.Name = "ClassView";
            this.ClassView.Size = new System.Drawing.Size(402, 351);
            this.ClassView.TabIndex = 96;
            this.ClassView.UseCompatibleStateImageBehavior = false;
            this.ClassView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Khóa học";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Môn học ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "GV giảng dạy";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 111;
            // 
            // MajorText
            // 
            this.MajorText.FormattingEnabled = true;
            this.MajorText.Location = new System.Drawing.Point(275, 411);
            this.MajorText.Name = "MajorText";
            this.MajorText.Size = new System.Drawing.Size(225, 24);
            this.MajorText.TabIndex = 97;
            this.MajorText.SelectedIndexChanged += new System.EventHandler(this.MajorText_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Chuyên môn";
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
            this.FilterMonth.Location = new System.Drawing.Point(765, 39);
            this.FilterMonth.Name = "FilterMonth";
            this.FilterMonth.Size = new System.Drawing.Size(65, 24);
            this.FilterMonth.TabIndex = 100;
            this.FilterMonth.SelectedIndexChanged += new System.EventHandler(this.FilterMonth_SelectedIndexChanged);
            // 
            // FilterCourse
            // 
            this.FilterCourse.FormattingEnabled = true;
            this.FilterCourse.Location = new System.Drawing.Point(925, 39);
            this.FilterCourse.Name = "FilterCourse";
            this.FilterCourse.Size = new System.Drawing.Size(242, 24);
            this.FilterCourse.TabIndex = 101;
            this.FilterCourse.SelectedIndexChanged += new System.EventHandler(this.FilterCourse_SelectedIndexChanged);
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
            this.FilterYear.Location = new System.Drawing.Point(836, 39);
            this.FilterYear.Name = "FilterYear";
            this.FilterYear.Size = new System.Drawing.Size(83, 24);
            this.FilterYear.TabIndex = 102;
            this.FilterYear.SelectedIndexChanged += new System.EventHandler(this.FilterYear_SelectedIndexChanged);
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
            this.Back.Location = new System.Drawing.Point(22, 416);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(138, 50);
            this.Back.TabIndex = 104;
            this.Back.Text = "< Back to Menu";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Detail_button
            // 
            this.Detail_button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Detail_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Detail_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.Detail_button.FlatAppearance.BorderSize = 3;
            this.Detail_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detail_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detail_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Detail_button.Location = new System.Drawing.Point(535, 428);
            this.Detail_button.Name = "Detail_button";
            this.Detail_button.Size = new System.Drawing.Size(137, 38);
            this.Detail_button.TabIndex = 105;
            this.Detail_button.Text = "Add";
            this.Detail_button.UseVisualStyleBackColor = false;
            this.Detail_button.Click += new System.EventHandler(this.Detail_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(687, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 106;
            this.label2.Text = "GRANT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(535, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 38);
            this.button1.TabIndex = 107;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Swap_LopHoc
            // 
            this.Swap_LopHoc.BackColor = System.Drawing.Color.Turquoise;
            this.Swap_LopHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Swap_LopHoc.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Swap_LopHoc.FlatAppearance.BorderSize = 3;
            this.Swap_LopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Swap_LopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Swap_LopHoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Swap_LopHoc.Location = new System.Drawing.Point(765, 428);
            this.Swap_LopHoc.Name = "Swap_LopHoc";
            this.Swap_LopHoc.Size = new System.Drawing.Size(204, 38);
            this.Swap_LopHoc.TabIndex = 108;
            this.Swap_LopHoc.Text = "Lớp học";
            this.Swap_LopHoc.UseVisualStyleBackColor = false;
            this.Swap_LopHoc.Click += new System.EventHandler(this.Swap_LopHoc_Click);
            // 
            // Swap_LichThi
            // 
            this.Swap_LichThi.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Swap_LichThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Swap_LichThi.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.Swap_LichThi.FlatAppearance.BorderSize = 3;
            this.Swap_LichThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Swap_LichThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Swap_LichThi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Swap_LichThi.Location = new System.Drawing.Point(975, 428);
            this.Swap_LichThi.Name = "Swap_LichThi";
            this.Swap_LichThi.Size = new System.Drawing.Size(192, 38);
            this.Swap_LichThi.TabIndex = 109;
            this.Swap_LichThi.Text = "Lịch thi";
            this.Swap_LichThi.UseVisualStyleBackColor = false;
            this.Swap_LichThi.Click += new System.EventHandler(this.Swap_LichThi_Click);
            // 
            // GrantButton
            // 
            this.GrantButton.BackColor = System.Drawing.Color.CadetBlue;
            this.GrantButton.BackgroundImage = global::QuanlyTrungtam.Properties.Resources._1200px_Arrow_icon_svg;
            this.GrantButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GrantButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrantButton.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.GrantButton.FlatAppearance.BorderSize = 3;
            this.GrantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrantButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GrantButton.Location = new System.Drawing.Point(690, 207);
            this.GrantButton.Name = "GrantButton";
            this.GrantButton.Size = new System.Drawing.Size(54, 54);
            this.GrantButton.TabIndex = 103;
            this.GrantButton.UseVisualStyleBackColor = false;
            this.GrantButton.Click += new System.EventHandler(this.GrantButton_Click_1);
            // 
            // Reload
            // 
            this.Reload.BackColor = System.Drawing.Color.AliceBlue;
            this.Reload.BackgroundImage = global::QuanlyTrungtam.Properties.Resources.redo_solid;
            this.Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reload.Location = new System.Drawing.Point(240, 24);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(32, 31);
            this.Reload.TabIndex = 98;
            this.Reload.UseVisualStyleBackColor = false;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thời gian";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Teacher_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1185, 478);
            this.Controls.Add(this.Swap_LichThi);
            this.Controls.Add(this.Swap_LopHoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Detail_button);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.GrantButton);
            this.Controls.Add(this.FilterYear);
            this.Controls.Add(this.FilterCourse);
            this.Controls.Add(this.FilterMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.MajorText);
            this.Controls.Add(this.ClassView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EmployeeView);
            this.Name = "Teacher_Manage";
            this.Text = "Teacher_Manage";
            this.Load += new System.EventHandler(this.Teacher_Manage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView EmployeeView;
        private System.Windows.Forms.ColumnHeader ID_Teacher;
        private System.Windows.Forms.ColumnHeader Name_Teacher;
        private System.Windows.Forms.ColumnHeader Email_Teacger;
        private System.Windows.Forms.ColumnHeader SDT_Teacher;
        private System.Windows.Forms.ColumnHeader Major;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView ClassView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox MajorText;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FilterMonth;
        private System.Windows.Forms.ComboBox FilterCourse;
        private System.Windows.Forms.ComboBox FilterYear;
        private System.Windows.Forms.Button GrantButton;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Detail_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Swap_LopHoc;
        private System.Windows.Forms.Button Swap_LichThi;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}