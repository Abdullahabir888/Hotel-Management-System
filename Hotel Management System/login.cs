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
    public partial class login : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader cmd;
        public login()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            {
                new Registration().Show();
                this.Hide();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM hms.registration WHERE Username = '" + txtbox3.Text + "' AND Password = '" + txtbox5.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            cmd = command.ExecuteReader();
            if (cmd.Read())
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
            
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(selectQuery, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();

                MessageBox.Show("Login Successful!");
                this.Hide();

                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();
               

            }
            else
            {

                MessageBox.Show("Incorrect Login Information! Try again.");
            }

            connection.Close();

            if (string.IsNullOrEmpty(txtbox3.Text) || string.IsNullOrEmpty(txtbox5.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtbox5.PasswordChar = '\0';
            }
            else
            {
                txtbox5.PasswordChar = '*';
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void txtbox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
