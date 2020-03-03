using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3_sarahi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(txtNumero1.Text);
            double precio = Convert.ToDouble(txtNumero2.Text);
            double resp = 0.0;
            double descuento2, descuento3, descuento4, descuento5;
            descuento2 = (cantidad * precio) * 0.05;
            descuento3 = (cantidad * precio) * 0.10;
            descuento4 = (cantidad * precio) * 0.15;
            descuento5 = (cantidad * precio) * 0.20;
            if (rdo0.Checked)
            {
                txtDescuento.Text = String.Format("$ 0.0");
                resp = cantidad * precio;
            }
            else if (rdo5.Checked)
            {
                resp = (cantidad * precio) - descuento2;
                txtDescuento.Text = "$ " + String.Format("{0:N}", descuento2);
            }
            else if (rdo10.Checked)
            {
                resp = (cantidad * precio) - descuento3;
                txtDescuento.Text = "$ " + String.Format("{0:N}", descuento3);
            }
            else if (rdo15.Checked)
            {
                resp = (cantidad * precio) - descuento4;
                txtDescuento.Text = "$ " + String.Format("{0:N}", descuento4);
            }
            else if (rdo20.Checked)
            {
                resp = (cantidad * precio) - descuento5;
                txtDescuento.Text = "$ " + String.Format("{0:N}", descuento5);
            }
            txtTotal.Text = "$ " + String.Format("{0:N}", resp);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
