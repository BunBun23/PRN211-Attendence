using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Attendence.DAL;
using Attendence.Entity;

namespace Attendence
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadClass();
            LoadRoom();
            LoadCourse();
            PanelClass.Show();
            PanelRoom.Hide();
            PanelCourse.Hide();
        }

        private void manageMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelClass.Hide();
        }
        private void addClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelCourse.Hide();
            PanelRoom.Hide();
            PanelClass.Show();
        }
        public void LoadClass()
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ClassDAO.GetAllClasss();
        }
        public void LoadCourse()
        {
            GridViewCourse.AutoResizeColumns();
            GridViewCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridViewCourse.DataSource = CourseDAO.GetAllCourse();
        }
        void ShowInfoClass(Class c)
        {
            ClassName.Text = c.Name;
            ClassID.Text = c.ID + "";
            Description.Text = c.Description;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string Name = ClassName.Text;
            string Des = Description.Text;
            if (Name.Equals("") || Des.Equals(""))
            {
                MessageBox.Show("Fill all textbox!");
                return;
            }
            if (CheckClassNameExisted(Name))
            {
                MessageBox.Show("Input another name!");
                return;
            }
            int Count = ClassDAO.AddClass(new Class(Name,Des));
            if(Count != 0)
            {
                MessageBox.Show("Add Successfully");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ClassDAO.GetAllClasss();
                Clear();
            }
            else
            {
                MessageBox.Show("Add Fail!");
            }
        }
        void Clear()
        {
            ClassName.Text = "";
            ClassID.Text = "";
            Description.Text = "";
        }
        bool CheckClassNameExisted(string Name)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.Cells["Name"].Value.Equals(Name))
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            int index = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex);
            if(index < 0)
            {
                return;
            }
            Class C = (Class)dataGridView1.CurrentRow.DataBoundItem;
            ClassDAO.DeleteClassByID(C.ID);
            LoadClass();
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            Class c = (Class)dataGridView1.CurrentRow.DataBoundItem;
            if (c != null)
            {
                ShowInfoClass(c);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelCourse.Hide();
            PanelClass.Hide();
            PanelRoom.Show();
        }
        public void LoadRoom()
        {
            DataGridViewRoom.AutoResizeColumns();
            DataGridViewRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewRoom.ReadOnly = true;
            DataGridViewRoom.DataSource = RoomDAO.GetAllRoom();
        }

        private void BtnUpdateClass_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                return;
            }
            string Name = ClassName.Text;
            string Des = Description.Text;
            if (Name.Equals("") || Des.Equals(""))
            {
                MessageBox.Show("Fill all textbox!");
                return;
            }
            int Number;
            try
            {
                Number = Convert.ToInt32(NumberStudent.Text);

            }
            catch (Exception e1)
            {
                MessageBox.Show("Number student must be integer !");
                return;
            }
            Class c = (Class)dataGridView1.CurrentRow.DataBoundItem;
            int Count = ClassDAO.UpdateClass(c.ID,Name, Des);
            if (Count != 0)
            {
                MessageBox.Show("Update Successfully");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ClassDAO.GetAllClasss();
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
            int Count = RoomDAO.AddRoom(new Room(Name,Active));
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

        private void btnRoomClear_Click(object sender, EventArgs e)
        {
            TxtRoomName.Text = "";
            TxtRoomID.Text = "";
            checkBox1.Checked = false;
        }

        private void DataGridViewRoom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelRoom.Hide();
            PanelClass.Hide();
            PanelCourse.Show();
        }

        private void BtnClearCourse_Click(object sender, EventArgs e)
        {
            ClearCourse();
            ClearCourse();
        }
        void ClearCourse()
        {
            TxtCourseID.Text = "";
            TxtCourseName.Text = "";
            CheckBoxCourse.Checked = false;
            DescriptionCourse.Text = "";
        }
        private void BtnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (GridViewCourse.Rows.Count == 0)
            {
                return;
            }
            int index = Convert.ToInt32(GridViewCourse.CurrentCell.RowIndex);
            if (index < 0)
            {
                return;
            }
            Course C = (Course)GridViewCourse.CurrentRow.DataBoundItem;
            CourseDAO.DeleteCourseByID(C.ID);
            LoadCourse();
        }

        private void BtnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (GridViewCourse.Rows.Count == 0)
            {
                return;
            }
            string Name = TxtCourseName.Text;
            string Des = DescriptionCourse.Text;
            bool Active = CheckBoxCourse.Checked;
            if (Name.Equals(""))
            {
                MessageBox.Show("Fill all textbox!");
                return;
            }
            Course c = (Course)GridViewCourse.CurrentRow.DataBoundItem;
            int Count = CourseDAO.UpdateCourse(c.ID, Name, Active, Des);
            if (Count != 0)
            {
                MessageBox.Show("Update Successfully");
                GridViewCourse.DataSource = null;
                GridViewCourse.DataSource = CourseDAO.GetAllCourse();
                ClearCourse();
            }
            else
            {
                MessageBox.Show("Update Fail!");
            }
        }

        private void GridViewCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            Course c = (Course)GridViewCourse.CurrentRow.DataBoundItem;
            if (c != null)
            {
                ShowInfoCourse(c);
            }
        }

        private void ShowInfoCourse(Course c)
        {
            TxtCourseID.Text = c.ID + "";
            TxtCourseName.Text = c.Name;
            DescriptionCourse.Text = c.Description;
            CheckBoxCourse.Checked = c.Activity;
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            string Name = TxtCourseName.Text;
            bool Active = CheckBoxCourse.Checked;
            string Des = DescriptionCourse.Text;
            if (Name.Equals(""))
            {
                MessageBox.Show("Fill all textbox!");
                return;
            }
            if (CheckCourseNameExisted(Name))
            {
                MessageBox.Show("Course name is existed!");
                return;
            }
            int Count = CourseDAO.AddCourse(new Course(Name, Active, Des));
            if (Count != 0)
            {
                MessageBox.Show("Add Successfully");
                GridViewCourse.DataSource = null;
                GridViewCourse.DataSource = CourseDAO.GetAllCourse();
                ClearCourse();
            }
            else
            {
                MessageBox.Show("Add Fail!");
            }
        }

        private bool CheckCourseNameExisted(string name)
        {
            foreach (DataGridViewRow r in GridViewCourse.Rows)
            {
                if (r.Cells["Name"].Value.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
