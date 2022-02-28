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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            BtnDeleteCourse.Enabled = false;
            GridStudent.AutoGenerateColumns = false;
            GridStudent.Columns.Add("stName", "Name");
            GridStudent.Columns["stName"].DataPropertyName = "Name";
            GridStudent.Columns.Add("stDate", "Birthdate");
            GridStudent.Columns["stDate"].DataPropertyName = "BirthDate";
            GridStudent.Columns.Add("stAddress", "Address");
            GridStudent.Columns["stAddress"].DataPropertyName = "Address";
            GridStudent.Columns.Add("stUsername", "Username");
            GridStudent.Columns["stUsername"].DataPropertyName = "Username";
            GridStudent.Columns.Add("stPassword", "Password");
            GridStudent.Columns["stPassword"].DataPropertyName = "Password";
            GridStudent.AutoResizeColumns();
            GridStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridStudent.ReadOnly = true;
            LoadStudent();  
        }
        void LoadStudent()
        { 
            GridStudent.DataSource = StudentDAO.GetAllStudent();
        }

        private void GridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            Student c = (Student)GridStudent.CurrentRow.DataBoundItem;
            if (c != null)
            {
                ShowInfoStudent(c);
            }
        }
        void ShowInfoStudent(Student c)
        {
            TxtUsername.Text = c.Username;
            TxtPass.Text = c.Password;
            TxtName.Text = c.Name;
            PickStudentDate.Value = c.BirthDate;
            TxtAddress.Text = c.Address;
        }

        private void BtnClearCourse_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            TxtUsername.Text = "";
            TxtPass.Text = "";
            TxtName.Text = "";
            PickStudentDate.Value = DateTime.Now;
            TxtAddress.Text = "";
        }

        private void BtnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (GridStudent.Rows.Count == 0)
            {
                return;
            }
            int index = Convert.ToInt32(GridStudent.CurrentCell.RowIndex);
            if (index < 0)
            {
                return;
            }
            Student C = (Student)GridStudent.CurrentRow.DataBoundItem;
            if (ValidateDAO.CheckStudentAvtive(C.AccountID))
            {
                LblConfirm.Text = "Student in avtive ! Can't be delete";
                return;
            }
            StudentDAO.DeleteStudent(C);
            LoadStudent();
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            string Username  = TxtUsername.Text;
            string Password = TxtPass.Text;
            string Name = TxtName.Text;
            DateTime BirthDate = PickStudentDate.Value;
            string Address = TxtAddress.Text;
            if (Name.Equals("") || Username.Equals("") || Password.Equals("") || Address.Equals(""))
            {
                MessageBox.Show("Fill all textbox!");
                return;
            }
            if (CheckUsernameExisted(Username))
            {
                MessageBox.Show("Username is existed!");
                return;
            }
            int Count = StudentDAO.AddStudent(Username,Password,Name,BirthDate,Address);
            if (Count != 0)
            {
                MessageBox.Show("Add Successfully");
                GridStudent.DataSource = null;
                GridStudent.DataSource = StudentDAO.GetAllStudent();
                Clear();
            }
            else
            {
                MessageBox.Show("Add Fail!");
            }
        }
        private bool CheckUsernameExisted(string name)
        {
            foreach (DataGridViewRow r in GridStudent.Rows)
            {
                if (r.Cells["stUsername"].Value.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckUsernameExistToUpdate(string name)
        {
            int index = GridStudent.CurrentCell.RowIndex;
            int count = -1;
            foreach (DataGridViewRow r in GridStudent.Rows)
            {
                count++;
                if (r.Cells["stUsername"].Value.Equals(name) && count != index)
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (GridStudent.Rows.Count == 0)
            {
                return;
            }
            string Username = TxtUsername.Text;
            string Password = TxtPass.Text;
            string Name = TxtName.Text;
            DateTime BirthDate = PickStudentDate.Value;
            string Address = TxtAddress.Text; ;
            if (Name.Equals("") || Username.Equals("") || Password.Equals("") || Address.Equals(""))
            {
                MessageBox.Show("Fill all textbox!");
                return;
            }
            if (CheckUsernameExistToUpdate(Username))
            {
                MessageBox.Show("Username Existed");
                return;
            }
            Student c = (Student)GridStudent.CurrentRow.DataBoundItem;

            int Count = StudentDAO.UpdateStudent(c.AccountID, Username, Password,Name,BirthDate,Address);
            if (Count != 0)
            {
                MessageBox.Show("Update Successfully");
                GridStudent.DataSource = null;
                GridStudent.DataSource = StudentDAO.GetAllStudent();
                Clear();
            }
            else
            {
                MessageBox.Show("Update Fail!");
            }
        }
    }
}
