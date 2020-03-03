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
    public partial class P1E4 : Form
    {
        public P1E4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Precio, Subtotal, Impuesto, Total;
            int Cantidad;
            Precio = Convert.ToDouble(txtPrec.Text);
            Cantidad = Convert.ToInt32(txtCantidad.Text);
            Subtotal = Precio * Cantidad;
            Impuesto = Subtotal * 0.13;
            Total = Subtotal + Impuesto;
            txtSubtotal.Text = Convert.ToString(Subtotal);
            txtImpuesto.Text = Convert.ToString(Impuesto);
            txtTotal.Text = Convert.ToString(Total);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboTitulo.Text = "";
            txtPrec.Text = "";
            txtCantidad.Text = "";
            txtSubtotal.Text = "";
            txtImpuesto.Text = "";
            txtTotal.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
