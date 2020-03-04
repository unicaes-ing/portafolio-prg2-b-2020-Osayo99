using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		public static double Buscar(double numero, ListBox numeros)
		{
			int cont = 0;
			foreach (double n in numeros.Items)
			{
				if (n == numero) cont++;
			}
			return cont;
		}
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			double numero;
			numero = Convert.ToDouble(txtAgregar.Text);
			lstNumeros.Items.Add(numero);
			txtAgregar.Text = "";
			txtBuscar.Text = "";
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			double num = Convert.ToDouble(txtBuscar.Text);
			double cant = Buscar(num, lstNumeros);
			MessageBox.Show("El numero que usted busca se encuentra " + cant + " veces.");
			txtAgregar.Text = "";
			txtBuscar.Text = "";
		}
	}
}
