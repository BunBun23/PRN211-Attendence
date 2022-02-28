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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            GridTeacher.AutoGenerateColumns = false;
            GridTeacher.Columns.Add("tName", "Name");
            GridTeacher.Columns["tName"].DataPropertyName = "Name";
            GridTeacher.Columns.Add("tDate", "Birthdate");
            GridTeacher.Columns["tDate"].DataPropertyName = "BirthDate";
            GridTeacher.Columns.Add("tAddress", "Address");
            GridTeacher.Columns["tAddress"].DataPropertyName = "Address";
            GridTeacher.Columns.Add("tUsername", "Username");
            GridTeacher.Columns["tUsername"].DataPropertyName = "Username";
            GridTeacher.Columns.Add("tPassword", "Password");
            GridTeacher.Columns["tPassword"].DataPropertyName = "Password";
            GridTeacher.AutoResizeColumns();
            GridTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridTeacher.ReadOnly = true;
            BtnDeleteTeacher.Enabled = false;

            LoadTeacher();
        }
        void LoadTeacher()
        {
            GridTeacher.DataSource = TeacherDAO.GetAllTeacher();
        }

        private void GridTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
            {
                return;
            }
            Teacher c = (Teacher)GridTeacher.CurrentRow.DataBoundItem;
            if (c != null)
            {
                ShowInfoTeacher(c);
            }
        }
        void ShowInfoTeacher(Teacher c)
        {
            TxtUsername.Text = c.Username;
            TxtPass.Text = c.Password;
            TxtName.Text = c.Name;
            PickTeacherDate.Value = c.BirthDate;
            TxtAddress.Text = c.Address;
        }

        private void BtnClearTeacher_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            TxtUsername.Text = "";
            TxtPass.Text = "";
            TxtName.Text = "";
            PickTeacherDate.Value = DateTime.Now;
            TxtAddress.Text = "";
        }

        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            string Username = TxtUsername.Text;
            string Password = TxtPass.Text;
            string Name = TxtName.Text;
            DateTime BirthDate = PickTeacherDate.Value;
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
            int Count = TeacherDAO.AddTeacher(Username, Password, Name, BirthDate, Address);
            if (Count != 0)
            {
                MessageBox.Show("Add Successfully");
                GridTeacher.DataSource = null;
                GridTeacher.DataSource = TeacherDAO.GetAllTeacher();
                Clear();
            }
            else
            {
                MessageBox.Show("Add Fail!");
            }
        }
        private bool CheckUsernameExisted(string name)
        {
            foreach (DataGridViewRow r in GridTeacher.Rows)
            {
                if (r.Cells["tUsername"].Value.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (GridTeacher.Rows.Count == 0)
            {
                return;
            }
            int index = Convert.ToInt32(GridTeacher.CurrentCell.RowIndex);
            if (index < 0)
            {
                return;
            }
            Teacher C = (Teacher)GridTeacher.CurrentRow.DataBoundItem;
            TeacherDAO.DeleteTeacher(C);
            LoadTeacher();
            Clear();
        }

        private void BtnUpdateTeacher_Click(object sender, EventArgs e)
        {
            if (GridTeacher.Rows.Count == 0)
            {
                return;
            }
            string Username = TxtUsername.Text;
            string Password = TxtPass.Text;
            string Name = TxtName.Text;
            DateTime BirthDate = PickTeacherDate.Value;
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
            Teacher c = (Teacher)GridTeacher.CurrentRow.DataBoundItem;

            int Count = TeacherDAO.UpdateTeacher(c.AccountID, Username, Password, Name, BirthDate, Address);
            if (Count != 0)
            {
                MessageBox.Show("Update Successfully");
                GridTeacher.DataSource = null;
                GridTeacher.DataSource = TeacherDAO.GetAllTeacher();
                Clear();
            }
            else
            {
                MessageBox.Show("Update Fail!");
            }
        }
        private bool CheckUsernameExistToUpdate(string name)
        {
            int index = GridTeacher.CurrentCell.RowIndex;
            int count = -1;
            foreach (DataGridViewRow r in GridTeacher.Rows)
            {
                count++;
                if (r.Cells["tUsername"].Value.Equals(name) && count != index)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
