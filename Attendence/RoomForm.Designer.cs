
namespace Attendence
{
    partial class RoomForm
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
            this.PanelRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRoom)).BeginInit();
            this.SuspendLayout();
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
            this.PanelRoom.Location = new System.Drawing.Point(12, 12);
            this.PanelRoom.Name = "PanelRoom";
            this.PanelRoom.Size = new System.Drawing.Size(740, 487);
            this.PanelRoom.TabIndex = 15;
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
            this.DataGridViewRoom.Size = new System.Drawing.Size(412, 481);
            this.DataGridViewRoom.TabIndex = 0;
            this.DataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewRoom_CellClick);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 519);
            this.Controls.Add(this.PanelRoom);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassForm";
            this.Load += new System.EventHandler(this.ClassForm_Load);
            this.PanelRoom.ResumeLayout(false);
            this.PanelRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRoom;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox TxtRoomName;
        private System.Windows.Forms.TextBox TxtRoomID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnRoomAdd;
        private System.Windows.Forms.Button BtnRoomUpdate;
        private System.Windows.Forms.Button BtnRoomDelete;
        private System.Windows.Forms.Button btnRoomClear;
        private System.Windows.Forms.DataGridView DataGridViewRoom;
    }
}