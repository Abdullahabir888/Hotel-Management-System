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
    public partial class Uc_customerdetails : UserControl
    {
        function fn = new function();
        string query;
        public Uc_customerdetails()
        {
            InitializeComponent();
        }

        private void txtsearc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtsearc.SelectedIndex == 0)
            {
                query = "select customer.cid,customer.cname,customer.contact,customer.nationality,customer.bod,customer.gender,customer.address,customer.nid,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid ";
               getRecord(query);
            } 
            else if(txtsearc.SelectedIndex == 1)
            {
                query = "select customer.cid,customer.cname,customer.contact,customer.nationality,customer.bod,customer.gender,customer.address,customer.nid,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid  where checkout is null";
                getRecord(query);
            
        }
            else if(txtsearc.SelectedIndex == 2)
            {
                query = "select customer.cid,customer.cname,customer.contact,customer.nationality,customer.bod,customer.gender,customer.address,customer.nid,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid = rooms.roomid  where checkout is not null";
                getRecord(query);
            

            }
        }
        private void getRecord(string query1)
        {
            DataSet ds = fn.getData(query1);
            da.DataSource = ds.Tables[0];
        }

        private void Uc_customerdetails_Load(object sender, EventArgs e)
        {

        }
    }
}
