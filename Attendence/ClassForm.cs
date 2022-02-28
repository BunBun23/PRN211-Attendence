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
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            LoadClass();
            BtnDeleteClass.Enabled = false;
        }
        public void LoadClass()
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ClassDAO.GetAllClasss();
        }

        private void BtnClearClass_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnAddClass_Click(object sender, EventArgs e)
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
            int Count = ClassDAO.AddClass(new Class(Name, Des));
            if (Count != 0)
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

        private void BtnDeleteClass_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            int index = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex);
            if (index < 0)
            {
                return;
            }
            Class C = (Class)dataGridView1.CurrentRow.DataBoundItem;
            StudentDAO.RemoveStudentClass(C.ID);
            ScheduleDAO.RemoveScheduleByClassID(C.ID);
            ClassDAO.DeleteClassByID(C.ID);
            LoadClass();
        }

        private void BtnUpdateClass_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            string Name = ClassName.Text;
            string Des = Description.Text;
            if (Name.Equals(""))
            {
                MessageBox.Show("Fill all textbox!");
                return;
            }
            
            Class c = (Class)dataGridView1.CurrentRow.DataBoundItem;
            int Count = ClassDAO.UpdateClass(c.ID, Name, Des);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
        void ShowInfoClass(Class c)
        {
            ClassName.Text = c.Name;
            ClassID.Text = c.ID + "";
            Description.Text = c.Description;
        }
    }
}
