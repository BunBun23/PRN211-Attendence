
namespace Attendence
{
    partial class Menu
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
            this.BtnClass = new System.Windows.Forms.Button();
            this.BtnRoom = new System.Windows.Forms.Button();
            this.BtnCourse = new System.Windows.Forms.Button();
            this.BtnStudent = new System.Windows.Forms.Button();
            this.BtnTeacher = new System.Windows.Forms.Button();
            this.BtnAssign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClass
            // 
            this.BtnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClass.Location = new System.Drawing.Point(86, 132);
            this.BtnClass.Name = "BtnClass";
            this.BtnClass.Size = new System.Drawing.Size(116, 46);
            this.BtnClass.TabIndex = 0;
            this.BtnClass.Text = "Class";
            this.BtnClass.UseVisualStyleBackColor = true;
            this.BtnClass.Click += new System.EventHandler(this.BtnClass_Click);
            // 
            // BtnRoom
            // 
            this.BtnRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoom.Location = new System.Drawing.Point(274, 132);
            this.BtnRoom.Name = "BtnRoom";
            this.BtnRoom.Size = new System.Drawing.Size(116, 46);
            this.BtnRoom.TabIndex = 1;
            this.BtnRoom.Text = "Room";
            this.BtnRoom.UseVisualStyleBackColor = true;
            this.BtnRoom.Click += new System.EventHandler(this.BtnRoom_Click);
            // 
            // BtnCourse
            // 
            this.BtnCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCourse.Location = new System.Drawing.Point(458, 132);
            this.BtnCourse.Name = "BtnCourse";
            this.BtnCourse.Size = new System.Drawing.Size(116, 46);
            this.BtnCourse.TabIndex = 2;
            this.BtnCourse.Text = "Course";
            this.BtnCourse.UseVisualStyleBackColor = true;
            this.BtnCourse.Click += new System.EventHandler(this.BtnCourse_Click);
            // 
            // BtnStudent
            // 
            this.BtnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudent.Location = new System.Drawing.Point(86, 226);
            this.BtnStudent.Name = "BtnStudent";
            this.BtnStudent.Size = new System.Drawing.Size(116, 46);
            this.BtnStudent.TabIndex = 3;
            this.BtnStudent.Text = "Student";
            this.BtnStudent.UseVisualStyleBackColor = true;
            this.BtnStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // BtnTeacher
            // 
            this.BtnTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTeacher.Location = new System.Drawing.Point(274, 226);
            this.BtnTeacher.Name = "BtnTeacher";
            this.BtnTeacher.Size = new System.Drawing.Size(116, 46);
            this.BtnTeacher.TabIndex = 4;
            this.BtnTeacher.Text = "Teacher";
            this.BtnTeacher.UseVisualStyleBackColor = true;
            this.BtnTeacher.Click += new System.EventHandler(this.BtnTeacher_Click);
            // 
            // BtnAssign
            // 
            this.BtnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAssign.Location = new System.Drawing.Point(458, 226);
            this.BtnAssign.Name = "BtnAssign";
            this.BtnAssign.Size = new System.Drawing.Size(116, 46);
            this.BtnAssign.TabIndex = 5;
            this.BtnAssign.Text = "Assign";
            this.BtnAssign.UseVisualStyleBackColor = true;
            this.BtnAssign.Click += new System.EventHandler(this.BtnAssign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(114, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "ATTENDANCE MANAGEMENT";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAssign);
            this.Controls.Add(this.BtnTeacher);
            this.Controls.Add(this.BtnStudent);
            this.Controls.Add(this.BtnCourse);
            this.Controls.Add(this.BtnRoom);
            this.Controls.Add(this.BtnClass);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClass;
        private System.Windows.Forms.Button BtnRoom;
        private System.Windows.Forms.Button BtnCourse;
        private System.Windows.Forms.Button BtnStudent;
        private System.Windows.Forms.Button BtnTeacher;
        private System.Windows.Forms.Button BtnAssign;
        private System.Windows.Forms.Label label1;
    }
}