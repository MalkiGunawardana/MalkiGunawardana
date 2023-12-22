using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class LoginForm : Form
    {
        DBConnect connect = new DBConnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblCancel_MouseEnter(object sender, EventArgs e)
        {
            lblCancel.ForeColor = Color.Red;
        }

        private void lblCancel_MouseLeave(object sender, EventArgs e)
        {
            lblCancel.ForeColor = Color.Black;
        }

        private void lblCancel_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Equals("") || txtPassword.Text == "")
            {
                MessageBox.Show("Enter your username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string selectquery = "SELECT * FROM `users` WHERE 'Username'=@usn AND 'Password'=@pass";
                MySqlCommand command = new MySqlCommand(selectquery, connect.GetConnection());
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtUsername.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);


                if (table.Rows.Count >= 0)
                {
                    this.Hide();
                    mainForm mainForm = new mainForm();
                    mainForm.Show();
                    //MessageBox.Show("Your username and Password doen's exists", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    MessageBox.Show("Your username and Password doen's exists", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Blue;
            

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }
    }
}
