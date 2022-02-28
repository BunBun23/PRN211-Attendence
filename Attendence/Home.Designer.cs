
namespace Attendence
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageResourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelClass = new System.Windows.Forms.Panel();
            this.BtnClearClass = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUpdateClass = new System.Windows.Forms.Button();
            this.BtnDeleteClass = new System.Windows.Forms.Button();
            this.BtnAddClass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.NumberStudent = new System.Windows.Forms.TextBox();
            this.ClassID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelRoom = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TxtRoomName = new System.Windows.Forms.TextBox();
            this.TxtRoomID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnRoomAdd = new System.Windows.Forms.Button();
            this.BtnRoomUpdate = new System.Windows.Forms.Button();
            this.BtnRoomDelete = new System.Windows.Forms.Button();
            this.btnRoomClear = new System.Windows.Forms.Button();
            this.DataGridViewRoom = new System.Windows.Forms.DataGridView();
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
            this.menuStrip1.SuspendLayout();
            this.PanelClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRoom)).BeginInit();
            this.PanelCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageResourseToolStripMenuItem,
            this.manageMemberToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageResourseToolStripMenuItem
            // 
            this.manageResourseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClassToolStripMenuItem,
            this.addRoomToolStripMenuItem,
            this.manageCourseToolStripMenuItem});
            this.manageResourseToolStripMenuItem.Name = "manageResourseToolStripMenuItem";
            this.manageResourseToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.manageResourseToolStripMenuItem.Text = "Resourse";
            // 
            // addClassToolStripMenuItem
            // 
            this.addClassToolStripMenuItem.Name = "addClassToolStripMenuItem";
            this.addClassToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addClassToolStripMenuItem.Text = "Manage Class";
            this.addClassToolStripMenuItem.Click += new System.EventHandler(this.addClassToolStripMenuItem_Click);
            // 
            // addRoomToolStripMenuItem
            // 
            this.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            this.addRoomToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addRoomToolStripMenuItem.Text = "Manage Room";
            this.addRoomToolStripMenuItem.Click += new System.EventHandler(this.addRoomToolStripMenuItem_Click);
            // 
            // manageCourseToolStripMenuItem
            // 
            this.manageCourseToolStripMenuItem.Name = "manageCourseToolStripMenuItem";
            this.manageCourseToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.manageCourseToolStripMenuItem.Text = "Manage Course";
            this.manageCourseToolStripMenuItem.Click += new System.EventHandler(this.manageCourseToolStripMenuItem_Click);
            // 
            // manageMemberToolStripMenuItem
            // 
            this.manageMemberToolStripMenuItem.Name = "manageMemberToolStripMenuItem";
            this.manageMemberToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.manageMemberToolStripMenuItem.Text = "Manage Member";
            this.manageMemberToolStripMenuItem.Click += new System.EventHandler(this.manageMemberToolStripMenuItem_Click);
            // 
            // PanelClass
            // 
            this.PanelClass.Controls.Add(this.BtnClearClass);
            this.PanelClass.Controls.Add(this.PanelRoom);
            this.PanelClass.Controls.Add(this.dataGridView1);
            this.PanelClass.Controls.Add(this.BtnUpdateClass);
            this.PanelClass.Controls.Add(this.BtnDeleteClass);
            this.PanelClass.Controls.Add(this.BtnAddClass);
            this.PanelClass.Controls.Add(this.label4);
            this.PanelClass.Controls.Add(this.Description);
            this.PanelClass.Controls.Add(this.NumberStudent);
            this.PanelClass.Controls.Add(this.ClassID);
            this.PanelClass.Controls.Add(this.label3);
            this.PanelClass.Controls.Add(this.label2);
            this.PanelClass.Controls.Add(this.ClassName);
            this.PanelClass.Controls.Add(this.label1);
            this.PanelClass.Location = new System.Drawing.Point(12, 46);
            this.PanelClass.Name = "PanelClass";
            this.PanelClass.Size = new System.Drawing.Size(762, 487);
            this.PanelClass.TabIndex = 1;
            // 
            // BtnClearClass
            // 
            this.BtnClearClass.Location = new System.Drawing.Point(10, 420);
            this.BtnClearClass.Name = "BtnClearClass";
            this.BtnClearClass.Size = new System.Drawing.Size(75, 23);
            this.BtnClearClass.TabIndex = 13;
            this.BtnClearClass.Text = "Clear";
            this.BtnClearClass.UseVisualStyleBackColor = true;
            this.BtnClearClass.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 451);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            this.BtnDeleteClass.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAddClass
            // 
            this.BtnAddClass.Location = new System.Drawing.Point(32, 449);
            this.BtnAddClass.Name = "BtnAddClass";
            this.BtnAddClass.Size = new System.Drawing.Size(204, 23);
            this.BtnAddClass.TabIndex = 9;
            this.BtnAddClass.Text = "ADD";
            this.BtnAddClass.UseVisualStyleBackColor = true;
            this.BtnAddClass.Click += new System.EventHandler(this.BtnAdd_Click);
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
            // NumberStudent
            // 
            this.NumberStudent.Location = new System.Drawing.Point(163, 154);
            this.NumberStudent.Name = "NumberStudent";
            this.NumberStudent.Size = new System.Drawing.Size(131, 20);
            this.NumberStudent.TabIndex = 6;
            // 
            // ClassID
            // 
            this.ClassID.Location = new System.Drawing.Point(3, 154);
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Size = new System.Drawing.Size(109, 20);
            this.ClassID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "NumberStudent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class ID:";
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(7, 48);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(297, 20);
            this.ClassName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelRoom
            // 
            this.PanelRoom.Controls.Add(this.checkBox1);
            this.PanelRoom.Controls.Add(this.TxtRoomName);
            this.PanelRoom.Controls.Add(this.TxtRoomID);
            this.PanelRoom.Controls.Add(this.label7);
            this.PanelRoom.Controls.Add(this.label6);
            this.PanelRoom.Controls.Add(this.label5);
            this.PanelRoom.Controls.Add(this.BtnRoomAdd);
            this.PanelRoom.Controls.Add(this.BtnRoomUpdate);
            this.PanelRoom.Controls.Add(this.BtnRoomDelete);
            this.PanelRoom.Controls.Add(this.btnRoomClear);
            this.PanelRoom.Controls.Add(this.DataGridViewRoom);
            this.PanelRoom.Location = new System.Drawing.Point(510, 236);
            this.PanelRoom.Name = "PanelRoom";
            this.PanelRoom.Size = new System.Drawing.Size(740, 487);
            this.PanelRoom.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(130, 285);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TxtRoomName
            // 
            this.TxtRoomName.Location = new System.Drawing.Point(32, 180);
            this.TxtRoomName.Name = "TxtRoomName";
            this.TxtRoomName.Size = new System.Drawing.Size(186, 20);
            this.TxtRoomName.TabIndex = 9;
            // 
            // TxtRoomID
            // 
            this.TxtRoomID.Location = new System.Drawing.Point(32, 74);
            this.TxtRoomID.Name = "TxtRoomID";
            this.TxtRoomID.ReadOnly = true;
            this.TxtRoomID.Size = new System.Drawing.Size(186, 20);
            this.TxtRoomID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Active";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID";
            // 
            // BtnRoomAdd
            // 
            this.BtnRoomAdd.Location = new System.Drawing.Point(50, 407);
            this.BtnRoomAdd.Name = "BtnRoomAdd";
            this.BtnRoomAdd.Size = new System.Drawing.Size(186, 23);
            this.BtnRoomAdd.TabIndex = 4;
            this.BtnRoomAdd.Text = "Add";
            this.BtnRoomAdd.UseVisualStyleBackColor = true;
            this.BtnRoomAdd.Click += new System.EventHandler(this.BtnRoomAdd_Click);
            // 
            // BtnRoomUpdate
            // 
            this.BtnRoomUpdate.Location = new System.Drawing.Point(219, 364);
            this.BtnRoomUpdate.Name = "BtnRoomUpdate";
            this.BtnRoomUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnRoomUpdate.TabIndex = 3;
            this.BtnRoomUpdate.Text = "Update";
            this.BtnRoomUpdate.UseVisualStyleBackColor = true;
            this.BtnRoomUpdate.Click += new System.EventHandler(this.BtnRoomUpdate_Click);
            // 
            // BtnRoomDelete
            // 
            this.BtnRoomDelete.Location = new System.Drawing.Point(112, 364);
            this.BtnRoomDelete.Name = "BtnRoomDelete";
            this.BtnRoomDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnRoomDelete.TabIndex = 2;
            this.BtnRoomDelete.Text = "Delete";
            this.BtnRoomDelete.UseVisualStyleBackColor = true;
            this.BtnRoomDelete.Click += new System.EventHandler(this.BtnRoomDelete_Click);
            // 
            // btnRoomClear
            // 
            this.btnRoomClear.Location = new System.Drawing.Point(10, 364);
            this.btnRoomClear.Name = "btnRoomClear";
            this.btnRoomClear.Size = new System.Drawing.Size(75, 23);
            this.btnRoomClear.TabIndex = 1;
            this.btnRoomClear.Text = "Clear";
            this.btnRoomClear.UseVisualStyleBackColor = true;
            this.btnRoomClear.Click += new System.EventHandler(this.btnRoomClear_Click);
            // 
            // DataGridViewRoom
            // 
            this.DataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRoom.Location = new System.Drawing.Point(328, 3);
            this.DataGridViewRoom.Name = "DataGridViewRoom";
            this.DataGridViewRoom.Size = new System.Drawing.Size(431, 469);
            this.DataGridViewRoom.TabIndex = 0;
            this.DataGridViewRoom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewRoom_CellDoubleClick);
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
            this.PanelCourse.Location = new System.Drawing.Point(1026, 148);
            this.PanelCourse.Name = "PanelCourse";
            this.PanelCourse.Size = new System.Drawing.Size(762, 487);
            this.PanelCourse.TabIndex = 11;
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 720);
            this.Controls.Add(this.PanelCourse);
            this.Controls.Add(this.PanelClass);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelClass.ResumeLayout(false);
            this.PanelClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelRoom.ResumeLayout(false);
            this.PanelRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRoom)).EndInit();
            this.PanelCourse.ResumeLayout(false);
            this.PanelCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageResourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMemberToolStripMenuItem;
        private System.Windows.Forms.Panel PanelClass;
        private System.Windows.Forms.ToolStripMenuItem addClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCourseToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.TextBox NumberStudent;
        private System.Windows.Forms.TextBox ClassID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUpdateClass;
        private System.Windows.Forms.Button BtnDeleteClass;
        private System.Windows.Forms.Button BtnAddClass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnClearClass;
        private System.Windows.Forms.Panel PanelRoom;
        private System.Windows.Forms.Button BtnRoomAdd;
        private System.Windows.Forms.Button BtnRoomUpdate;
        private System.Windows.Forms.Button BtnRoomDelete;
        private System.Windows.Forms.Button btnRoomClear;
        private System.Windows.Forms.DataGridView DataGridViewRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox TxtRoomName;
        private System.Windows.Forms.TextBox TxtRoomID;
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