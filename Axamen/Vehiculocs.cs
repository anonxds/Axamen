using Axamen.facade;
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
    public partial class Vehiculocs : Form
    {

        MySqlConnection con = new MySqlConnection("Server=traficdb.mysql.database.azure.com; Port=3306; Database=Parras; Uid=orlando@traficdb; Pwd=Bejeweled2012; SslMode=Preferred;");
        private MySqlCommand cmd;
        ADB db = new ADB();
        vehiculofabrica fabrica = null;
        facades facade = new facades(); 
        string[] v = new string[] {"Privado","Taxi","Calafia","Camion"};
        string[] Com = new string[] {"Electrico","Gas","Diesel","Nitrogeno"};
        public void fill()
        {
            
             for (int i = 0; i < 4; i++)
             {
                 cbtipovehiculo.Items.Add(v[i]);
                 cbIvehiculo.Items.Add(v[i]);
             }
            
           
            for (int i = 0; i < 4; i++)
            {
                cbtipocfom.Items.Add(Com[i]);
                cbC.Items.Add(Com[i]);
            }
        }
        public Vehiculocs()
        {
            InitializeComponent();
            fill();           
            facade.LP(cbvehiculo, cbtiporuta, cbIgremio, cbR);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }
        public void limpiar()
        {
     txtKi.Text= cbtipovehiculo.Text = txtbin.Text = txtcapacidad.Text = cbtipocfom.Text = cbtiporuta.Text = cbruta.Text = null;
            Clean();   
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        


            try
            {
                if (txtcapacidad.Text == "" || cbtipovehiculo.Text == "" || cbtipocfom.Text == "" || cbtiporuta.Text == "" || txtbin.Text == "")
                {
                    MessageBox.Show("Favor de llenar los datos");
                }
                else
                {
                    
                    switch (cbtipovehiculo.Text)
                    {
                        case "Taxi":
                            fabrica = new concretefactory(int.Parse(txtKi.Text), int.Parse(txtcapacidad.Text), cbtipocfom.Text,txtbin.Text);
                            break;
                        case "Privado":
                            fabrica = new privadofabrica(int.Parse(txtKi.Text), int.Parse(txtcapacidad.Text), cbtipocfom.Text,txtbin.Text);
                            break;
                        case "Calafia":
                            fabrica = new calafiafrabrica(int.Parse(txtKi.Text), int.Parse(txtcapacidad.Text), cbtipocfom.Text,txtbin.Text);
                            break;
                        case "Camion":
                            fabrica = new camionfabrica(int.Parse(txtKi.Text), int.Parse(txtcapacidad.Text), cbtipocfom.Text,txtbin.Text);
                            break;
                                
                    }              
                       Vehiculo v = fabrica.GetVehiculo();     
                    facade.insertar(v.VIN, cbtipovehiculo.Text, v.capacidad, cbtipocfom.Text, cbtiporuta.Text, cbruta.Text, v.kilometrage,cbvehiculo);                                
                    limpiar();                
                }
            }
            catch
            {
                MessageBox.Show("No puede ingresar un VIM ya registrado");
            }
        }

        private void cbvehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            Enable();
            fil();
        }
        public void Enable()
        {
   txtIki.Enabled=  cbIgremio.Enabled=  txtIC.Enabled = cbIvehiculo.Enabled=   btnmodificar.Enabled = btneliminar.Enabled= cbC.Enabled = cbR.Enabled = true;
        }
        public void Clean()
        {
    txtIki.Text=  cbIgremio.Text=   txtIC.Text=   cbvehiculo.Text = cbIvehiculo.Text = cbC.Text = cbR.Text = null;
   txtIki.Enabled=    cbIgremio.Enabled=   txtIC.Enabled =  cbIvehiculo.Enabled = btnmodificar.Enabled = btneliminar.Enabled = cbC.Enabled = cbR.Enabled = false;
          
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {         
            facade.update(cbIvehiculo.Text, int.Parse(txtIC.Text), cbC.Text, cbR.Text, cbIgremio.Text, int.Parse(txtIki.Text), cbvehiculo.Text,cbvehiculo);
            Clean();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {           
            facade.delete(cbvehiculo.Text,cbvehiculo);           
            Clean();
        }
        public void Rutas()
        {
            //combo
            switch (cbtiporuta.Text)
            {
                case "Estrella Dorada":
                    rutass();
                    cbruta.Enabled = true;
                    break;
                case "Maltisa":
                    {
                        rutass();
                        cbruta.Enabled = true;
                        break;
                    }
                case "Verde & Cream":
                    rutass();
                    cbruta.Enabled = true;
                    break;
                case "pendiente":
                    cbruta.Items.Clear();
                    cbruta.Enabled = false;
                    break;
            }
        }
        //
        public void rutass()
        {
            cbruta.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from grimos where nombre = '" + cbtiporuta.SelectedItem.ToString() + "'";
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
       
        //
       

        private void cbtiporuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rutas();
        }

        private void txtIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //
 
   
        public void fil()
        {
          con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from vehiculo where vim = '" + cbvehiculo.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbIvehiculo.Text = dr["tipo"].ToString();
                cbC.Text = dr["combustible"].ToString();
                cbIgremio.Text = dr["grimo"].ToString();
                cbR.Text = dr["ruta"].ToString();
                txtIC.Text = dr["capacidad"].ToString();
                txtIki.Text = dr["Kilometraje"].ToString();
            }
            con.Close();
        }
        private void cbruta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbIgremio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIgremio.Text == "pendiente")
            {
                cbR.Text = null;
                cbR.Enabled = false;
            }
            else
            {                
                cbR.Enabled = true ;
            }                      
        }

        private void txtIki_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Vehiculocs_Load(object sender, EventArgs e)
        {

        }
    }
}
