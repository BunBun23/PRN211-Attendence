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
    public partial class ChangeStudentClassForm : Form
    {
        public ChangeStudentClassForm()
        {
            InitializeComponent();
        }

        private void ChangeStudentClassForm_Load(object sender, EventArgs e)
        {
            GridStudent.AutoGenerateColumns = false;
            GridStudent.Columns.Add("stName", "Name");
            GridStudent.Columns["stName"].DataPropertyName = "Name";
            GridStudent.Columns.Add("stDate", "Birthdate");
            GridStudent.Columns["stDate"].DataPropertyName = "BirthDate";
            GridStudent.Columns.Add("stAddress", "Address");
            GridStudent.Columns["stAddress"].DataPropertyName = "Address";
            GridStudent.AutoResizeColumns();
            GridStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridStudent.ReadOnly = true;
            LoadStudent();

            GridStudentClass.AutoGenerateColumns = false;
            GridStudentClass.Columns.Add("stName", "Name");
            GridStudentClass.Columns["stName"].DataPropertyName = "Name";
            GridStudentClass.Columns.Add("stDate", "Birthdate");
            GridStudentClass.Columns["stDate"].DataPropertyName = "BirthDate";
            GridStudentClass.Columns.Add("stAddress", "Address");
            GridStudentClass.Columns["stAddress"].DataPropertyName = "Address";
            GridStudentClass.AutoResizeColumns();
            GridStudentClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridStudentClass.ReadOnly = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            LoadClass();
        }
        public void LoadClass()
        {
            comboBox1.DataSource = ClassDAO.GetAllClasss();
        }
        void LoadStudent()
        {
            GridStudent.DataSource = StudentDAO.GetAllStudentEmptyClass();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ClassID = Convert.ToInt32(comboBox1.SelectedValue);
            GridStudentClass.DataSource = null;
            GridStudentClass.DataSource = StudentDAO.GetAllStudentByClassID(ClassID); 
        }
        void LoadStudentCbo()
        {
            int ClassID = Convert.ToInt32(comboBox1.SelectedValue);
            GridStudentClass.DataSource = null;
            GridStudentClass.DataSource = StudentDAO.GetAllStudentByClassID(ClassID);
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (GridStudent.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = GridStudent.SelectedCells[0].RowIndex;
                Student s = (Student)GridStudent.CurrentRow.DataBoundItem;
                StudentDAO.UpdateClassStudent(s,(int)comboBox1.SelectedValue);

                LoadStudent();
                LoadStudentCbo();
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (GridStudentClass.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = GridStudentClass.SelectedCells[0].RowIndex;
                Student s = (Student)GridStudentClass.CurrentRow.DataBoundItem;
                StudentDAO.UpdateClassStudentByNull(s);

                LoadStudent();
                LoadStudentCbo();
            }
        }
    }
}
