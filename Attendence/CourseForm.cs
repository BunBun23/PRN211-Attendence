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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
            BtnDeleteCourse.Enabled = false;
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadCourse();
        }
        public void LoadCourse()
        {
            GridViewCourse.AutoResizeColumns();
            GridViewCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridViewCourse.DataSource = CourseDAO.GetAllCourse();
        }

        private void BtnClearCourse_Click(object sender, EventArgs e)
        {
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
            ScheduleDAO.RemoveScheduleByCourseID(C.ID);
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
                if (!Active)
                {
                    ScheduleDAO.RemoveScheduleByCourseID(c.ID);
                }
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
    }
}
