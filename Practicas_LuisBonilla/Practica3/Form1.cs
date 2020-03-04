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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGenerar_Click(object sender, EventArgs e)
		{
			//Color de texto
			lstGenerada.ForeColor = Color.Green;
			//Tipo de fuente
			lstGenerada.Font = new Font("Times new roman", 16, FontStyle.Bold);
			int nt;
			if (int.TryParse(txtTabla.Text, out nt))
			{
				lstGenerada.Items.Clear();
				for (int i = 1; i<=10; i++)
				{
					lstGenerada.Items.Add(nt + "*" + i + " = " + nt * i);
				}

			}
			else
			{
				MessageBox.Show("Ingrese un numero entero.");
			}
		}
	}
}
