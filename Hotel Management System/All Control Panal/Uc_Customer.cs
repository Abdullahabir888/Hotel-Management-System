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

    public partial class Uc_Customer : UserControl
    {
        function fn = new function();
        string query;
        public Uc_Customer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uc_Customer_Load(object sender, EventArgs e)
        {

        }
        public void setComboBox(string query, ComboBox combo)
        {
            MySqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));

                }
            }
            sdr.Close();
        }

        private void txtroomty_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            query = "Select roomNo from rooms where bed= '" +txtbed.Text+ "' and roomType = '" +txtroomt.Text+ "' and booked ='No' ";
            setComboBox(query, txtRoomNo);
        }

        private void txtbed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtroomt.SelectedIndex = -1;
            txtRoomNo.Items.Clear ();
        }
       
        int rid;
        private void txtroomnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "Select price,roomid from rooms where roomNo = '" + txtRoomNo.Text + "' ";
            DataSet ds = fn.getData(query);
            txtprice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid= int.Parse(ds.Tables[0].Rows[0][1].ToString());

        }

        private void btnbooked_Click(object sender, EventArgs e)
        {
            if(txtname.Text != ""&& txtnum.Text !=""&& txtnan.Text !=""&& txtbod.Text != "" && txtgen.Text != "" && txtadr.Text != "" && txtnid.Text != "" && txtin.Text != "" && txtmth.Text != "" && txtprice.Text !="")
            {
                string name = txtname.Text;
                Int64 contact = Int64.Parse(txtnum.Text);
                string nationality = txtnan.Text;
                string birthday = txtbod.Text;
                string gender = txtgen.Text;
                string address = txtadr.Text;
                string nid = txtnid.Text;
                string checkin= txtin.Text;
                string method =txtmth.Text;
                

                query = "insert into customer (cname,contact,nationality,bod,gender,address,nid,checkin,method,roomid) values ('" + name + "', " + contact + ", '" + nationality + "', '" + birthday + "', '" + gender + "', '" + address + "','" + nid + "', '" + checkin + "','" + method + "', " + rid + "); update rooms set booked='Yes' where roomNo='"+txtRoomNo.Text+"'";
                fn.setData(query, "Room Number "+txtRoomNo.Text+" Booked Successfully");
            }
            else
            {
                MessageBox.Show("Fill All The Information." ,"Information" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
