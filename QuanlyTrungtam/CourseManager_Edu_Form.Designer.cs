
namespace QuanlyTrungtam
{
    partial class CourseManager_Edu_Form
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
            this.LHDT_View = new System.Windows.Forms.ListView();
            this.ID_Form = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Form = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.List_GroupSub = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Rule_text = new System.Windows.Forms.TextBox();
            this.details_view = new System.Windows.Forms.ListView();
            this.ID_GrSub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_GrSub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fee_GrSub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Del_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Add_Component = new System.Windows.Forms.Button();
            this.View_Details = new System.Windows.Forms.Button();
            this.Drop_Component = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_Selected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LHDT_View
            // 
            this.LHDT_View.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LHDT_View.CheckBoxes = true;
            this.LHDT_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Form,
            this.Name_Form});
            this.LHDT_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHDT_View.FullRowSelect = true;
            this.LHDT_View.GridLines = true;
            this.LHDT_View.HideSelection = false;
            this.LHDT_View.Location = new System.Drawing.Point(26, 64);
            this.LHDT_View.Margin = new System.Windows.Forms.Padding(4);
            this.LHDT_View.Name = "LHDT_View";
            this.LHDT_View.Size = new System.Drawing.Size(313, 267);
            this.LHDT_View.TabIndex = 2;
            this.LHDT_View.UseCompatibleStateImageBehavior = false;
            this.LHDT_View.View = System.Windows.Forms.View.Details;
            // 
            // ID_Form
            // 
            this.ID_Form.Text = "ID";
            this.ID_Form.Width = 50;
            // 
            // Name_Form
            // 
            this.Name_Form.Text = "Tên Loại hình đào tạo";
            this.Name_Form.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_Form.Width = 257;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Jamai", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loai hinh dao tao";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.MidnightBlue;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(358, 491);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(96, 47);
            this.Back.TabIndex = 5;
            this.Back.Text = "Create";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Loại hình đào tạo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quy tắc:";
            // 
            // List_GroupSub
            // 
            this.List_GroupSub.FormattingEnabled = true;
            this.List_GroupSub.Items.AddRange(new object[] {
            "Danh sách Học phần",
            "Danh sách Nhóm chuyên đề",
            "Danh sách Môn học",
            "Danh sách Nhánh học",
            ""});
            this.List_GroupSub.Location = new System.Drawing.Point(566, 34);
            this.List_GroupSub.Name = "List_GroupSub";
            this.List_GroupSub.Size = new System.Drawing.Size(355, 24);
            this.List_GroupSub.TabIndex = 11;
            this.List_GroupSub.SelectedIndexChanged += new System.EventHandler(this.List_GroupSub_SelectedIndexChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.DarkCyan;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit.Location = new System.Drawing.Point(257, 362);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(82, 47);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "View Rule";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Rule_text
            // 
            this.Rule_text.Location = new System.Drawing.Point(26, 363);
            this.Rule_text.Multiline = true;
            this.Rule_text.Name = "Rule_text";
            this.Rule_text.Size = new System.Drawing.Size(224, 176);
            this.Rule_text.TabIndex = 15;
            // 
            // details_view
            // 
            this.details_view.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.details_view.CheckBoxes = true;
            this.details_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_GrSub,
            this.Name_GrSub,
            this.Fee_GrSub});
            this.details_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_view.FullRowSelect = true;
            this.details_view.GridLines = true;
            this.details_view.HideSelection = false;
            this.details_view.Location = new System.Drawing.Point(566, 65);
            this.details_view.Margin = new System.Windows.Forms.Padding(4);
            this.details_view.Name = "details_view";
            this.details_view.Size = new System.Drawing.Size(355, 474);
            this.details_view.TabIndex = 16;
            this.details_view.UseCompatibleStateImageBehavior = false;
            this.details_view.View = System.Windows.Forms.View.Details;
            // 
            // ID_GrSub
            // 
            this.ID_GrSub.Text = "ID";
            this.ID_GrSub.Width = 79;
            // 
            // Name_GrSub
            // 
            this.Name_GrSub.Text = "Tên";
            this.Name_GrSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_GrSub.Width = 193;
            // 
            // Fee_GrSub
            // 
            this.Fee_GrSub.Text = "Học phí";
            this.Fee_GrSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fee_GrSub.Width = 80;
            // 
            // Name_text
            // 
            this.Name_text.Location = new System.Drawing.Point(256, 463);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(297, 22);
            this.Name_text.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(257, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "Fix";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Del_button
            // 
            this.Del_button.BackColor = System.Drawing.Color.DarkRed;
            this.Del_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Del_button.Location = new System.Drawing.Point(460, 491);
            this.Del_button.Name = "Del_button";
            this.Del_button.Size = new System.Drawing.Size(93, 47);
            this.Del_button.TabIndex = 19;
            this.Del_button.Text = "Drop";
            this.Del_button.UseVisualStyleBackColor = false;
            this.Del_button.Click += new System.EventHandler(this.Del_button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.BackgroundImage = global::QuanlyTrungtam.Properties.Resources.redo_solid;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(303, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 34);
            this.button2.TabIndex = 44;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add_Component
            // 
            this.Add_Component.BackColor = System.Drawing.Color.SteelBlue;
            this.Add_Component.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Component.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Component.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Component.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_Component.Location = new System.Drawing.Point(369, 146);
            this.Add_Component.Name = "Add_Component";
            this.Add_Component.Size = new System.Drawing.Size(171, 45);
            this.Add_Component.TabIndex = 45;
            this.Add_Component.Text = "Add Components +";
            this.Add_Component.UseVisualStyleBackColor = false;
            this.Add_Component.Click += new System.EventHandler(this.Add_Component_Click);
            // 
            // View_Details
            // 
            this.View_Details.BackColor = System.Drawing.Color.DarkCyan;
            this.View_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Details.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.View_Details.Location = new System.Drawing.Point(369, 64);
            this.View_Details.Name = "View_Details";
            this.View_Details.Size = new System.Drawing.Size(171, 45);
            this.View_Details.TabIndex = 46;
            this.View_Details.Text = "View Details >";
            this.View_Details.UseVisualStyleBackColor = false;
            this.View_Details.Click += new System.EventHandler(this.View_Details_Click);
            // 
            // Drop_Component
            // 
            this.Drop_Component.BackColor = System.Drawing.Color.Brown;
            this.Drop_Component.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drop_Component.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Drop_Component.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drop_Component.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Drop_Component.Location = new System.Drawing.Point(369, 229);
            this.Drop_Component.Name = "Drop_Component";
            this.Drop_Component.Size = new System.Drawing.Size(171, 45);
            this.Drop_Component.TabIndex = 47;
            this.Drop_Component.Text = "Drop Components -";
            this.Drop_Component.UseVisualStyleBackColor = false;
            this.Drop_Component.Click += new System.EventHandler(this.Drop_Component_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "ID Edu_Form :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ID_Selected
            // 
            this.ID_Selected.AutoSize = true;
            this.ID_Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Selected.Location = new System.Drawing.Point(439, 343);
            this.ID_Selected.Name = "ID_Selected";
            this.ID_Selected.Size = new System.Drawing.Size(66, 33);
            this.ID_Selected.TabIndex = 50;
            this.ID_Selected.Text = "000";
            // 
            // Admin_Edu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(941, 552);
            this.Controls.Add(this.ID_Selected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Drop_Component);
            this.Controls.Add(this.View_Details);
            this.Controls.Add(this.Add_Component);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Del_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.details_view);
            this.Controls.Add(this.Rule_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LHDT_View);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.List_GroupSub);
            this.Controls.Add(this.Back);
            this.Name = "Admin_Edu_Form";
            this.Text = "Education Form";
            this.Load += new System.EventHandler(this.Admin_Courses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LHDT_View;
        private System.Windows.Forms.ColumnHeader ID_Form;
        private System.Windows.Forms.ColumnHeader Name_Form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox List_GroupSub;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox Rule_text;
        private System.Windows.Forms.ListView details_view;
        private System.Windows.Forms.ColumnHeader ID_GrSub;
        private System.Windows.Forms.ColumnHeader Name_GrSub;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Del_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Fee_GrSub;
        private System.Windows.Forms.Button Add_Component;
        private System.Windows.Forms.Button View_Details;
        private System.Windows.Forms.Button Drop_Component;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ID_Selected;
    }
}