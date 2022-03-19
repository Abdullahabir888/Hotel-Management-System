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
    public partial class uc_checkout : UserControl
    {
        function fn = new function();
        string query;
        public uc_checkout()
        {
            InitializeComponent();
        }

        private void btnbooked_Click(object sender, EventArgs e)
        {
            if (txtcname.Text != "")
            {
                if(MessageBox.Show("Are Your ready for Checkout?","Confermation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    string cdate = txtcdate.Text;
                    query = "update customer set chekout ='Yes',checkout='"+cdate+"' where cid= "+id+ "; update rooms booked = 'No' where roomNo = '" + txtRoomno.Text + "' ";
                    fn.setData(query,"Checkout Successfully");
                    uc_checkout_Load(this,null);
                    clearAll();

                }

            }
            else
            {
                MessageBox.Show("There are no customer Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void uc_checkout_Load(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.contact,customer.nationality,customer.bod,customer.gender,customer.address,customer.nid,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where chekout = 'No'";

            DataSet ds = fn.getData(query);
            Datagrd.DataSource = ds.Tables[0];
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.contact,customer.nationality,customer.bod,customer.gender,customer.address,customer.nid,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where cname like '"+ txtname.Text + "%' and chekout = 'No'";
            DataSet ds = fn.getData(query);
            Datagrd.DataSource = ds.Tables[0];
        }
        int id;
        private void Datagrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Datagrd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(Datagrd.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtcname.Text = Datagrd.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomno.Text= Datagrd.Rows[e.RowIndex].Cells[9].Value.ToString();
            }

        }
        public void clearAll()

        {
            txtcname.Clear();
            txtname.Clear();
            txtRoomno.Clear();
            txtcdate.ResetText();
        }

        private void uc_checkout_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
