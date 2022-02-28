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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username.Equals("") || password.Equals(""))
            {
                label3.Text = "Fill all username and password";
                return;
            }
            Admin admin = AdminDAO.GetAdminByUserNameAndPassword(username, password);
            if (admin == null)
            {
                label3.Text = "Username or password is wrong !";
                return;
            }
            Menu home = new Menu();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
