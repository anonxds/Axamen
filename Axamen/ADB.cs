using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axamen
{
    class ADB
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataAdapter db;

        private void setcon()
        {
            con = new MySqlConnection("Server=traficdb.mysql.database.azure.com; Port=3306; Database=Parras; Uid=orlando@traficdb; Pwd=Bejeweled2012; SslMode=Preferred;");
        }
        public void dgrid(DataGridView dg, string query)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            db = new MySqlDataAdapter(query, con);
            ds.Reset();
            db.Fill(ds);
            dt = ds.Tables[0];
            dg.DataSource = dt;
            con.Close();
        }
        public void Exe(String query)
        {
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

        }       

        public void populate(ComboBox cb, string query, string type)
        {
            setcon();
            cb.Items.Clear();
            con.Open();


            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter db = new MySqlDataAdapter(cmd);
            db.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cb.Items.Add(dr[type]).ToString();
            }
            con.Close();

        }
    }
}
