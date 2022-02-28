
namespace Attendence
{
    partial class ScheduleForm
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
            this.CboClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboCourse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboTeacher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CboRoom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboSlot = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PickDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAssign = new System.Windows.Forms.Button();
            this.LblConfirm = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CboClass
            // 
            this.CboClass.FormattingEnabled = true;
            this.CboClass.Location = new System.Drawing.Point(31, 70);
            this.CboClass.Name = "CboClass";
            this.CboClass.Size = new System.Drawing.Size(121, 21);
            this.CboClass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course";
            // 
            // CboCourse
            // 
            this.CboCourse.FormattingEnabled = true;
            this.CboCourse.Location = new System.Drawing.Point(175, 70);
            this.CboCourse.Name = "CboCourse";
            this.CboCourse.Size = new System.Drawing.Size(121, 21);
            this.CboCourse.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teacher";
            // 
            // CboTeacher
            // 
            this.CboTeacher.FormattingEnabled = true;
            this.CboTeacher.Location = new System.Drawing.Point(316, 70);
            this.CboTeacher.Name = "CboTeacher";
            this.CboTeacher.Size = new System.Drawing.Size(121, 21);
            this.CboTeacher.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Room";
            // 
            // CboRoom
            // 
            this.CboRoom.FormattingEnabled = true;
            this.CboRoom.Location = new System.Drawing.Point(457, 69);
            this.CboRoom.Name = "CboRoom";
            this.CboRoom.Size = new System.Drawing.Size(121, 21);
            this.CboRoom.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(634, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Slot";
            // 
            // CboSlot
            // 
            this.CboSlot.FormattingEnabled = true;
            this.CboSlot.Location = new System.Drawing.Point(604, 69);
            this.CboSlot.Name = "CboSlot";
            this.CboSlot.Size = new System.Drawing.Size(121, 21);
            this.CboSlot.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(805, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "StartDate";
            // 
            // PickDate
            // 
            this.PickDate.Location = new System.Drawing.Point(749, 69);
            this.PickDate.Name = "PickDate";
            this.PickDate.Size = new System.Drawing.Size(200, 20);
            this.PickDate.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1120, 427);
            this.dataGridView1.TabIndex = 13;
            // 
            // BtnAssign
            // 
            this.BtnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAssign.Location = new System.Drawing.Point(1001, 66);
            this.BtnAssign.Name = "BtnAssign";
            this.BtnAssign.Size = new System.Drawing.Size(79, 25);
            this.BtnAssign.TabIndex = 14;
            this.BtnAssign.Text = "Assign";
            this.BtnAssign.UseVisualStyleBackColor = true;
            this.BtnAssign.Click += new System.EventHandler(this.BtnAssign_Click);
            // 
            // LblConfirm
            // 
            this.LblConfirm.AutoSize = true;
            this.LblConfirm.ForeColor = System.Drawing.Color.Red;
            this.LblConfirm.Location = new System.Drawing.Point(71, 117);
            this.LblConfirm.Name = "LblConfirm";
            this.LblConfirm.Size = new System.Drawing.Size(0, 13);
            this.LblConfirm.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(580, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 19;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(1001, 125);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(79, 25);
            this.BtnDelete.TabIndex = 20;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 595);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblConfirm);
            this.Controls.Add(this.BtnAssign);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PickDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CboSlot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboTeacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboClass);
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboSlot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker PickDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAssign;
        private System.Windows.Forms.Label LblConfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnDelete;
    }
}