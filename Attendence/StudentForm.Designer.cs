
namespace Attendence
{
    partial class StudentForm
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
            this.PickStudentDate = new System.Windows.Forms.DateTimePicker();
            this.BtnAddCourse = new System.Windows.Forms.Button();
            this.BtnUpdateCourse = new System.Windows.Forms.Button();
            this.BtnDeleteCourse = new System.Windows.Forms.Button();
            this.BtnClearCourse = new System.Windows.Forms.Button();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GridStudent = new System.Windows.Forms.DataGridView();
            this.LblConfirm = new System.Windows.Forms.Label();
            this.PanelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelStudent
            // 
            this.PanelStudent.Controls.Add(this.LblConfirm);
            this.PanelStudent.Controls.Add(this.PickStudentDate);
            this.PanelStudent.Controls.Add(this.BtnAddCourse);
            this.PanelStudent.Controls.Add(this.BtnUpdateCourse);
            this.PanelStudent.Controls.Add(this.BtnDeleteCourse);
            this.PanelStudent.Controls.Add(this.BtnClearCourse);
            this.PanelStudent.Controls.Add(this.TxtAddress);
            this.PanelStudent.Controls.Add(this.label6);
            this.PanelStudent.Controls.Add(this.label5);
            this.PanelStudent.Controls.Add(this.TxtName);
            this.PanelStudent.Controls.Add(this.label4);
            this.PanelStudent.Controls.Add(this.TxtPass);
            this.PanelStudent.Controls.Add(this.label1);
            this.PanelStudent.Controls.Add(this.TxtUsername);
            this.PanelStudent.Controls.Add(this.label2);
            this.PanelStudent.Controls.Add(this.GridStudent);
            this.PanelStudent.Location = new System.Drawing.Point(12, 12);
            this.PanelStudent.Name = "PanelStudent";
            this.PanelStudent.Size = new System.Drawing.Size(759, 389);
            this.PanelStudent.TabIndex = 0;
            // 
            // PickStudentDate
            // 
            this.PickStudentDate.Location = new System.Drawing.Point(115, 163);
            this.PickStudentDate.Name = "PickStudentDate";
            this.PickStudentDate.Size = new System.Drawing.Size(200, 20);
            this.PickStudentDate.TabIndex = 20;
            // 
            // BtnAddCourse
            // 
            this.BtnAddCourse.Location = new System.Drawing.Point(63, 314);
            this.BtnAddCourse.Name = "BtnAddCourse";
            this.BtnAddCourse.Size = new System.Drawing.Size(186, 23);
            this.BtnAddCourse.TabIndex = 18;
            this.BtnAddCourse.Text = "Add";
            this.BtnAddCourse.UseVisualStyleBackColor = true;
            this.BtnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // BtnUpdateCourse
            // 
            this.BtnUpdateCourse.Location = new System.Drawing.Point(232, 271);
            this.BtnUpdateCourse.Name = "BtnUpdateCourse";
            this.BtnUpdateCourse.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateCourse.TabIndex = 17;
            this.BtnUpdateCourse.Text = "Update";
            this.BtnUpdateCourse.UseVisualStyleBackColor = true;
            this.BtnUpdateCourse.Click += new System.EventHandler(this.BtnUpdateCourse_Click);
            // 
            // BtnDeleteCourse
            // 
            this.BtnDeleteCourse.Location = new System.Drawing.Point(125, 271);
            this.BtnDeleteCourse.Name = "BtnDeleteCourse";
            this.BtnDeleteCourse.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteCourse.TabIndex = 16;
            this.BtnDeleteCourse.Text = "Delete";
            this.BtnDeleteCourse.UseVisualStyleBackColor = true;
            this.BtnDeleteCourse.Click += new System.EventHandler(this.BtnDeleteCourse_Click);
            // 
            // BtnClearCourse
            // 
            this.BtnClearCourse.Location = new System.Drawing.Point(23, 271);
            this.BtnClearCourse.Name = "BtnClearCourse";
            this.BtnClearCourse.Size = new System.Drawing.Size(75, 23);
            this.BtnClearCourse.TabIndex = 15;
            this.BtnClearCourse.Text = "Clear";
            this.BtnClearCourse.UseVisualStyleBackColor = true;
            this.BtnClearCourse.Click += new System.EventHandler(this.BtnClearCourse_Click);
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
            // GridStudent
            // 
            this.GridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStudent.Location = new System.Drawing.Point(331, 3);
            this.GridStudent.Name = "GridStudent";
            this.GridStudent.Size = new System.Drawing.Size(425, 367);
            this.GridStudent.TabIndex = 0;
            this.GridStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridStudent_CellClick);
            // 
            // LblConfirm
            // 
            this.LblConfirm.AutoSize = true;
            this.LblConfirm.ForeColor = System.Drawing.Color.Red;
            this.LblConfirm.Location = new System.Drawing.Point(19, 357);
            this.LblConfirm.Name = "LblConfirm";
            this.LblConfirm.Size = new System.Drawing.Size(0, 13);
            this.LblConfirm.TabIndex = 21;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 417);
            this.Controls.Add(this.PanelStudent);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.PanelStudent.ResumeLayout(false);
            this.PanelStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelStudent;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GridStudent;
        private System.Windows.Forms.Button BtnAddCourse;
        private System.Windows.Forms.Button BtnUpdateCourse;
        private System.Windows.Forms.Button BtnDeleteCourse;
        private System.Windows.Forms.Button BtnClearCourse;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker PickStudentDate;
        private System.Windows.Forms.Label LblConfirm;
    }
}