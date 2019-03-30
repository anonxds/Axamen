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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnlideres_Click(object sender, EventArgs e)
        {
            Lideres l = new Lideres();
            l.Show();
            this.Hide();
        }

        private void btnvehiculo_Click(object sender, EventArgs e)
        {
            Vehiculocs v = new Vehiculocs();
            v.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
