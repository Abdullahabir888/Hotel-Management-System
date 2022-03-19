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
    public partial class Uc_addroom : UserControl
    {
        function fn = new function();
        string query;
        public Uc_addroom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Uc_addroom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds =  fn.getData(query);
            Datagridview1.DataSource = ds.Tables[0];
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            if (txtroomnum.Text != "" && txtroomty.Text != "" && txtbed.Text != "" && txtprice.Text != "")
            {

                string roomno = txtroomnum.Text;
                string type = txtroomty.Text;
                string bed = txtbed.Text;
                Int64 price = Int64.Parse(txtprice.Text);

                query = "insert into rooms (roomNo,roomType,bed,price) values('" + roomno + "','" + type + "','" + bed + "', " + price + ")";
                fn.setData(query, "Room Added.");

                Uc_addroom_Load(this, null);

            }
            else
            {
                MessageBox.Show("Fill The Details.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            public void clearAll ()
            {
                txtroomnum.Clear();
                txtroomty.SelectedIndex = -1;
                txtbed.SelectedIndex = -1;
                txtprice.Clear();
            }

        private void Uc_addroom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void Uc_addroom_Enter(object sender, EventArgs e)
        {
            Uc_addroom_Load(this, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtroomnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Datagridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtroomty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtbed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

