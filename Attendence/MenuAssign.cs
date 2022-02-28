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
    public partial class MenuAssign : Form
    {
        public MenuAssign()
        {
            InitializeComponent();
        }

        private void BtnChangeClass_Click(object sender, EventArgs e)
        {
            ChangeStudentClassForm c = new ChangeStudentClassForm();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScheduleForm s = new ScheduleForm();
            s.Show();
        }
    }
}
