
namespace Attendence
{
    partial class MenuAssign
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
            this.BtnChangeClass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnChangeClass
            // 
            this.BtnChangeClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeClass.Location = new System.Drawing.Point(33, 41);
            this.BtnChangeClass.Name = "BtnChangeClass";
            this.BtnChangeClass.Size = new System.Drawing.Size(165, 60);
            this.BtnChangeClass.TabIndex = 0;
            this.BtnChangeClass.Text = "ChangeStudentClass";
            this.BtnChangeClass.UseVisualStyleBackColor = true;
            this.BtnChangeClass.Click += new System.EventHandler(this.BtnChangeClass_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(256, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnChangeClass);
            this.Name = "MenuAssign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAssign";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnChangeClass;
        private System.Windows.Forms.Button button1;
    }
}