
namespace QuanlyTrungtam
{
    partial class StudentManager_Approve
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
            this.DonDK_View = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_HV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Course_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Course_Tuition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student_Tuition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.Edu_Form = new System.Windows.Forms.ComboBox();
            this.KhoaHoc_View = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HocVien_view = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Back_button = new System.Windows.Forms.Button();
            this.Month_Filter = new System.Windows.Forms.ComboBox();
            this.Year_Filter = new System.Windows.Forms.ComboBox();
            this.ViewClassList = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Student_ID = new System.Windows.Forms.Label();
            this.Student_Name = new System.Windows.Forms.Label();
            this.Student_SDT = new System.Windows.Forms.Label();
            this.Student_Email = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.CheckPaid = new System.Windows.Forms.ComboBox();
            this.Courses_Reload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DonDK_View
            // 
            this.DonDK_View.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DonDK_View.CheckBoxes = true;
            this.DonDK_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name_HV,
            this.Course_Name,
            this.Course_Tuition,
            this.Student_Tuition});
            this.DonDK_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonDK_View.FullRowSelect = true;
            this.DonDK_View.GridLines = true;
            this.DonDK_View.HideSelection = false;
            this.DonDK_View.Location = new System.Drawing.Point(29, 75);
            this.DonDK_View.Margin = new System.Windows.Forms.Padding(4);
            this.DonDK_View.Name = "DonDK_View";
            this.DonDK_View.Size = new System.Drawing.Size(650, 307);
            this.DonDK_View.TabIndex = 33;
            this.DonDK_View.UseCompatibleStateImageBehavior = false;
            this.DonDK_View.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Mã Học viên";
            this.ID.Width = 98;
            // 
            // Name_HV
            // 
            this.Name_HV.Text = "Tên Học viên";
            this.Name_HV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_HV.Width = 171;
            // 
            // Course_Name
            // 
            this.Course_Name.Text = "Tên khóa học";
            this.Course_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Course_Name.Width = 154;
            // 
            // Course_Tuition
            // 
            this.Course_Tuition.Text = "Học phí ";
            this.Course_Tuition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Course_Tuition.Width = 113;
            // 
            // Student_Tuition
            // 
            this.Student_Tuition.Text = "Đóng học phí";
            this.Student_Tuition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Student_Tuition.Width = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UVN Tin Tuc Hep", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 35);
            this.label10.TabIndex = 34;
            this.label10.Text = "ĐƠN ĐĂNG KÍ";
            // 
            // Edu_Form
            // 
            this.Edu_Form.FormattingEnabled = true;
            this.Edu_Form.Location = new System.Drawing.Point(362, 36);
            this.Edu_Form.Name = "Edu_Form";
            this.Edu_Form.Size = new System.Drawing.Size(317, 24);
            this.Edu_Form.TabIndex = 35;
            this.Edu_Form.SelectedIndexChanged += new System.EventHandler(this.Edu_Form_SelectedIndexChanged);
            // 
            // KhoaHoc_View
            // 
            this.KhoaHoc_View.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.KhoaHoc_View.CheckBoxes = true;
            this.KhoaHoc_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.KhoaHoc_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoaHoc_View.FullRowSelect = true;
            this.KhoaHoc_View.GridLines = true;
            this.KhoaHoc_View.HideSelection = false;
            this.KhoaHoc_View.Location = new System.Drawing.Point(701, 36);
            this.KhoaHoc_View.Margin = new System.Windows.Forms.Padding(4);
            this.KhoaHoc_View.Name = "KhoaHoc_View";
            this.KhoaHoc_View.Size = new System.Drawing.Size(299, 218);
            this.KhoaHoc_View.TabIndex = 72;
            this.KhoaHoc_View.UseCompatibleStateImageBehavior = false;
            this.KhoaHoc_View.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã KH";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Khóa";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 171;
            // 
            // HocVien_view
            // 
            this.HocVien_view.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.HocVien_view.CheckBoxes = true;
            this.HocVien_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.HocVien_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HocVien_view.FullRowSelect = true;
            this.HocVien_view.GridLines = true;
            this.HocVien_view.HideSelection = false;
            this.HocVien_view.Location = new System.Drawing.Point(701, 296);
            this.HocVien_view.Margin = new System.Windows.Forms.Padding(4);
            this.HocVien_view.Name = "HocVien_view";
            this.HocVien_view.Size = new System.Drawing.Size(299, 244);
            this.HocVien_view.TabIndex = 74;
            this.HocVien_view.UseCompatibleStateImageBehavior = false;
            this.HocVien_view.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã HV";
            this.columnHeader3.Width = 62;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Học viên";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 171;
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
            this.Back_button.Location = new System.Drawing.Point(29, 499);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(126, 44);
            this.Back_button.TabIndex = 75;
            this.Back_button.Text = "< Back to Menu";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Month_Filter
            // 
            this.Month_Filter.FormattingEnabled = true;
            this.Month_Filter.Location = new System.Drawing.Point(29, 405);
            this.Month_Filter.Name = "Month_Filter";
            this.Month_Filter.Size = new System.Drawing.Size(126, 24);
            this.Month_Filter.TabIndex = 76;
            this.Month_Filter.SelectedIndexChanged += new System.EventHandler(this.Month_Filter_SelectedIndexChanged);
            // 
            // Year_Filter
            // 
            this.Year_Filter.FormattingEnabled = true;
            this.Year_Filter.Location = new System.Drawing.Point(29, 453);
            this.Year_Filter.Name = "Year_Filter";
            this.Year_Filter.Size = new System.Drawing.Size(126, 24);
            this.Year_Filter.TabIndex = 77;
            this.Year_Filter.SelectedIndexChanged += new System.EventHandler(this.Year_Filter_SelectedIndexChanged);
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
            this.ViewClassList.Location = new System.Drawing.Point(523, 505);
            this.ViewClassList.Name = "ViewClassList";
            this.ViewClassList.Size = new System.Drawing.Size(156, 35);
            this.ViewClassList.TabIndex = 79;
            this.ViewClassList.Text = "<< View Details";
            this.ViewClassList.UseVisualStyleBackColor = false;
            this.ViewClassList.Click += new System.EventHandler(this.ViewClassList_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(523, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 35);
            this.button2.TabIndex = 80;
            this.button2.Text = "Approve >>";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Mã Học viên : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 83;
            this.label3.Text = "SĐT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Email :";
            // 
            // Student_ID
            // 
            this.Student_ID.AutoSize = true;
            this.Student_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_ID.ForeColor = System.Drawing.Color.MintCream;
            this.Student_ID.Location = new System.Drawing.Point(327, 398);
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Size = new System.Drawing.Size(39, 20);
            this.Student_ID.TabIndex = 85;
            this.Student_ID.Text = "000";
            // 
            // Student_Name
            // 
            this.Student_Name.AutoSize = true;
            this.Student_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Name.ForeColor = System.Drawing.Color.MintCream;
            this.Student_Name.Location = new System.Drawing.Point(270, 434);
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Size = new System.Drawing.Size(143, 18);
            this.Student_Name.TabIndex = 86;
            this.Student_Name.Text = "_______________";
            // 
            // Student_SDT
            // 
            this.Student_SDT.AutoSize = true;
            this.Student_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_SDT.ForeColor = System.Drawing.Color.MintCream;
            this.Student_SDT.Location = new System.Drawing.Point(273, 472);
            this.Student_SDT.Name = "Student_SDT";
            this.Student_SDT.Size = new System.Drawing.Size(143, 18);
            this.Student_SDT.TabIndex = 87;
            this.Student_SDT.Text = "_______________";
            // 
            // Student_Email
            // 
            this.Student_Email.AutoSize = true;
            this.Student_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Email.ForeColor = System.Drawing.Color.MintCream;
            this.Student_Email.Location = new System.Drawing.Point(273, 512);
            this.Student_Email.Name = "Student_Email";
            this.Student_Email.Size = new System.Drawing.Size(143, 18);
            this.Student_Email.TabIndex = 88;
            this.Student_Email.Text = "_______________";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(523, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 35);
            this.button3.TabIndex = 89;
            this.button3.Text = "Paid";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CheckPaid
            // 
            this.CheckPaid.FormattingEnabled = true;
            this.CheckPaid.Items.AddRange(new object[] {
            "Đã đóng",
            "Chưa đóng",
            "Tất cả"});
            this.CheckPaid.Location = new System.Drawing.Point(226, 36);
            this.CheckPaid.Name = "CheckPaid";
            this.CheckPaid.Size = new System.Drawing.Size(130, 24);
            this.CheckPaid.TabIndex = 90;
            this.CheckPaid.SelectedIndexChanged += new System.EventHandler(this.CheckPaid_SelectedIndexChanged);
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
            this.Courses_Reload.Location = new System.Drawing.Point(184, 31);
            this.Courses_Reload.Name = "Courses_Reload";
            this.Courses_Reload.Size = new System.Drawing.Size(32, 31);
            this.Courses_Reload.TabIndex = 71;
            this.Courses_Reload.UseVisualStyleBackColor = false;
            this.Courses_Reload.Click += new System.EventHandler(this.Courses_Reload_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(701, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 28);
            this.button1.TabIndex = 73;
            this.button1.Text = "View Detail";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentManager_Approve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1011, 552);
            this.Controls.Add(this.CheckPaid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Student_Email);
            this.Controls.Add(this.Student_SDT);
            this.Controls.Add(this.Student_Name);
            this.Controls.Add(this.Student_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ViewClassList);
            this.Controls.Add(this.Year_Filter);
            this.Controls.Add(this.Month_Filter);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.HocVien_view);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KhoaHoc_View);
            this.Controls.Add(this.Courses_Reload);
            this.Controls.Add(this.Edu_Form);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DonDK_View);
            this.Name = "StudentManager_Approve";
            this.Text = "Approve";
            this.Load += new System.EventHandler(this.StudentManager_StudentRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DonDK_View;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name_HV;
        private System.Windows.Forms.ColumnHeader Course_Name;
        private System.Windows.Forms.ColumnHeader Course_Tuition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Edu_Form;
        private System.Windows.Forms.Button Courses_Reload;
        private System.Windows.Forms.ColumnHeader Student_Tuition;
        private System.Windows.Forms.ListView KhoaHoc_View;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView HocVien_view;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.ComboBox Month_Filter;
        private System.Windows.Forms.ComboBox Year_Filter;
        private System.Windows.Forms.Button ViewClassList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Student_ID;
        private System.Windows.Forms.Label Student_Name;
        private System.Windows.Forms.Label Student_SDT;
        private System.Windows.Forms.Label Student_Email;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox CheckPaid;
        private System.Windows.Forms.Button button1;
    }
}