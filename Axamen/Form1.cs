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

namespace Axamen
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=traficdb.mysql.database.azure.com; Port=3306; Database=Parras; Uid=orlando@traficdb; Pwd=Bejeweled2012; SslMode=Preferred;";
     //   BaseDeDatos db = new BaseDeDatos();
        public Form1()
        {
            InitializeComponent();
            //     dataGridView1.DataSource = db.SelectDataTable("select * from lideres");
            fill();
        }
        private void fill()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlDataAdapter ad = new MySqlDataAdapter("select * from lideres",con);
            con.Open();
            DataSet ds = new DataSet();
            ad.Fill(ds, "id");
            dataGridView1.DataSource = ds.Tables["id"];
            con.Close();

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
