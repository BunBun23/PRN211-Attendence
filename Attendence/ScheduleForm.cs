using Attendence.DAL;
using Attendence.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Attendence
{
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            LoadCboClass();
            LoadCboCourse();
            LoadCboTeacher();
            LoadCboRoom();
            LoadCboSlot();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("className","ClassName");
            dataGridView1.Columns["className"].DataPropertyName = "ClassName";
            dataGridView1.Columns.Add("courseName", "CourseName");
            dataGridView1.Columns["courseName"].DataPropertyName = "CourseName";
            dataGridView1.Columns.Add("roomName", "RoomName");
            dataGridView1.Columns["roomName"].DataPropertyName = "RoomName";
            dataGridView1.Columns.Add("teacherName", "TeacherName");
            dataGridView1.Columns["teacherName"].DataPropertyName = "TeacherName";
            dataGridView1.Columns.Add("slotName", "Slot");
            dataGridView1.Columns["slotName"].DataPropertyName = "SlotName";
            dataGridView1.Columns.Add("startDate", "StartDate");
            dataGridView1.Columns["startDate"].DataPropertyName = "StartDate";

            LoadSchedule();
        }
        void LoadCboClass()
        {
            CboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            CboClass.DisplayMember = "Name";
            CboClass.ValueMember = "ID";
            CboClass.DataSource = ClassDAO.GetAllClasss();
        }
        void LoadCboCourse()
        {
            CboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            CboCourse.DisplayMember = "Name";
            CboCourse.ValueMember = "ID";
            CboCourse.DataSource = CourseDAO.GetAllCourseActive();
        }
        void LoadCboTeacher()
        {
            CboTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            CboTeacher.DisplayMember = "Name";
            CboTeacher.ValueMember = "AccountID";
            CboTeacher.DataSource = TeacherDAO.GetAllTeacher(); 
        }
        void LoadCboRoom()
        {
            CboRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            CboRoom.DisplayMember = "Name";
            CboRoom.ValueMember = "ID";
            CboRoom.DataSource = RoomDAO.GetAllRoomActive();
        }
        void LoadCboSlot()
        {
            CboSlot.DropDownStyle = ComboBoxStyle.DropDownList;
            CboSlot.DisplayMember = "FullName";
            CboSlot.ValueMember = "ID";
            CboSlot.DataSource = SlotDAO.GetAllSlot(); 
        }
        void LoadSchedule()
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ScheduleDAO.GetAllSchedule();
        }
        private void BtnAssign_Click(object sender, EventArgs e)
        {
            int ClassID = Convert.ToInt32(CboClass.SelectedValue);
            int CourseID = Convert.ToInt32(CboCourse.SelectedValue);
            int TeacherID = Convert.ToInt32(CboTeacher.SelectedValue);
            int RoomID = Convert.ToInt32(CboRoom.SelectedValue);
            int SlotID = Convert.ToInt32(CboSlot.SelectedValue);
            DateTime StartDate = PickDate.Value;

            if (ValidateDAO.CheckClassHaveSlotInDateInput(ClassID,SlotID,StartDate))
            {
                LblConfirm.Text = "This Class Had Slot " + SlotID + " on " + StartDate.ToString("dd-MM-yyyy");
                return;
            }
            if (ValidateDAO.CheckRoomEmptyInSlotOnDate(RoomID,SlotID,StartDate))
            {
                LblConfirm.Text = "This Room Arready active in " + SlotID + " on " + StartDate.ToString("dd-MM-yyyy");
                return;
            }
            if (ValidateDAO.CheckTeacherActiveInSlotOnDate(TeacherID,SlotID,StartDate))
            {
                LblConfirm.Text = "This Teacher Arready active in " + SlotID + " on " + StartDate.ToString("dd-MM-yyyy");
                return;
            }
            Schedule s = new Schedule(CourseID,SlotID,ClassID, RoomID, 1, TeacherID, StartDate);
            int count = ScheduleDAO.AddSchedule(s);
            if(count == 0)
            {
                LblConfirm.Text = "Sorry, something went wrong!Try again";
                return;
            }
            LblConfirm.Text = "Add Sucsessfully!";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ScheduleDAO.GetAllSchedule();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                return;
            }
            int Index = dataGridView1.CurrentCell.RowIndex;
            Schedule s = (Schedule) dataGridView1.CurrentRow.DataBoundItem;
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime sDate = DateTime.ParseExact(s.StartDate.ToString("MM-dd-yyyy"), "MM-dd-yyyy", provider);
            DateTime nDate = DateTime.ParseExact(DateTime.Now.ToString("MM-dd-yyyy"), "MM-dd-yyyy", provider);
            if (sDate < nDate)
            {
                LblConfirm.Text = "Schedule could not be delete!";
                return;
            }
            if (ValidateDAO.CheckScheduleExist(s.ID))
            {
                LblConfirm.Text = "Schedule on active ! Can't delete";
                return;
            }
            int Count = ScheduleDAO.DeleteSchedule(s);
            if(Count == 0)
            {
                LblConfirm.Text = "Delete fail!";
                return;
            }
            LblConfirm.Text = "Delete Sucsessfully";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ScheduleDAO.GetAllSchedule();
        }
    }
}
