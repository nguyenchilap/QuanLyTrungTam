
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
            this.label10 = new System.Windows.Forms.Label();
            this.Edu_Form = new System.Windows.Forms.ComboBox();
            this.Courses_Reload = new System.Windows.Forms.Button();
            this.Student_Tuition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.DonDK_View.Size = new System.Drawing.Size(639, 307);
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
            this.Edu_Form.Location = new System.Drawing.Point(351, 36);
            this.Edu_Form.Name = "Edu_Form";
            this.Edu_Form.Size = new System.Drawing.Size(317, 24);
            this.Edu_Form.TabIndex = 35;
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
            this.Courses_Reload.Location = new System.Drawing.Point(302, 31);
            this.Courses_Reload.Name = "Courses_Reload";
            this.Courses_Reload.Size = new System.Drawing.Size(32, 31);
            this.Courses_Reload.TabIndex = 71;
            this.Courses_Reload.UseVisualStyleBackColor = false;
            // 
            // Student_Tuition
            // 
            this.Student_Tuition.Text = "Đóng học phí";
            this.Student_Tuition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Student_Tuition.Width = 100;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(688, 75);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(239, 307);
            this.listView1.TabIndex = 72;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // StudentManager_Approve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1271, 520);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}