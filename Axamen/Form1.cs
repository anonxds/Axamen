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
        ADB dbs = new ADB();
        MySqlConnection con = new MySqlConnection("Server=traficdb.mysql.database.azure.com; Port=3306; Database=Parras; Uid=orlando@traficdb; Pwd=Bejeweled2012; SslMode=Preferred;");
        private MySqlCommand cmd;
        private MySqlDataAdapter db;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
           
        }
      
        

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtusario.Text == "Admin" && txtcontrasena.Text == "1234")
            {
                Menu m = new Menu();
                m.Show();
                this.Hide();
            }
            else
            {


                i = 0;
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from lideres where nombre='" + txtusario.Text + "'and contrasena='" + txtcontrasena.Text + "'and login='"+false+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    MessageBox.Show("Usuario o contrasena incorrecta");
                }
                else
                {
                    string update = string.Format("update lideres set login = '{0}' where nombre = '{1}'", 1, txtusario.Text);
                    dbs.Exe(update);
                    this.Hide();
                    Mlider m = new Mlider(txtusario.Text);
                    m.Show();
                }
                con.Close();



            
}



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
      
    }
}
