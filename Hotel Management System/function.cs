using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    internal class function
    {
        protected MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString =  "datasource=localhost; port=3306;username=root;password=; database = hms; ";
            return con;
        }
        public DataSet getData(string quary) //Get Data from database
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = quary;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(string quary, string message)
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.Connection.Open();
            cmd.CommandText = quary;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("'" + message +"'", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public MySqlDataReader getForCombo(String query)
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
           
    }
}
