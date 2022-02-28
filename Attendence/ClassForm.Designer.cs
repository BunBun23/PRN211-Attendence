
namespace Attendence
{
    partial class ClassForm
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
            this.PanelClass = new System.Windows.Forms.Panel();
            this.BtnClearClass = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUpdateClass = new System.Windows.Forms.Button();
            this.BtnDeleteClass = new System.Windows.Forms.Button();
            this.BtnAddClass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.ClassID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelClass
            // 
            this.PanelClass.Controls.Add(this.BtnClearClass);
            this.PanelClass.Controls.Add(this.dataGridView1);
            this.PanelClass.Controls.Add(this.BtnUpdateClass);
            this.PanelClass.Controls.Add(this.BtnDeleteClass);
            this.PanelClass.Controls.Add(this.BtnAddClass);
            this.PanelClass.Controls.Add(this.label4);
            this.PanelClass.Controls.Add(this.Description);
            this.PanelClass.Controls.Add(this.ClassID);
            this.PanelClass.Controls.Add(this.label2);
            this.PanelClass.Controls.Add(this.ClassName);
            this.PanelClass.Controls.Add(this.label1);
            this.PanelClass.Location = new System.Drawing.Point(12, 11);
            this.PanelClass.Name = "PanelClass";
            this.PanelClass.Size = new System.Drawing.Size(762, 487);
            this.PanelClass.TabIndex = 2;
            // 
            // BtnClearClass
            // 
            this.BtnClearClass.Location = new System.Drawing.Point(10, 420);
            this.BtnClearClass.Name = "BtnClearClass";
            this.BtnClearClass.Size = new System.Drawing.Size(75, 23);
            this.BtnClearClass.TabIndex = 13;
            this.BtnClearClass.Text = "Clear";
            this.BtnClearClass.UseVisualStyleBackColor = true;
            this.BtnClearClass.Click += new System.EventHandler(this.BtnClearClass_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 467);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnUpdateClass
            // 
            this.BtnUpdateClass.Location = new System.Drawing.Point(193, 420);
            this.BtnUpdateClass.Name = "BtnUpdateClass";
            this.BtnUpdateClass.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateClass.TabIndex = 11;
            this.BtnUpdateClass.Text = "Update";
            this.BtnUpdateClass.UseVisualStyleBackColor = true;
            this.BtnUpdateClass.Click += new System.EventHandler(this.BtnUpdateClass_Click);
            // 
            // BtnDeleteClass
            // 
            this.BtnDeleteClass.Location = new System.Drawing.Point(101, 420);
            this.BtnDeleteClass.Name = "BtnDeleteClass";
            this.BtnDeleteClass.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteClass.TabIndex = 10;
            this.BtnDeleteClass.Text = "Delete";
            this.BtnDeleteClass.UseVisualStyleBackColor = true;
            this.BtnDeleteClass.Click += new System.EventHandler(this.BtnDeleteClass_Click);
            // 
            // BtnAddClass
            // 
            this.BtnAddClass.Location = new System.Drawing.Point(32, 449);
            this.BtnAddClass.Name = "BtnAddClass";
            this.BtnAddClass.Size = new System.Drawing.Size(204, 23);
            this.BtnAddClass.TabIndex = 9;
            this.BtnAddClass.Text = "ADD";
            this.BtnAddClass.UseVisualStyleBackColor = true;
            this.BtnAddClass.Click += new System.EventHandler(this.BtnAddClass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description:";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(3, 262);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(294, 96);
            this.Description.TabIndex = 7;
            this.Description.Text = "";
            // 
            // ClassID
            // 
            this.ClassID.Location = new System.Drawing.Point(3, 51);
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Size = new System.Drawing.Size(294, 20);
            this.ClassID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class ID:";
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(7, 153);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(297, 20);
            this.ClassName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Name:";
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 510);
            this.Controls.Add(this.PanelClass);
            this.Name = "ClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassForm";
            this.Load += new System.EventHandler(this.ClassForm_Load);
            this.PanelClass.ResumeLayout(false);
            this.PanelClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelClass;
        private System.Windows.Forms.Button BtnClearClass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnUpdateClass;
        private System.Windows.Forms.Button BtnDeleteClass;
        private System.Windows.Forms.Button BtnAddClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.TextBox ClassID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.Label label1;
    }
}