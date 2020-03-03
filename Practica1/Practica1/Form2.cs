using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class P1E2 : Form
    {
        public P1E2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Dec;
            Dec = Convert.ToInt32(txtDecimal.Text);
            txtBinario.Text = Convert.ToString(Dec, 2);
            txtOctal.Text = Convert.ToString(Dec, 8);
            txtHexa.Text = Convert.ToString(Dec, 16);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDecimal.Text = "";
            txtBinario.Text = "";
            txtOctal.Text = "";
            txtHexa.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
