
namespace QuanlyTrungtam
{
    partial class Student_ManageClass
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
            this.ID_Source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Form_Source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start_Course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Finished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewDetail_button = new System.Windows.Forms.Button();
            this.Detail_button = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Edu_Form = new System.Windows.Forms.ComboBox();
            this.Courses_Reload = new System.Windows.Forms.Button();
            this.List_SubGr = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.IDCur_Course = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Contact_CurTeacher = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Name_CurTeacher = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SobuoiVang = new System.Windows.Forms.Label();
            this.Name_CurClass = new System.Windows.Forms.Label();
            this.NameCur_Course = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DiemThi = new System.Windows.Forms.Label();
            this.DiemThi_Title = new System.Windows.Forms.Label();
            this.Thilai_title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Thilai = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Courses_View
            // 
            this.Courses_View.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Courses_View.CheckBoxes = true;
            this.Courses_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Source,
            this.Name_Source,
            this.Form_Source,
            this.Start_Course,
            this.Finished});
            this.Courses_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses_View.FullRowSelect = true;
            this.Courses_View.GridLines = true;
            this.Courses_View.HideSelection = false;
            this.Courses_View.Location = new System.Drawing.Point(22, 77);
            this.Courses_View.Margin = new System.Windows.Forms.Padding(4);
            this.Courses_View.Name = "Courses_View";
            this.Courses_View.Size = new System.Drawing.Size(650, 304);
            this.Courses_View.TabIndex = 57;
            this.Courses_View.UseCompatibleStateImageBehavior = false;
            this.Courses_View.View = System.Windows.Forms.View.Details;
            // 
            // ID_Source
            // 
            this.ID_Source.Text = "ID";
            this.ID_Source.Width = 61;
            // 
            // Name_Source
            // 
            this.Name_Source.Text = "Tên Khóa học";
            this.Name_Source.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_Source.Width = 169;
            // 
            // Form_Source
            // 
            this.Form_Source.Text = "Loại hình đào tạo";
            this.Form_Source.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Form_Source.Width = 196;
            // 
            // Start_Course
            // 
            this.Start_Course.Text = "Ngày bắt đầu";
            this.Start_Course.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Start_Course.Width = 104;
            // 
            // Finished
            // 
            this.Finished.Text = "Tốt nghiệp";
            this.Finished.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Finished.Width = 111;
            // 
            // ViewDetail_button
            // 
            this.ViewDetail_button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ViewDetail_button.BackgroundImage = global::QuanlyTrungtam.Properties.Resources._1200px_Arrow_icon_svg;
            this.ViewDetail_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewDetail_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewDetail_button.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ViewDetail_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewDetail_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDetail_button.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewDetail_button.Location = new System.Drawing.Point(690, 196);
            this.ViewDetail_button.Name = "ViewDetail_button";
            this.ViewDetail_button.Size = new System.Drawing.Size(54, 56);
            this.ViewDetail_button.TabIndex = 73;
            this.ViewDetail_button.UseVisualStyleBackColor = false;
            this.ViewDetail_button.Click += new System.EventHandler(this.ViewDetail_button_Click);
            // 
            // Detail_button
            // 
            this.Detail_button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Detail_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Detail_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.Detail_button.FlatAppearance.BorderSize = 3;
            this.Detail_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detail_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detail_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Detail_button.Location = new System.Drawing.Point(768, 351);
            this.Detail_button.Name = "Detail_button";
            this.Detail_button.Size = new System.Drawing.Size(316, 30);
            this.Detail_button.TabIndex = 83;
            this.Detail_button.Text = "Xem chi tiết";
            this.Detail_button.UseVisualStyleBackColor = false;
            this.Detail_button.Click += new System.EventHandler(this.Detail_button_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Brown;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Back.FlatAppearance.BorderSize = 5;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(22, 488);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(138, 50);
            this.Back.TabIndex = 84;
            this.Back.Text = "< Back to Menu";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Edu_Form
            // 
            this.Edu_Form.FormattingEnabled = true;
            this.Edu_Form.Items.AddRange(new object[] {
            "Tất cả"});
            this.Edu_Form.Location = new System.Drawing.Point(337, 37);
            this.Edu_Form.Name = "Edu_Form";
            this.Edu_Form.Size = new System.Drawing.Size(335, 24);
            this.Edu_Form.TabIndex = 85;
            this.Edu_Form.SelectedIndexChanged += new System.EventHandler(this.Edu_Form_SelectedIndexChanged);
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
            this.Courses_Reload.Location = new System.Drawing.Point(289, 32);
            this.Courses_Reload.Name = "Courses_Reload";
            this.Courses_Reload.Size = new System.Drawing.Size(32, 31);
            this.Courses_Reload.TabIndex = 86;
            this.Courses_Reload.UseVisualStyleBackColor = false;
            // 
            // List_SubGr
            // 
            this.List_SubGr.Location = new System.Drawing.Point(768, 77);
            this.List_SubGr.Name = "List_SubGr";
            this.List_SubGr.Size = new System.Drawing.Size(316, 268);
            this.List_SubGr.TabIndex = 87;
            this.List_SubGr.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.List_SubGr_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "ID :";
            // 
            // IDCur_Course
            // 
            this.IDCur_Course.AutoSize = true;
            this.IDCur_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCur_Course.Location = new System.Drawing.Point(58, 400);
            this.IDCur_Course.Name = "IDCur_Course";
            this.IDCur_Course.Size = new System.Drawing.Size(58, 29);
            this.IDCur_Course.TabIndex = 89;
            this.IDCur_Course.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 91;
            this.label3.Text = "Môn học : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Thilai);
            this.groupBox1.Controls.Add(this.Thilai_title);
            this.groupBox1.Controls.Add(this.DiemThi_Title);
            this.groupBox1.Controls.Add(this.DiemThi);
            this.groupBox1.Controls.Add(this.Contact_CurTeacher);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Name_CurTeacher);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SobuoiVang);
            this.groupBox1.Controls.Add(this.Name_CurClass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(183, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 138);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Informations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Contact_CurTeacher
            // 
            this.Contact_CurTeacher.AutoSize = true;
            this.Contact_CurTeacher.Location = new System.Drawing.Point(471, 87);
            this.Contact_CurTeacher.Name = "Contact_CurTeacher";
            this.Contact_CurTeacher.Size = new System.Drawing.Size(170, 18);
            this.Contact_CurTeacher.TabIndex = 100;
            this.Contact_CurTeacher.Text = "__________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(377, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 99;
            this.label9.Text = "Contact      :";
            // 
            // Name_CurTeacher
            // 
            this.Name_CurTeacher.AutoSize = true;
            this.Name_CurTeacher.Location = new System.Drawing.Point(471, 42);
            this.Name_CurTeacher.Name = "Name_CurTeacher";
            this.Name_CurTeacher.Size = new System.Drawing.Size(170, 18);
            this.Name_CurTeacher.TabIndex = 98;
            this.Name_CurTeacher.Text = "__________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 97;
            this.label7.Text = "Giảng viên : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 96;
            this.label6.Text = "00";
            // 
            // SobuoiVang
            // 
            this.SobuoiVang.AutoSize = true;
            this.SobuoiVang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SobuoiVang.Location = new System.Drawing.Point(48, 87);
            this.SobuoiVang.Name = "SobuoiVang";
            this.SobuoiVang.Size = new System.Drawing.Size(103, 17);
            this.SobuoiVang.TabIndex = 95;
            this.SobuoiVang.Text = "Số buổi vắng : ";
            // 
            // Name_CurClass
            // 
            this.Name_CurClass.AutoSize = true;
            this.Name_CurClass.Location = new System.Drawing.Point(125, 42);
            this.Name_CurClass.Name = "Name_CurClass";
            this.Name_CurClass.Size = new System.Drawing.Size(197, 18);
            this.Name_CurClass.TabIndex = 92;
            this.Name_CurClass.Text = "_____________________";
            // 
            // NameCur_Course
            // 
            this.NameCur_Course.AutoSize = true;
            this.NameCur_Course.Location = new System.Drawing.Point(23, 444);
            this.NameCur_Course.Name = "NameCur_Course";
            this.NameCur_Course.Size = new System.Drawing.Size(0, 17);
            this.NameCur_Course.TabIndex = 93;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UVN Tin Tuc Hep", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 35);
            this.label10.TabIndex = 94;
            this.label10.Text = "CÁC KHÓA HỌC CỦA BẠN";
            // 
            // DiemThi
            // 
            this.DiemThi.AutoSize = true;
            this.DiemThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiemThi.Location = new System.Drawing.Point(768, 44);
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.Size = new System.Drawing.Size(58, 29);
            this.DiemThi.TabIndex = 95;
            this.DiemThi.Text = "000";
            // 
            // DiemThi_Title
            // 
            this.DiemThi_Title.AutoSize = true;
            this.DiemThi_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiemThi_Title.Location = new System.Drawing.Point(709, 27);
            this.DiemThi_Title.Name = "DiemThi_Title";
            this.DiemThi_Title.Size = new System.Drawing.Size(67, 17);
            this.DiemThi_Title.TabIndex = 95;
            this.DiemThi_Title.Text = "Điểm thi :";
            // 
            // Thilai_title
            // 
            this.Thilai_title.AutoSize = true;
            this.Thilai_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thilai_title.Location = new System.Drawing.Point(709, 89);
            this.Thilai_title.Name = "Thilai_title";
            this.Thilai_title.Size = new System.Drawing.Size(93, 17);
            this.Thilai_title.TabIndex = 101;
            this.Thilai_title.Text = "Số lần thi lại :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(768, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 30);
            this.button1.TabIndex = 95;
            this.button1.Text = "Xem lịch thi";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Thilai
            // 
            this.Thilai.AutoSize = true;
            this.Thilai.Location = new System.Drawing.Point(800, 89);
            this.Thilai.Name = "Thilai";
            this.Thilai.Size = new System.Drawing.Size(26, 18);
            this.Thilai.TabIndex = 102;
            this.Thilai.Text = "00";
            // 
            // Student_ManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NameCur_Course);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDCur_Course);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.List_SubGr);
            this.Controls.Add(this.Courses_Reload);
            this.Controls.Add(this.Edu_Form);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Detail_button);
            this.Controls.Add(this.ViewDetail_button);
            this.Controls.Add(this.Courses_View);
            this.Name = "Student_ManageClass";
            this.Text = "Student_ManageClass";
            this.Load += new System.EventHandler(this.Student_ManageClass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Courses_View;
        private System.Windows.Forms.ColumnHeader ID_Source;
        private System.Windows.Forms.ColumnHeader Name_Source;
        private System.Windows.Forms.ColumnHeader Form_Source;
        private System.Windows.Forms.ColumnHeader Start_Course;
        private System.Windows.Forms.ColumnHeader Finished;
        private System.Windows.Forms.Button ViewDetail_button;
        private System.Windows.Forms.Button Detail_button;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox Edu_Form;
        private System.Windows.Forms.Button Courses_Reload;
        private System.Windows.Forms.TreeView List_SubGr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDCur_Course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameCur_Course;
        private System.Windows.Forms.Label Name_CurClass;
        private System.Windows.Forms.Label Contact_CurTeacher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Name_CurTeacher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SobuoiVang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DiemThi_Title;
        private System.Windows.Forms.Label DiemThi;
        private System.Windows.Forms.Label Thilai;
        private System.Windows.Forms.Label Thilai_title;
        private System.Windows.Forms.Button button1;
    }
}