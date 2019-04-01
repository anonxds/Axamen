using Axamen.vehiculo;
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
    public partial class Mlider : Form
    {
        ADB dbs = new ADB();
        DataTable dt = new DataTable();
        public Mlider(string nombre)
        {
            InitializeComponent();
            lblnombre.Text = nombre;
            fil();
            string f = string.Format("select vim as VIM,tipo,capacidad,combustible from vehiculo where grimo = '{0}'", lblclan.Text);
           
            dbs.dgrid(dgv, f);
            fill();
            cbruta.Items.Add("pendiete");
            dbs.populate(cbIvim, f, "vim");
            rutass();
            rutas2();
        }

        string[] v = new string[] { "Privado", "Taxi", "Calafia", "Camion" };
        string[] Com = new string[] { "Electrico", "Gas", "Diesel", "Nitrogeno" };
        public void fill()
        {

            for (int i = 0; i < 4; i++)
            {
                cbvehiculo.Items.Add(v[i]);
                cbIvehiculo.Items.Add(v[i]);
            }


            for (int i = 0; i < 4; i++)
            {
                cbcombustible.Items.Add(Com[i]);
                cbC.Items.Add(Com[i]);
            }
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {

        }
      
        MySqlConnection con = new MySqlConnection("Server=traficdb.mysql.database.azure.com; Port=3306; Database=Parras; Uid=orlando@traficdb; Pwd=Bejeweled2012; SslMode=Preferred;");
        private MySqlCommand cmd;
        private MySqlDataAdapter db;
        vehiculofabrica fabrica = null;
        public void fil()
        {


            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from lideres where nombre = '" + lblnombre.Text + "'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                lblclan.Text = dr["gremio"].ToString();
               

            }
            con.Close();
        }

        private void Mlider_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtKi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbIvim_SelectedIndexChanged(object sender, EventArgs e)
        {
            doc();
            enable();
        }
        public void enable()
        {
            cbIvim.Enabled = cbIvehiculo.Enabled = cbC.Enabled = cbR.Enabled = txtIC.Enabled = txtIki.Enabled  = btneliminar.Enabled = btnmodificar.Enabled = true;
        }
        public void limpiar()
        {
             cbIvehiculo.Enabled = cbC.Enabled = cbR.Enabled = txtIC.Enabled = txtIki.Enabled = btneliminar.Enabled = btnmodificar.Enabled = false;
            cbIvim.Text = cbIvehiculo.Text = cbC.Text = cbR.Text = txtIC.Text = txtIki.Text = null;
        }
        public void limpiar2()
        {
            cbvehiculo.Text = txtbin.Text = txtcapacidad.Text = cbcombustible.Text = cbruta.Text = txtKi.Text = null;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                if (cbvehiculo.Text == "" || txtbin.Text == "" || txtcapacidad.Text == "" || cbcombustible.Text == "" || cbruta.Text == "" || txtKi.Text == "")
                {
                    MessageBox.Show("Favor de llenar los datos");
                }
                else
                {
                    //
                    switch (cbvehiculo.Text)
                    {
                        case "Taxi":
                            fabrica = new concretefactory(int.Parse(txtKi.Text), int.Parse(txtcapacidad.Text), cbcombustible.Text, txtbin.Text);
                            break;
                        case "Privado":
                            fabrica = new privadofabrica(int.Parse(txtKi.Text), int.Parse(txtcapacidad.Text), cbcombustible.Text, txtbin.Text);
                            break;
                        case "Calafia":
                            fabrica = new calafiafrabrica(int.Parse(txtKi.Text), int.Parse(txtcapacidad.Text), cbcombustible.Text, txtbin.Text);
                            break;

                        case "Camion":
                            fabrica = new camionfabrica(int.Parse(txtKi.Text), int.Parse(txtcapacidad.Text), cbcombustible.Text, txtbin.Text);
                            break;


                    }
                    Vehiculo v = fabrica.GetVehiculo();
                    string A = string.Format("INSERT INTO vehiculo (`vim`, `tipo`, `capacidad`, `combustible`, `grimo`, `ruta`,`Kilometraje`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}')",
                    v.VIN, cbvehiculo.Text, v.capacidad, cbcombustible.Text, lblclan.Text, cbruta.Text, v.kilometrage);
                    dbs.Exe(A);
                    MessageBox.Show("Se ingreso exitosamente");
                    string f = string.Format("select * from vehiculo where grimo = '{0}'", lblclan.Text);
                    dbs.dgrid(dgv, f);
                    limpiar2();
                }
            }
            catch
            {
                MessageBox.Show("No puede ingresar un VIM ya registrado");
            }
         
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            string update = string.Format("update lideres set login = '{0}' where nombre = '{1}'", false,lblnombre.Text);
            dbs.Exe(update);
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string up = string.Format("update vehiculo set tipo ='{0}',capacidad = '{1}',combustible='{2}',ruta='{3}',Kilometraje='{4}' where vim ='{5}'", cbIvehiculo.Text, txtIC.Text, cbC.Text, cbR.Text, txtIki.Text, cbIvim.Text);
            dbs.Exe(up);
            string f = string.Format("select * from vehiculo where grimo = '{0}'", lblclan.Text);
            dbs.dgrid(dgv, f);
            dbs.populate(cbIvim, f, "vim");
            limpiar();
        }
        //
        public void doc()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from vehiculo where vim = '" + cbIvim.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbIvehiculo.Text = dr["tipo"].ToString();
                cbC.Text = dr["combustible"].ToString();
              
                cbR.Text = dr["ruta"].ToString();
                txtIC.Text = dr["capacidad"].ToString();
                txtIki.Text = dr["Kilometraje"].ToString();


            }
            con.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string del = string.Format("delete from vehiculo where vim = '{0}'", cbIvim.Text);
            dbs.Exe(del);
            string f = string.Format("select * from vehiculo where grimo = '{0}'", lblclan.Text);
            dbs.dgrid(dgv, f);
            dbs.populate(cbIvim, f, "vim");
            limpiar();
        }

        private void cbruta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        //


        public void rutass()
        {
            cbruta.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from grimos where nombre = '" + lblclan.Text + "'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbruta.Items.Add(dr["ruta1"].ToString());
                cbruta.Items.Add(dr["ruta2"].ToString());
                cbruta.Items.Add(dr["ruta3"].ToString());


            }
            con.Close();
        }
        public void rutas2()
        {
            cbR.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from grimos where nombre = '" + lblclan.Text + "'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbR.Items.Add(dr["ruta1"].ToString());
                cbR.Items.Add(dr["ruta2"].ToString());
                cbR.Items.Add(dr["ruta3"].ToString());


            }
            con.Close();
        }

        private void txtcapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbvehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
