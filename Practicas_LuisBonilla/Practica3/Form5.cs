using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(txtNombre.Text);
            int hora = Convert.ToInt32(txtHorastrabajadas.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            double sub, total, iva;
            sub = hora * valor;
            iva = sub * 0.10;
            total = sub + iva;
            dataGridView1.Rows.Add(nombre, hora, valor, sub, iva, total);

            dataGridView1.ClearSelection();

            int tot = 0;
            for (int f = 0; f < dataGridView1.Rows.Count; f++)
            {
                tot += Convert.ToInt32(dataGridView1.Rows[f].Cells[5].Value);
                lblplanilla.Text = string.Format("{0:C2}", tot);
            }
        }

        private void btnLimiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtValor.Clear();
            txtHorastrabajadas.Clear();
            txtNombre.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
