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
    public partial class Lideres : Form
    {
        string[] clan = new string[3] {"Azul","Maltisa","Verde & Cream"};
        public void fill()
        {
            for (int i = 0; i < 3; i++)
            {
                cbgrimo.Items.Add(clan[i]);
                cbIgrimo.Items.Add(clan[i]);
            }
        }
        public Lideres()
        {
            InitializeComponent();
            fill();
            cbnombre.Items.Add("h");
            d.populate(cbnombre, "select * from lideres", "nombre");
        }


        private void btnsALIR_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void txtIapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIgrimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lideres_Load(object sender, EventArgs e)
        {

        }

        private void txtIEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbnombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            fil();
            enable();
        }
        public void enable()
        {
        txtIcontrasena.Enabled=    txtIapellido.Enabled = txtIEdad.Enabled = cbIgrimo.Enabled = btndelete.Enabled = btnmod.Enabled = true;
        }
        public void clean()
        {
          txtIcontrasena.Text=  cbnombre.Text = txtIapellido.Text = txtIEdad.Text = cbIgrimo.Text = null;
          txtIcontrasena.Enabled =  txtIapellido.Enabled = txtIEdad.Enabled = cbIgrimo.Enabled = btndelete.Enabled = btnmod.Enabled = false;
        
        }
        public void clean2()
        {
          txtcontrasena.Text =  txtnombre.Text = txtapellido.Text = txtedad.Text = cbgrimo.Text = null;

        }

        ADB d = new ADB();
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if(txtcontrasena.Text == ""||  txtnombre.Text == "" || txtapellido.Text == "" || txtedad.Text == "" || cbgrimo.Text == "")
            {
                MessageBox.Show("Favor de llenar los datos");
            }
            else
            {
                string i = string.Format("insert into lideres (`nombre`, `apellido`, `edad`, `gremio`,`contrasena`,`login`) values ('{0}','{1}','{2}','{3}','{4}','{5}')",txtnombre.Text,txtapellido.Text,txtedad.Text,cbgrimo.Text,txtcontrasena.Text,false);
                d.Exe(i);
                d.populate(cbnombre, "select * from lideres", "nombre");
                clean2();
                MessageBox.Show("El lider se ingreso exitosamente");
            }
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
          
            //
            string up = string.Format("Update lideres set apellido = '{0}',edad = '{1}', gremio = '{2}',contrasena = '{3}' where nombre = '{4}'", txtIapellido.Text, txtIEdad.Text, cbIgrimo.Text, txtIcontrasena.Text, cbnombre.Text);
            d.Exe(up);
            d.populate(cbnombre, "select * from lideres", "nombre");
            clean();
            MessageBox.Show("Se modifico los datos");
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            string de = string.Format("delete from lideres where nombre = '{0}'", cbnombre.Text);
            d.Exe(de);
            d.populate(cbnombre, "select * from lideres", "nombre");
            clean();
            MessageBox.Show("El lider se dio de baja");

        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }
        //tipo
        MySqlConnection con = new MySqlConnection("Server=traficdb.mysql.database.azure.com; Port=3306; Database=Parras; Uid=orlando@traficdb; Pwd=Bejeweled2012; SslMode=Preferred;");
        private MySqlCommand cmd;
        private MySqlDataAdapter db;
        public void fil()
        {
           

            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from lideres where nombre = '" + cbnombre.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtIapellido.Text = dr["apellido"].ToString();
                txtIEdad.Text = dr["edad"].ToString();
                txtIcontrasena.Text = dr["contrasena"].ToString();
                cbIgrimo.Text = dr["gremio"].ToString();

            }
            con.Close();
        }

    }
}
