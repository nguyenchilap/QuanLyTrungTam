
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
            this.BUTTON = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Edu_Form = new System.Windows.Forms.ComboBox();
            this.Courses_Reload = new System.Windows.Forms.Button();
            this.List_SubGr = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // BUTTON
            // 
            this.BUTTON.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.BUTTON.FlatAppearance.BorderSize = 3;
            this.BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BUTTON.Location = new System.Drawing.Point(724, 28);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(151, 40);
            this.BUTTON.TabIndex = 83;
            this.BUTTON.Text = "Sign in";
            this.BUTTON.UseVisualStyleBackColor = false;
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
            this.List_SubGr.Size = new System.Drawing.Size(316, 304);
            this.List_SubGr.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 29);
            this.label2.TabIndex = 89;
            this.label2.Text = "000";
            // 
            // Student_ManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1119, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_SubGr);
            this.Controls.Add(this.Courses_Reload);
            this.Controls.Add(this.Edu_Form);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.BUTTON);
            this.Controls.Add(this.ViewDetail_button);
            this.Controls.Add(this.Courses_View);
            this.Name = "Student_ManageClass";
            this.Text = "Student_ManageClass";
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
        private System.Windows.Forms.Button BUTTON;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox Edu_Form;
        private System.Windows.Forms.Button Courses_Reload;
        private System.Windows.Forms.TreeView List_SubGr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}