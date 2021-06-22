
namespace QuanlyTrungtam
{
    partial class StudentManager_Classes
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
            this.Course_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Course_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Course_Start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Course_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edu_Form = new System.Windows.Forms.ComboBox();
            this.StudentView = new System.Windows.Forms.ListView();
            this.Student_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student_Mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewClassList = new System.Windows.Forms.Button();
            this.ViewStudentList = new System.Windows.Forms.Button();
            this.List_SubGr = new System.Windows.Forms.TreeView();
            this.CurCourse_Name = new System.Windows.Forms.TextBox();
            this.CurCourse_ID = new System.Windows.Forms.TextBox();
            this.CurSub_Name = new System.Windows.Forms.TextBox();
            this.CurSub_ID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.FilterMonth = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.YearFilter = new System.Windows.Forms.ComboBox();
            this.Courses_Reload = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Courses_View
            // 
            this.Courses_View.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Courses_View.CheckBoxes = true;
            this.Courses_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Course_ID,
            this.Course_Name,
            this.Course_Start,
            this.Course_Type});
            this.Courses_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses_View.FullRowSelect = true;
            this.Courses_View.GridLines = true;
            this.Courses_View.HideSelection = false;
            this.Courses_View.Location = new System.Drawing.Point(30, 53);
            this.Courses_View.Margin = new System.Windows.Forms.Padding(4);
            this.Courses_View.Name = "Courses_View";
            this.Courses_View.Size = new System.Drawing.Size(513, 307);
            this.Courses_View.TabIndex = 32;
            this.Courses_View.UseCompatibleStateImageBehavior = false;
            this.Courses_View.View = System.Windows.Forms.View.Details;
            // 
            // Course_ID
            // 
            this.Course_ID.Text = "Mã KH";
            this.Course_ID.Width = 66;
            // 
            // Course_Name
            // 
            this.Course_Name.Text = "Tên Khóa học";
            this.Course_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Course_Name.Width = 185;
            // 
            // Course_Start
            // 
            this.Course_Start.Text = "Ngày Bắt đầu";
            this.Course_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Course_Start.Width = 110;
            // 
            // Course_Type
            // 
            this.Course_Type.Text = "Loại Hình Đào Tạo";
            this.Course_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Course_Type.Width = 148;
            // 
            // Edu_Form
            // 
            this.Edu_Form.FormattingEnabled = true;
            this.Edu_Form.Items.AddRange(new object[] {
            "Tất cả"});
            this.Edu_Form.Location = new System.Drawing.Point(233, 22);
            this.Edu_Form.Name = "Edu_Form";
            this.Edu_Form.Size = new System.Drawing.Size(310, 24);
            this.Edu_Form.TabIndex = 45;
            this.Edu_Form.SelectedIndexChanged += new System.EventHandler(this.Edu_Form_SelectedIndexChanged);
            // 
            // StudentView
            // 
            this.StudentView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StudentView.CheckBoxes = true;
            this.StudentView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Student_ID,
            this.Student_Name,
            this.Student_Mark});
            this.StudentView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentView.FullRowSelect = true;
            this.StudentView.GridLines = true;
            this.StudentView.HideSelection = false;
            this.StudentView.Location = new System.Drawing.Point(903, 53);
            this.StudentView.Margin = new System.Windows.Forms.Padding(4);
            this.StudentView.Name = "StudentView";
            this.StudentView.Size = new System.Drawing.Size(395, 307);
            this.StudentView.TabIndex = 46;
            this.StudentView.UseCompatibleStateImageBehavior = false;
            this.StudentView.View = System.Windows.Forms.View.Details;
            // 
            // Student_ID
            // 
            this.Student_ID.Text = "Mã Học viên";
            this.Student_ID.Width = 102;
            // 
            // Student_Name
            // 
            this.Student_Name.Text = "Tên Học viên";
            this.Student_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Student_Name.Width = 192;
            // 
            // Student_Mark
            // 
            this.Student_Mark.Text = "Điểm thi";
            this.Student_Mark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Student_Mark.Width = 93;
            // 
            // ViewClassList
            // 
            this.ViewClassList.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ViewClassList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewClassList.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.ViewClassList.FlatAppearance.BorderSize = 2;
            this.ViewClassList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewClassList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewClassList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViewClassList.Location = new System.Drawing.Point(566, 11);
            this.ViewClassList.Name = "ViewClassList";
            this.ViewClassList.Size = new System.Drawing.Size(310, 35);
            this.ViewClassList.TabIndex = 55;
            this.ViewClassList.Text = "View Details >>";
            this.ViewClassList.UseVisualStyleBackColor = false;
            this.ViewClassList.Click += new System.EventHandler(this.ViewClassList_Click);
            // 
            // ViewStudentList
            // 
            this.ViewStudentList.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ViewStudentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewStudentList.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.ViewStudentList.FlatAppearance.BorderSize = 2;
            this.ViewStudentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudentList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViewStudentList.Location = new System.Drawing.Point(903, 11);
            this.ViewStudentList.Name = "ViewStudentList";
            this.ViewStudentList.Size = new System.Drawing.Size(395, 35);
            this.ViewStudentList.TabIndex = 56;
            this.ViewStudentList.Text = "View Details >>";
            this.ViewStudentList.UseVisualStyleBackColor = false;
            this.ViewStudentList.Click += new System.EventHandler(this.ViewStudentList_Click);
            // 
            // List_SubGr
            // 
            this.List_SubGr.Location = new System.Drawing.Point(566, 53);
            this.List_SubGr.Name = "List_SubGr";
            this.List_SubGr.Size = new System.Drawing.Size(310, 307);
            this.List_SubGr.TabIndex = 57;
            this.List_SubGr.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.List_SubGr_AfterSelect);
            // 
            // CurCourse_Name
            // 
            this.CurCourse_Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurCourse_Name.Location = new System.Drawing.Point(632, 376);
            this.CurCourse_Name.Name = "CurCourse_Name";
            this.CurCourse_Name.ReadOnly = true;
            this.CurCourse_Name.Size = new System.Drawing.Size(244, 22);
            this.CurCourse_Name.TabIndex = 58;
            this.CurCourse_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurCourse_ID
            // 
            this.CurCourse_ID.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurCourse_ID.Location = new System.Drawing.Point(566, 376);
            this.CurCourse_ID.Name = "CurCourse_ID";
            this.CurCourse_ID.ReadOnly = true;
            this.CurCourse_ID.Size = new System.Drawing.Size(60, 22);
            this.CurCourse_ID.TabIndex = 59;
            this.CurCourse_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurSub_Name
            // 
            this.CurSub_Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurSub_Name.Location = new System.Drawing.Point(981, 376);
            this.CurSub_Name.Name = "CurSub_Name";
            this.CurSub_Name.ReadOnly = true;
            this.CurSub_Name.Size = new System.Drawing.Size(317, 22);
            this.CurSub_Name.TabIndex = 60;
            this.CurSub_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurSub_ID
            // 
            this.CurSub_ID.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurSub_ID.Location = new System.Drawing.Point(903, 376);
            this.CurSub_ID.Name = "CurSub_ID";
            this.CurSub_ID.ReadOnly = true;
            this.CurSub_ID.Size = new System.Drawing.Size(72, 22);
            this.CurSub_ID.TabIndex = 61;
            this.CurSub_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 445);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 18);
            this.label15.TabIndex = 69;
            this.label15.Text = "Filter by Month:";
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
            this.FilterMonth.Location = new System.Drawing.Point(29, 466);
            this.FilterMonth.Name = "FilterMonth";
            this.FilterMonth.Size = new System.Drawing.Size(106, 24);
            this.FilterMonth.TabIndex = 68;
            this.FilterMonth.SelectedIndexChanged += new System.EventHandler(this.FilterMonth_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 67;
            this.label9.Text = "Filter by Year:";
            // 
            // YearFilter
            // 
            this.YearFilter.FormattingEnabled = true;
            this.YearFilter.Items.AddRange(new object[] {
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
            "2030"});
            this.YearFilter.Location = new System.Drawing.Point(29, 398);
            this.YearFilter.Name = "YearFilter";
            this.YearFilter.Size = new System.Drawing.Size(106, 24);
            this.YearFilter.TabIndex = 66;
            this.YearFilter.SelectedIndexChanged += new System.EventHandler(this.YearFilter_SelectedIndexChanged);
            // 
            // Courses_Reload
            // 
            this.Courses_Reload.BackColor = System.Drawing.Color.AliceBlue;
            this.Courses_Reload.BackgroundImage = global::QuanlyTrungtam.Properties.Resources.redo_solid;
            this.Courses_Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Courses_Reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Courses_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Courses_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses_Reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Courses_Reload.Location = new System.Drawing.Point(195, 17);
            this.Courses_Reload.Name = "Courses_Reload";
            this.Courses_Reload.Size = new System.Drawing.Size(32, 31);
            this.Courses_Reload.TabIndex = 70;
            this.Courses_Reload.UseVisualStyleBackColor = false;
            this.Courses_Reload.Click += new System.EventHandler(this.Courses_Reload_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.Brown;
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Back_button.FlatAppearance.BorderSize = 3;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Back_button.Location = new System.Drawing.Point(29, 521);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(126, 44);
            this.Back_button.TabIndex = 71;
            this.Back_button.Text = "< Back to Menu";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UVN Tin Tuc Hep", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 35);
            this.label10.TabIndex = 72;
            this.label10.Text = "KHÓA HỌC";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(967, 448);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(92, 22);
            this.numericUpDown1.TabIndex = 73;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(18, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(84, 22);
            this.textBox1.TabIndex = 74;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "Số lần thi lại";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(566, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 144);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả học phần";
            // 
            // StudentManager_Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1308, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Courses_Reload);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.FilterMonth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.YearFilter);
            this.Controls.Add(this.CurSub_ID);
            this.Controls.Add(this.CurSub_Name);
            this.Controls.Add(this.CurCourse_ID);
            this.Controls.Add(this.CurCourse_Name);
            this.Controls.Add(this.List_SubGr);
            this.Controls.Add(this.ViewStudentList);
            this.Controls.Add(this.ViewClassList);
            this.Controls.Add(this.StudentView);
            this.Controls.Add(this.Edu_Form);
            this.Controls.Add(this.Courses_View);
            this.Name = "StudentManager_Classes";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.Manager_Classes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView Courses_View;
        private System.Windows.Forms.ColumnHeader Course_ID;
        private System.Windows.Forms.ColumnHeader Course_Name;
        private System.Windows.Forms.ColumnHeader Course_Start;
        private System.Windows.Forms.ComboBox Edu_Form;
        private System.Windows.Forms.ListView StudentView;
        private System.Windows.Forms.ColumnHeader Student_ID;
        private System.Windows.Forms.ColumnHeader Student_Name;
        private System.Windows.Forms.ColumnHeader Student_Mark;
        private System.Windows.Forms.Button ViewClassList;
        private System.Windows.Forms.Button ViewStudentList;
        private System.Windows.Forms.TreeView List_SubGr;
        private System.Windows.Forms.ColumnHeader Course_Type;
        private System.Windows.Forms.TextBox CurCourse_Name;
        private System.Windows.Forms.TextBox CurCourse_ID;
        private System.Windows.Forms.TextBox CurSub_Name;
        private System.Windows.Forms.TextBox CurSub_ID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox FilterMonth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox YearFilter;
        private System.Windows.Forms.Button Courses_Reload;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}