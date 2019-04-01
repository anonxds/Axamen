using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axamen
{
    public partial class Rutas : Form
    {
        ADB dbs = new ADB();
        public Rutas()
        {
            InitializeComponent();
            dbs.populate(cblistaclan, "select * from grimos", "nombre");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void cblistaclan_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            enable();
            fil();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string del = string.Format("delete from grimos where nombre = '{0}'", cblistaclan.Text);
            dbs.Exe(del);
            dbs.populate(cblistaclan, "select * from grimos", "nombre");
            limpiar();
        
        }
        public void enable()
        {
            cbruta1.Enabled = cbruta2.Enabled = cbruta3.Enabled = btnmodificar.Enabled = Eliminar.Enabled = true;
        }
        public void limpiar()
        {
            cbruta1.Enabled = cbruta2.Enabled = cbruta3.Enabled = btnmodificar.Enabled = Eliminar.Enabled = false;
            cbruta1.Text = cbruta2.Text = cbruta3.Text = cblistaclan.Text = null;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string upd = string.Format("update grimos set ruta1 = '{0}',ruta2 = '{1}',ruta3 = '{2}' where nombre = '{3}'",cbruta1.Text,cbruta2.Text,cbruta3.Text,cblistaclan.Text);
            dbs.Exe(upd);
            dbs.populate(cblistaclan, "select * from grimos", "nombre");
            limpiar();
         
        }
        MySqlConnection con = new MySqlConnection("Server=traficdb.mysql.database.azure.com; Port=3306; Database=Parras; Uid=orlando@traficdb; Pwd=Bejeweled2012; SslMode=Preferred;");
        private MySqlCommand cmd;
        private MySqlDataAdapter db;
        public void fil()
        {


            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from grimos where nombre = '" + cblistaclan.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbruta1.Text = dr["ruta1"].ToString();
                cbruta2.Text = dr["ruta2"].ToString();
                cbruta3.Text = dr["ruta3"].ToString();
               

            }
            con.Close();
        }
    }
}
