
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
            this.Courses_View = new System.Windows.Forms.ListView();
            this.ID_Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email_Teacger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT_Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Major = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MajorText = new System.Windows.Forms.ComboBox();
            this.Reload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterMonth = new System.Windows.Forms.ComboBox();
            this.FilterCourse = new System.Windows.Forms.ComboBox();
            this.FilterYear = new System.Windows.Forms.ComboBox();
            this.GrantButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Detail_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Courses_View
            // 
            this.Courses_View.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Courses_View.CheckBoxes = true;
            this.Courses_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Teacher,
            this.Name_Teacher,
            this.Email_Teacger,
            this.SDT_Teacher,
            this.Major});
            this.Courses_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses_View.FullRowSelect = true;
            this.Courses_View.GridLines = true;
            this.Courses_View.HideSelection = false;
            this.Courses_View.Location = new System.Drawing.Point(22, 70);
            this.Courses_View.Margin = new System.Windows.Forms.Padding(4);
            this.Courses_View.Name = "Courses_View";
            this.Courses_View.Size = new System.Drawing.Size(650, 304);
            this.Courses_View.TabIndex = 58;
            this.Courses_View.UseCompatibleStateImageBehavior = false;
            this.Courses_View.View = System.Windows.Forms.View.Details;
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
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(765, 70);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(402, 371);
            this.listView1.TabIndex = 96;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.MajorText.Location = new System.Drawing.Point(259, 406);
            this.MajorText.Name = "MajorText";
            this.MajorText.Size = new System.Drawing.Size(277, 24);
            this.MajorText.TabIndex = 97;
            this.MajorText.SelectedIndexChanged += new System.EventHandler(this.MajorText_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 386);
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
            "12",
            "All"});
            this.FilterMonth.Location = new System.Drawing.Point(765, 39);
            this.FilterMonth.Name = "FilterMonth";
            this.FilterMonth.Size = new System.Drawing.Size(65, 24);
            this.FilterMonth.TabIndex = 100;
            // 
            // FilterCourse
            // 
            this.FilterCourse.FormattingEnabled = true;
            this.FilterCourse.Location = new System.Drawing.Point(925, 39);
            this.FilterCourse.Name = "FilterCourse";
            this.FilterCourse.Size = new System.Drawing.Size(242, 24);
            this.FilterCourse.TabIndex = 101;
            // 
            // FilterYear
            // 
            this.FilterYear.FormattingEnabled = true;
            this.FilterYear.Items.AddRange(new object[] {
            "All",
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
            // 
            // GrantButton
            // 
            this.GrantButton.BackColor = System.Drawing.Color.Khaki;
            this.GrantButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrantButton.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.GrantButton.FlatAppearance.BorderSize = 3;
            this.GrantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrantButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GrantButton.Location = new System.Drawing.Point(679, 198);
            this.GrantButton.Name = "GrantButton";
            this.GrantButton.Size = new System.Drawing.Size(79, 62);
            this.GrantButton.TabIndex = 103;
            this.GrantButton.Text = "GRANT";
            this.GrantButton.UseVisualStyleBackColor = false;
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
            this.Back.Location = new System.Drawing.Point(22, 391);
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
            this.Detail_button.Location = new System.Drawing.Point(555, 391);
            this.Detail_button.Name = "Detail_button";
            this.Detail_button.Size = new System.Drawing.Size(117, 50);
            this.Detail_button.TabIndex = 105;
            this.Detail_button.Text = "Add";
            this.Detail_button.UseVisualStyleBackColor = false;
            this.Detail_button.Click += new System.EventHandler(this.Detail_button_Click);
            // 
            // Teacher_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1196, 460);
            this.Controls.Add(this.Detail_button);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.GrantButton);
            this.Controls.Add(this.FilterYear);
            this.Controls.Add(this.FilterCourse);
            this.Controls.Add(this.FilterMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.MajorText);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Courses_View);
            this.Name = "Teacher_Manage";
            this.Text = "Teacher_Manage";
            this.Load += new System.EventHandler(this.Teacher_Manage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Courses_View;
        private System.Windows.Forms.ColumnHeader ID_Teacher;
        private System.Windows.Forms.ColumnHeader Name_Teacher;
        private System.Windows.Forms.ColumnHeader Email_Teacger;
        private System.Windows.Forms.ColumnHeader SDT_Teacher;
        private System.Windows.Forms.ColumnHeader Major;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView1;
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
    }
}