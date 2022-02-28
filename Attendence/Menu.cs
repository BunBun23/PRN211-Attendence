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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            CourseForm c = new CourseForm();
            c.Show();
        }

        private void BtnRoom_Click(object sender, EventArgs e)
        {
            RoomForm r = new RoomForm();
            r.Show();
        }

        private void BtnClass_Click(object sender, EventArgs e)
        {
            ClassForm c = new ClassForm();
            c.Show();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            StudentForm s = new StudentForm();
            s.Show();
        }

        private void BtnTeacher_Click(object sender, EventArgs e)
        {
            TeacherForm t = new TeacherForm();
            t.Show();
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
            MenuAssign m = new MenuAssign();
            m.Show();
        }
    }
}
