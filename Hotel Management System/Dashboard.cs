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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void uc_addroom1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uc_employee1.Visible = true;
            uc_employee1.BringToFront();    
        }

        private void gbtn1_Click(object sender, EventArgs e)
        {
            uc_addroom1.Visible = true;

            uc_addroom1.BringToFront();
            
        }

        private void uc_addroom1_Load_1(object sender, EventArgs e)
        {

            

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uc_addroom1.Visible = false;
            uc_Customer1.Visible = false;
            gbtn1.PerformClick();
        }

      

        private void uc_customerreg1_Load(object sender, EventArgs e)
        {

        }

        private void uc_addroom1_Load_2(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          uc_Customer1.Visible = true;

            uc_Customer1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uc_checkout1.Visible = true;
            uc_checkout1.BringToFront();
        }

        private void uc_checkout1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uc_customerdetails1.Visible = true;
            uc_customerdetails1.BringToFront();
        }

        private void uc_employee1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }
    }
}
