using Attendence.DAL;
using Attendence.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Attendence
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            LoadRoom();
            BtnRoomDelete.Enabled = false;
        }
        public void LoadRoom()
        {
            DataGridViewRoom.AutoResizeColumns();
            DataGridViewRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewRoom.ReadOnly = true;
            DataGridViewRoom.DataSource = RoomDAO.GetAllRoom();
        }

        private void btnRoomClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            TxtRoomName.Text = "";
            TxtRoomID.Text = "";
            checkBox1.Checked = false;
        }

        private void BtnRoomDelete_Click(object sender, EventArgs e)
        {
            if (DataGridViewRoom.Rows.Count == 0)
            {
                return;
            }
            int index = Convert.ToInt32(DataGridViewRoom.CurrentCell.RowIndex);
            if (index < 0)
            {
                return;
            }
            Room C = (Room)DataGridViewRoom.CurrentRow.DataBoundItem;
            ScheduleDAO.RemoveScheduleByRoomID(C.ID);
            RoomDAO.DeleteRoomByID(C.ID);
            LoadRoom();
        }

        private void BtnRoomUpdate_Click(object sender, EventArgs e)
        {
            if (DataGridViewRoom.Rows.Count == 0)
            {
                return;
            }
            string Name = TxtRoomName.Text;
            bool Active = checkBox1.Checked;
            if (Name.Equals(""))
            {
                MessageBox.Show("Fill all textbox!");
                return;
            }

            Room c = (Room)DataGridViewRoom.CurrentRow.DataBoundItem;
            int Count = RoomDAO.UpdateRoom(c.ID, Name, Active);
            if (Count != 0)
            {
                if (!Active)
                {
                    ScheduleDAO.RemoveScheduleByRoomID(c.ID);
                }
                MessageBox.Show("Update Successfully");
                DataGridViewRoom.DataSource = null;
                DataGridViewRoom.DataSource = RoomDAO.GetAllRoom();
                Clear();
            }
            else
            {
                MessageBox.Show("Update Fail!");
            }
        }

        private void BtnRoomAdd_Click(object sender, EventArgs e)
        {
            string Name = TxtRoomName.Text;
            bool Active = checkBox1.Checked;
            if (Name.Equals(""))
            {
                MessageBox.Show("Fill all textbox!");
                return;
            }
            if (CheckRoomNameExisted(Name))
            {
                MessageBox.Show("Input another name!");
                return;
            }
            int Count = RoomDAO.AddRoom(new Room(Name, Active));
            if (Count != 0)
            {
                MessageBox.Show("Add Successfully");
                DataGridViewRoom.DataSource = null;
                DataGridViewRoom.DataSource = RoomDAO.GetAllRoom();
                Clear();
            }
            else
            {
                MessageBox.Show("Add Fail!");
            }
        }

        private void DataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            Room c = (Room)DataGridViewRoom.CurrentRow.DataBoundItem;
            if (c != null)
            {
                ShowInfoRoom(c);
            }
        }
        private void ShowInfoRoom(Room c)
        {
            TxtRoomID.Text = c.ID + "";
            TxtRoomName.Text = c.Name;
            checkBox1.Checked = c.Activity;
        }
        private bool CheckRoomNameExisted(string name)
        {
            foreach (DataGridViewRow r in DataGridViewRoom.Rows)
            {
                if (r.Cells["Name"].Value.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
