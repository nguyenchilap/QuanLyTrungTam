
namespace QuanlyTrungtam
{
    partial class ManageAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.CurPass = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.ConfirmPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.noti = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.NamePerson = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Jamai", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Change Password";
            // 
            // CurPass
            // 
            this.CurPass.Location = new System.Drawing.Point(111, 145);
            this.CurPass.Name = "CurPass";
            this.CurPass.Size = new System.Drawing.Size(250, 22);
            this.CurPass.TabIndex = 4;
            // 
            // NewPass
            // 
            this.NewPass.Location = new System.Drawing.Point(111, 260);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(250, 22);
            this.NewPass.TabIndex = 5;
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.Location = new System.Drawing.Point(111, 320);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.Size = new System.Drawing.Size(250, 22);
            this.ConfirmPass.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(108, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Current Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(109, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(108, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirm New Password:";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.BurlyWood;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.Submit.FlatAppearance.BorderSize = 3;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Submit.Location = new System.Drawing.Point(112, 374);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(249, 44);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit and Sign out";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // noti
            // 
            this.noti.AutoSize = true;
            this.noti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noti.ForeColor = System.Drawing.Color.Indigo;
            this.noti.Location = new System.Drawing.Point(152, 185);
            this.noti.Name = "noti";
            this.noti.Size = new System.Drawing.Size(170, 18);
            this.noti.TabIndex = 12;
            this.noti.Text = "Check current password";
            this.noti.Click += new System.EventHandler(this.label5_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("VNI-Jamai", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.ForeColor = System.Drawing.Color.Black;
            this.Id.Location = new System.Drawing.Point(65, 62);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(58, 34);
            this.Id.TabIndex = 13;
            this.Id.Text = "ID : ";
            // 
            // NamePerson
            // 
            this.NamePerson.AutoSize = true;
            this.NamePerson.Font = new System.Drawing.Font("VNI-Jamai", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePerson.ForeColor = System.Drawing.Color.Black;
            this.NamePerson.Location = new System.Drawing.Point(229, 62);
            this.NamePerson.Name = "NamePerson";
            this.NamePerson.Size = new System.Drawing.Size(93, 34);
            this.NamePerson.TabIndex = 14;
            this.NamePerson.Text = "Name : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.BackgroundImage = global::QuanlyTrungtam.Properties.Resources._2705_check_mark_button_512;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(367, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.BackgroundImage = global::QuanlyTrungtam.Properties.Resources.button_previous_01;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(12, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 53);
            this.button2.TabIndex = 74;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(475, 442);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NamePerson);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.noti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConfirmPass);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.CurPass);
            this.Controls.Add(this.label1);
            this.Name = "ManageAccount";
            this.Text = "ManageAccount";
            this.Load += new System.EventHandler(this.ManageAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurPass;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.TextBox ConfirmPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label noti;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label NamePerson;
        private System.Windows.Forms.Button button2;
    }
}