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
        string[] clan = new string[3] {"Estrella Dorara","Maltisa","Verde & Cream"};
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
            enable();
        }
        public void enable()
        {
            txtIapellido.Enabled = txtIEdad.Enabled = cbIgrimo.Enabled = btndelete.Enabled = btnmod.Enabled = true;
        }
        public void clean()
        {
            cbnombre.Text = txtIapellido.Text = txtIEdad.Text = cbIgrimo.Text = null;
            txtIapellido.Enabled = txtIEdad.Enabled = cbIgrimo.Enabled = btndelete.Enabled = btnmod.Enabled = false;
        
        }
        public void clean2()
        {
            txtnombre.Text = txtapellido.Text = txtedad.Text = cbgrimo.Text = null;

        }
        

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text == "" || txtapellido.Text == "" || txtedad.Text == "" || cbgrimo.Text == "")
            {
                MessageBox.Show("Favor de llenar los datos");
            }
            else
            {
                clean2();
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
            clean();
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
