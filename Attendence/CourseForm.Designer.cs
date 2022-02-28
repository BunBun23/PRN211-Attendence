
namespace Attendence
{
    partial class CourseForm
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
            this.PanelCourse = new System.Windows.Forms.Panel();
            this.BtnAddCourse = new System.Windows.Forms.Button();
            this.BtnUpdateCourse = new System.Windows.Forms.Button();
            this.BtnDeleteCourse = new System.Windows.Forms.Button();
            this.BtnClearCourse = new System.Windows.Forms.Button();
            this.GridViewCourse = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.DescriptionCourse = new System.Windows.Forms.RichTextBox();
            this.CheckBoxCourse = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCourseName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCourseID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCourse
            // 
            this.PanelCourse.Controls.Add(this.BtnAddCourse);
            this.PanelCourse.Controls.Add(this.BtnUpdateCourse);
            this.PanelCourse.Controls.Add(this.BtnDeleteCourse);
            this.PanelCourse.Controls.Add(this.BtnClearCourse);
            this.PanelCourse.Controls.Add(this.GridViewCourse);
            this.PanelCourse.Controls.Add(this.label11);
            this.PanelCourse.Controls.Add(this.DescriptionCourse);
            this.PanelCourse.Controls.Add(this.CheckBoxCourse);
            this.PanelCourse.Controls.Add(this.label10);
            this.PanelCourse.Controls.Add(this.TxtCourseName);
            this.PanelCourse.Controls.Add(this.label9);
            this.PanelCourse.Controls.Add(this.TxtCourseID);
            this.PanelCourse.Controls.Add(this.label8);
            this.PanelCourse.Location = new System.Drawing.Point(12, 12);
            this.PanelCourse.Name = "PanelCourse";
            this.PanelCourse.Size = new System.Drawing.Size(762, 487);
            this.PanelCourse.TabIndex = 12;
            // 
            // BtnAddCourse
            // 
            this.BtnAddCourse.Location = new System.Drawing.Point(50, 442);
            this.BtnAddCourse.Name = "BtnAddCourse";
            this.BtnAddCourse.Size = new System.Drawing.Size(186, 23);
            this.BtnAddCourse.TabIndex = 12;
            this.BtnAddCourse.Text = "Add";
            this.BtnAddCourse.UseVisualStyleBackColor = true;
            this.BtnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // BtnUpdateCourse
            // 
            this.BtnUpdateCourse.Location = new System.Drawing.Point(219, 399);
            this.BtnUpdateCourse.Name = "BtnUpdateCourse";
            this.BtnUpdateCourse.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateCourse.TabIndex = 11;
            this.BtnUpdateCourse.Text = "Update";
            this.BtnUpdateCourse.UseVisualStyleBackColor = true;
            this.BtnUpdateCourse.Click += new System.EventHandler(this.BtnUpdateCourse_Click);
            // 
            // BtnDeleteCourse
            // 
            this.BtnDeleteCourse.Location = new System.Drawing.Point(112, 399);
            this.BtnDeleteCourse.Name = "BtnDeleteCourse";
            this.BtnDeleteCourse.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteCourse.TabIndex = 10;
            this.BtnDeleteCourse.Text = "Delete";
            this.BtnDeleteCourse.UseVisualStyleBackColor = true;
            this.BtnDeleteCourse.Click += new System.EventHandler(this.BtnDeleteCourse_Click);
            // 
            // BtnClearCourse
            // 
            this.BtnClearCourse.Location = new System.Drawing.Point(10, 399);
            this.BtnClearCourse.Name = "BtnClearCourse";
            this.BtnClearCourse.Size = new System.Drawing.Size(75, 23);
            this.BtnClearCourse.TabIndex = 9;
            this.BtnClearCourse.Text = "Clear";
            this.BtnClearCourse.UseVisualStyleBackColor = true;
            this.BtnClearCourse.Click += new System.EventHandler(this.BtnClearCourse_Click);
            // 
            // GridViewCourse
            // 
            this.GridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCourse.Location = new System.Drawing.Point(328, 14);
            this.GridViewCourse.Name = "GridViewCourse";
            this.GridViewCourse.Size = new System.Drawing.Size(434, 451);
            this.GridViewCourse.TabIndex = 8;
            this.GridViewCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCourse_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Description";
            // 
            // DescriptionCourse
            // 
            this.DescriptionCourse.Location = new System.Drawing.Point(34, 289);
            this.DescriptionCourse.Name = "DescriptionCourse";
            this.DescriptionCourse.Size = new System.Drawing.Size(184, 96);
            this.DescriptionCourse.TabIndex = 6;
            this.DescriptionCourse.Text = "";
            // 
            // CheckBoxCourse
            // 
            this.CheckBoxCourse.AutoSize = true;
            this.CheckBoxCourse.Location = new System.Drawing.Point(107, 224);
            this.CheckBoxCourse.Name = "CheckBoxCourse";
            this.CheckBoxCourse.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxCourse.TabIndex = 5;
            this.CheckBoxCourse.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(90, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Active";
            // 
            // TxtCourseName
            // 
            this.TxtCourseName.Location = new System.Drawing.Point(32, 143);
            this.TxtCourseName.Name = "TxtCourseName";
            this.TxtCourseName.Size = new System.Drawing.Size(186, 20);
            this.TxtCourseName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name";
            // 
            // TxtCourseID
            // 
            this.TxtCourseID.Location = new System.Drawing.Point(72, 63);
            this.TxtCourseID.Name = "TxtCourseID";
            this.TxtCourseID.ReadOnly = true;
            this.TxtCourseID.Size = new System.Drawing.Size(100, 20);
            this.TxtCourseID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 518);
            this.Controls.Add(this.PanelCourse);
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.PanelCourse.ResumeLayout(false);
            this.PanelCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCourse;
        private System.Windows.Forms.Button BtnAddCourse;
        private System.Windows.Forms.Button BtnUpdateCourse;
        private System.Windows.Forms.Button BtnDeleteCourse;
        private System.Windows.Forms.Button BtnClearCourse;
        private System.Windows.Forms.DataGridView GridViewCourse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox DescriptionCourse;
        private System.Windows.Forms.CheckBox CheckBoxCourse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCourseName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCourseID;
        private System.Windows.Forms.Label label8;
    }
}