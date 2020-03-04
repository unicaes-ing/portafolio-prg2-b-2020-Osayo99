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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}
		public static int Fibo(int f)
		{
			if (f < 2)
			{

				return f;
			}
			else
			{
				return Fibo(f - 1) + Fibo(f - 2);
			}
		}
		private void btnCalcular_Click(object sender, EventArgs e)
		{
			int numero;
			numero = Convert.ToInt32(txtNumero.Text);
			txtFibo.Text = Convert.ToString(Fibo(numero));
		}
	}
}
