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
        string[] clan = new string[3] { "Estrella Dorara", "Maltisa", "Verde & Cream" };
        string[] v = new string[] {"Privado","Taxi","Calafia","Camion"};
        string[] Com = new string[] {"Electrico","Gas","Diesel","Nitrogeno"};
        public void fill()
        {
            for (int i = 0; i < 4; i++)
            {
                cbtipovehiculo.Items.Add(v[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                cbtiporuta.Items.Add(clan[i]);
                cbIgremio.Items.Add(clan[i]);
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
            cbvehiculo.Items.Add("f");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if(txtcapacidad.Text == "" || cbtipovehiculo.Text == "" || cbtipocfom.Text == "" || cbtiporuta.Text == "" || txtbin.Text == "")
            {
                MessageBox.Show("Favor de llenar los datos");
            }
            else
            {
                
            }
        }

        private void cbvehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enable();
        }
        public void Enable()
        {
     cbIgremio.Enabled=  txtIC.Enabled = cbIvehiculo.Enabled=   btnmodificar.Enabled = btneliminar.Enabled= cbC.Enabled = cbR.Enabled = true;
        }
        public void Clean()
        {
      cbIgremio.Text=   txtIC.Text=   cbvehiculo.Text = cbIvehiculo.Text = cbC.Text = cbR.Text = null;
       cbIgremio.Enabled=   txtIC.Enabled =  cbIvehiculo.Enabled = btnmodificar.Enabled = btneliminar.Enabled = cbC.Enabled = cbR.Enabled = false;
          
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Clean();
        }
        public void Rutas()
        {
            switch (cbtiporuta.SelectedIndex)
            {
                case 0:
                    string[] s = new string[] {"Libertad","Soler","3dax"};
                    for (int i = 0; i < 3; i++)
                    {
                        cbruta.Items.Add(s[i]);
                    }
                    break;
                case 1:
                    {
                        string[] x = new string[] { "Libertadd", "Solfer", "3dax" };
                        for (int i = 0; i < 3; i++)
                        {
                            cbruta.Items.Add(x[i]);
                        }
                        break;
                    }
                case 2:
                    break;
            }
        }

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
    }
}
