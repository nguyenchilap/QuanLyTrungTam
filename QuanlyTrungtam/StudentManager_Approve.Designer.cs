
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
            this.button1 = new System.Windows.Forms.Button();
            this.Courses_Reload = new System.Windows.Forms.Button();
            this.Month_Filter = new System.Windows.Forms.ComboBox();
            this.Year_Filter = new System.Windows.Forms.ComboBox();
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
            this.KhoaHoc_View.Location = new System.Drawing.Point(701, 75);
            this.KhoaHoc_View.Margin = new System.Windows.Forms.Padding(4);
            this.KhoaHoc_View.Name = "KhoaHoc_View";
            this.KhoaHoc_View.Size = new System.Drawing.Size(239, 307);
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
            this.HocVien_view.Location = new System.Drawing.Point(994, 75);
            this.HocVien_view.Margin = new System.Windows.Forms.Padding(4);
            this.HocVien_view.Name = "HocVien_view";
            this.HocVien_view.Size = new System.Drawing.Size(239, 307);
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
            this.Back_button.Location = new System.Drawing.Point(29, 472);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(126, 44);
            this.Back_button.TabIndex = 75;
            this.Back_button.Text = "< Back to Menu";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.BackgroundImage = global::QuanlyTrungtam.Properties.Resources._1200px_Arrow_icon_svg;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(947, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 49);
            this.button1.TabIndex = 73;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Courses_Reload.Location = new System.Drawing.Point(310, 31);
            this.Courses_Reload.Name = "Courses_Reload";
            this.Courses_Reload.Size = new System.Drawing.Size(32, 31);
            this.Courses_Reload.TabIndex = 71;
            this.Courses_Reload.UseVisualStyleBackColor = false;
            this.Courses_Reload.Click += new System.EventHandler(this.Courses_Reload_Click);
            // 
            // Month_Filter
            // 
            this.Month_Filter.FormattingEnabled = true;
            this.Month_Filter.Location = new System.Drawing.Point(29, 398);
            this.Month_Filter.Name = "Month_Filter";
            this.Month_Filter.Size = new System.Drawing.Size(126, 24);
            this.Month_Filter.TabIndex = 76;
            this.Month_Filter.SelectedIndexChanged += new System.EventHandler(this.Month_Filter_SelectedIndexChanged);
            // 
            // Year_Filter
            // 
            this.Year_Filter.FormattingEnabled = true;
            this.Year_Filter.Location = new System.Drawing.Point(29, 434);
            this.Year_Filter.Name = "Year_Filter";
            this.Year_Filter.Size = new System.Drawing.Size(126, 24);
            this.Year_Filter.TabIndex = 77;
            this.Year_Filter.SelectedIndexChanged += new System.EventHandler(this.Year_Filter_SelectedIndexChanged);
            // 
            // StudentManager_Approve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1246, 528);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView HocVien_view;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.ComboBox Month_Filter;
        private System.Windows.Forms.ComboBox Year_Filter;
    }
}