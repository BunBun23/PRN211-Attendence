
namespace Attendence
{
    partial class TeacherForm
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
            this.PanelStudent = new System.Windows.Forms.Panel();
            this.PickTeacherDate = new System.Windows.Forms.DateTimePicker();
            this.BtnAddTeacher = new System.Windows.Forms.Button();
            this.BtnUpdateTeacher = new System.Windows.Forms.Button();
            this.BtnDeleteTeacher = new System.Windows.Forms.Button();
            this.BtnClearTeacher = new System.Windows.Forms.Button();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GridTeacher = new System.Windows.Forms.DataGridView();
            this.PanelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelStudent
            // 
            this.PanelStudent.Controls.Add(this.PickTeacherDate);
            this.PanelStudent.Controls.Add(this.BtnAddTeacher);
            this.PanelStudent.Controls.Add(this.BtnUpdateTeacher);
            this.PanelStudent.Controls.Add(this.BtnDeleteTeacher);
            this.PanelStudent.Controls.Add(this.BtnClearTeacher);
            this.PanelStudent.Controls.Add(this.TxtAddress);
            this.PanelStudent.Controls.Add(this.label6);
            this.PanelStudent.Controls.Add(this.label5);
            this.PanelStudent.Controls.Add(this.TxtName);
            this.PanelStudent.Controls.Add(this.label4);
            this.PanelStudent.Controls.Add(this.TxtPass);
            this.PanelStudent.Controls.Add(this.label1);
            this.PanelStudent.Controls.Add(this.TxtUsername);
            this.PanelStudent.Controls.Add(this.label2);
            this.PanelStudent.Controls.Add(this.GridTeacher);
            this.PanelStudent.Location = new System.Drawing.Point(12, 12);
            this.PanelStudent.Name = "PanelStudent";
            this.PanelStudent.Size = new System.Drawing.Size(759, 389);
            this.PanelStudent.TabIndex = 1;
            // 
            // PickTeacherDate
            // 
            this.PickTeacherDate.Location = new System.Drawing.Point(115, 163);
            this.PickTeacherDate.Name = "PickTeacherDate";
            this.PickTeacherDate.Size = new System.Drawing.Size(200, 20);
            this.PickTeacherDate.TabIndex = 20;
            // 
            // BtnAddTeacher
            // 
            this.BtnAddTeacher.Location = new System.Drawing.Point(63, 314);
            this.BtnAddTeacher.Name = "BtnAddTeacher";
            this.BtnAddTeacher.Size = new System.Drawing.Size(186, 23);
            this.BtnAddTeacher.TabIndex = 18;
            this.BtnAddTeacher.Text = "Add";
            this.BtnAddTeacher.UseVisualStyleBackColor = true;
            this.BtnAddTeacher.Click += new System.EventHandler(this.BtnAddTeacher_Click);
            // 
            // BtnUpdateTeacher
            // 
            this.BtnUpdateTeacher.Location = new System.Drawing.Point(232, 271);
            this.BtnUpdateTeacher.Name = "BtnUpdateTeacher";
            this.BtnUpdateTeacher.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateTeacher.TabIndex = 17;
            this.BtnUpdateTeacher.Text = "Update";
            this.BtnUpdateTeacher.UseVisualStyleBackColor = true;
            this.BtnUpdateTeacher.Click += new System.EventHandler(this.BtnUpdateTeacher_Click);
            // 
            // BtnDeleteTeacher
            // 
            this.BtnDeleteTeacher.Location = new System.Drawing.Point(125, 271);
            this.BtnDeleteTeacher.Name = "BtnDeleteTeacher";
            this.BtnDeleteTeacher.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteTeacher.TabIndex = 16;
            this.BtnDeleteTeacher.Text = "Delete";
            this.BtnDeleteTeacher.UseVisualStyleBackColor = true;
            this.BtnDeleteTeacher.Click += new System.EventHandler(this.BtnDeleteTeacher_Click);
            // 
            // BtnClearTeacher
            // 
            this.BtnClearTeacher.Location = new System.Drawing.Point(23, 271);
            this.BtnClearTeacher.Name = "BtnClearTeacher";
            this.BtnClearTeacher.Size = new System.Drawing.Size(75, 23);
            this.BtnClearTeacher.TabIndex = 15;
            this.BtnClearTeacher.Text = "Clear";
            this.BtnClearTeacher.UseVisualStyleBackColor = true;
            this.BtnClearTeacher.Click += new System.EventHandler(this.BtnClearTeacher_Click);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(115, 207);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(100, 20);
            this.TxtAddress.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "BirthDate";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(115, 112);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(115, 62);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(100, 20);
            this.TxtPass.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(115, 21);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(100, 20);
            this.TxtUsername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // GridTeacher
            // 
            this.GridTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTeacher.Location = new System.Drawing.Point(331, 3);
            this.GridTeacher.Name = "GridTeacher";
            this.GridTeacher.Size = new System.Drawing.Size(425, 367);
            this.GridTeacher.TabIndex = 0;
            this.GridTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTeacher_CellClick);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 421);
            this.Controls.Add(this.PanelStudent);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.PanelStudent.ResumeLayout(false);
            this.PanelStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelStudent;
        private System.Windows.Forms.DateTimePicker PickTeacherDate;
        private System.Windows.Forms.Button BtnAddTeacher;
        private System.Windows.Forms.Button BtnUpdateTeacher;
        private System.Windows.Forms.Button BtnDeleteTeacher;
        private System.Windows.Forms.Button BtnClearTeacher;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridTeacher;
    }
}