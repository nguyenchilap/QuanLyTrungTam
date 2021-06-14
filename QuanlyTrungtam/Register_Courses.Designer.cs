
namespace QuanlyTrungtam
{
    partial class Register_Courses
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
            this.Num_Course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edu_Form = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.List_SubGr = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.Courses_Reload = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Rule_Text = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.AssignCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cur_UserID = new System.Windows.Forms.Label();
            this.BUTTON = new System.Windows.Forms.Button();
            this.Name_teacher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.View_Details_Class = new System.Windows.Forms.Button();
            this.IDCur_Course = new System.Windows.Forms.TextBox();
            this.NameCur_Course = new System.Windows.Forms.TextBox();
            this.Contact_teacher = new System.Windows.Forms.TextBox();
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
            this.Num_Course});
            this.Courses_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses_View.FullRowSelect = true;
            this.Courses_View.GridLines = true;
            this.Courses_View.HideSelection = false;
            this.Courses_View.Location = new System.Drawing.Point(25, 70);
            this.Courses_View.Margin = new System.Windows.Forms.Padding(4);
            this.Courses_View.Name = "Courses_View";
            this.Courses_View.Size = new System.Drawing.Size(650, 304);
            this.Courses_View.TabIndex = 56;
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
            // Num_Course
            // 
            this.Num_Course.Text = "Số lượng";
            this.Num_Course.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num_Course.Width = 78;
            // 
            // Edu_Form
            // 
            this.Edu_Form.FormattingEnabled = true;
            this.Edu_Form.Items.AddRange(new object[] {
            "Tất cả"});
            this.Edu_Form.Location = new System.Drawing.Point(340, 28);
            this.Edu_Form.Name = "Edu_Form";
            this.Edu_Form.Size = new System.Drawing.Size(335, 24);
            this.Edu_Form.TabIndex = 57;
            this.Edu_Form.SelectedIndexChanged += new System.EventHandler(this.Edu_Form_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("VNI-Bandit", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 30);
            this.label10.TabIndex = 58;
            this.label10.Text = "Danh sach khoa hoc";
            // 
            // List_SubGr
            // 
            this.List_SubGr.Location = new System.Drawing.Point(767, 70);
            this.List_SubGr.Name = "List_SubGr";
            this.List_SubGr.Size = new System.Drawing.Size(316, 276);
            this.List_SubGr.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.BackgroundImage = global::QuanlyTrungtam.Properties.Resources._1200px_Arrow_icon_svg;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(693, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 56);
            this.button1.TabIndex = 72;
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
            this.Courses_Reload.Location = new System.Drawing.Point(292, 23);
            this.Courses_Reload.Name = "Courses_Reload";
            this.Courses_Reload.Size = new System.Drawing.Size(32, 31);
            this.Courses_Reload.TabIndex = 71;
            this.Courses_Reload.UseVisualStyleBackColor = false;
            this.Courses_Reload.Click += new System.EventHandler(this.Courses_Reload_Click);
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
            this.Back.Location = new System.Drawing.Point(12, 488);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(138, 50);
            this.Back.TabIndex = 73;
            this.Back.Text = "< Back to Menu";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Rule_Text
            // 
            this.Rule_Text.Location = new System.Drawing.Point(169, 395);
            this.Rule_Text.Multiline = true;
            this.Rule_Text.Name = "Rule_Text";
            this.Rule_Text.Size = new System.Drawing.Size(370, 143);
            this.Rule_Text.TabIndex = 74;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatAppearance.BorderSize = 2;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Submit.Location = new System.Drawing.Point(559, 490);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(116, 48);
            this.Submit.TabIndex = 75;
            this.Submit.Text = "View Rule";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AssignCourse
            // 
            this.AssignCourse.BackColor = System.Drawing.Color.Tan;
            this.AssignCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssignCourse.FlatAppearance.BorderSize = 2;
            this.AssignCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AssignCourse.Location = new System.Drawing.Point(559, 395);
            this.AssignCourse.Name = "AssignCourse";
            this.AssignCourse.Size = new System.Drawing.Size(116, 48);
            this.AssignCourse.TabIndex = 76;
            this.AssignCourse.Text = "Register";
            this.AssignCourse.UseVisualStyleBackColor = false;
            this.AssignCourse.Click += new System.EventHandler(this.AssignCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "QUY TẮC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "KHÓA HỌC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(764, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 80;
            this.label4.Text = "ID Học viên : ";
            // 
            // Cur_UserID
            // 
            this.Cur_UserID.AutoSize = true;
            this.Cur_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cur_UserID.Location = new System.Drawing.Point(850, 28);
            this.Cur_UserID.Name = "Cur_UserID";
            this.Cur_UserID.Size = new System.Drawing.Size(58, 29);
            this.Cur_UserID.TabIndex = 81;
            this.Cur_UserID.Text = "000";
            // 
            // BUTTON
            // 
            this.BUTTON.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.BUTTON.FlatAppearance.BorderSize = 3;
            this.BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BUTTON.Location = new System.Drawing.Point(932, 11);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(151, 40);
            this.BUTTON.TabIndex = 82;
            this.BUTTON.Text = "Sign in";
            this.BUTTON.UseVisualStyleBackColor = false;
            this.BUTTON.Click += new System.EventHandler(this.button3_Click);
            // 
            // Name_teacher
            // 
            this.Name_teacher.Location = new System.Drawing.Point(767, 432);
            this.Name_teacher.Name = "Name_teacher";
            this.Name_teacher.Size = new System.Drawing.Size(316, 22);
            this.Name_teacher.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(763, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Chi tiết lớp học :";
            // 
            // View_Details_Class
            // 
            this.View_Details_Class.BackColor = System.Drawing.Color.LightSeaGreen;
            this.View_Details_Class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View_Details_Class.FlatAppearance.BorderSize = 2;
            this.View_Details_Class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Details_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Details_Class.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.View_Details_Class.Location = new System.Drawing.Point(993, 383);
            this.View_Details_Class.Name = "View_Details_Class";
            this.View_Details_Class.Size = new System.Drawing.Size(90, 37);
            this.View_Details_Class.TabIndex = 85;
            this.View_Details_Class.Text = "View";
            this.View_Details_Class.UseVisualStyleBackColor = false;
            this.View_Details_Class.Click += new System.EventHandler(this.View_Details_Class_Click);
            // 
            // IDCur_Course
            // 
            this.IDCur_Course.Location = new System.Drawing.Point(767, 352);
            this.IDCur_Course.Name = "IDCur_Course";
            this.IDCur_Course.Size = new System.Drawing.Size(74, 22);
            this.IDCur_Course.TabIndex = 86;
            this.IDCur_Course.TextChanged += new System.EventHandler(this.IDCur_Course_TextChanged);
            // 
            // NameCur_Course
            // 
            this.NameCur_Course.Location = new System.Drawing.Point(847, 352);
            this.NameCur_Course.Name = "NameCur_Course";
            this.NameCur_Course.Size = new System.Drawing.Size(236, 22);
            this.NameCur_Course.TabIndex = 87;
            // 
            // Contact_teacher
            // 
            this.Contact_teacher.Location = new System.Drawing.Point(767, 478);
            this.Contact_teacher.Name = "Contact_teacher";
            this.Contact_teacher.Size = new System.Drawing.Size(316, 22);
            this.Contact_teacher.TabIndex = 88;
            // 
            // Register_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1104, 550);
            this.Controls.Add(this.Contact_teacher);
            this.Controls.Add(this.NameCur_Course);
            this.Controls.Add(this.IDCur_Course);
            this.Controls.Add(this.View_Details_Class);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Name_teacher);
            this.Controls.Add(this.BUTTON);
            this.Controls.Add(this.Cur_UserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AssignCourse);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Rule_Text);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Courses_Reload);
            this.Controls.Add(this.List_SubGr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Edu_Form);
            this.Controls.Add(this.Courses_View);
            this.Name = "Register_Courses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Guess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Courses_View;
        private System.Windows.Forms.ColumnHeader ID_Source;
        private System.Windows.Forms.ColumnHeader Name_Source;
        private System.Windows.Forms.ColumnHeader Form_Source;
        private System.Windows.Forms.ColumnHeader Start_Course;
        private System.Windows.Forms.ColumnHeader Num_Course;
        private System.Windows.Forms.ComboBox Edu_Form;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TreeView List_SubGr;
        private System.Windows.Forms.Button Courses_Reload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Rule_Text;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button AssignCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Cur_UserID;
        private System.Windows.Forms.Button BUTTON;
        private System.Windows.Forms.TextBox Name_teacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button View_Details_Class;
        private System.Windows.Forms.TextBox IDCur_Course;
        private System.Windows.Forms.TextBox NameCur_Course;
        private System.Windows.Forms.TextBox Contact_teacher;
    }
}