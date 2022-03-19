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

namespace Hotel_Management_System.All_Control_Panal
{
    public partial class Uc_employee : UserControl
    {
        function fn = new function();
        string query;
        public Uc_employee()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Uc_employee_Load(object sender, EventArgs e)
        {

            getMaxID();
        }
        public void getMaxID()
        {
            query = "Select max(eid)from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                Id1.Text = (num + 1).ToString();
            }
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            if (txtnam.Text != "" && txtmob.Text != "" && txtgen.Text != "" && txtpos.Text != "" && txtem.Text != ""  && txtuse.Text != "" && txtpass.Text != "" )
            {
                string name = txtnam.Text;
                Int64 mobile = Int64.Parse(txtmob.Text);
                string gender = txtgen.Text;
                string position = txtpos.Text;
                string email = txtem.Text;
                string user = txtuse.Text;
                string password = txtpass.Text;

                query = "insert into employee (ename,mobile,gender,email,position,username,Password) values('" + name + "',"+mobile+ ",'" + gender + "','" + email + "', '" + position + "','" + user + "','" + password + "')";
                fn.setData(query, "Emplyoee Register  Successfully");
                getMaxID();
                clearAll();

            }
            else
            {
                MessageBox.Show("Fill All Information", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()

        {
            txtnam.Clear();
            txtmob.Clear();
            txtgen.SelectedIndex = -1;
            txtem.Clear();
            txtpos.SelectedIndex = -1;
            txtuse.Clear();
            txtpass.Clear();
            
        }

        private void uc_checkout_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                setEmployee(data);

            }
            else if (tabControl1.SelectedIndex == 2)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query);
                data2.DataSource = ds.Tables[0];
            }
        }
        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (MessageBox.Show("Are Ready To Delete Information !", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid=" + txtId.Text + "";
                    fn.setData(query, "Deleted  Successfully");
                    tabControl1_SelectedIndexChange(this, null);
                }
            }


        }

        private void tabControl1_SelectedIndexChange(Uc_employee uc_employee, object p)
        {
            throw new NotImplementedException();
        }

        private void Uc_employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }
    }
}


