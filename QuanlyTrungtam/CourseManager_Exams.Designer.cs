
namespace QuanlyTrungtam
{
    partial class CourseManager_Exams
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
            this.EmployeeView.Location = new System.Drawing.Point(25, 73);
            this.EmployeeView.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.Size = new System.Drawing.Size(688, 339);
            this.EmployeeView.TabIndex = 59;
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
            // CourseManager_Exams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 547);
            this.Controls.Add(this.EmployeeView);
            this.Name = "CourseManager_Exams";
            this.Text = "CourseManager_Exams";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView EmployeeView;
        private System.Windows.Forms.ColumnHeader ID_Teacher;
        private System.Windows.Forms.ColumnHeader Name_Teacher;
        private System.Windows.Forms.ColumnHeader Email_Teacger;
        private System.Windows.Forms.ColumnHeader SDT_Teacher;
        private System.Windows.Forms.ColumnHeader Major;
    }
}