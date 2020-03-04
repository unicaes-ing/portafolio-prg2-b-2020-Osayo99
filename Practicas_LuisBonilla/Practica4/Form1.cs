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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public static double Sumatoria(double N1, double N2, double N3, double N4)
		{
			return N1 + N2 + N3 + N4;
		}
		private void btnSumar_Click(object sender, EventArgs e)
		{
			double num1, num2, num3, num4;
			num1 = Convert.ToDouble(txtN1.Text);
			num2 = Convert.ToDouble(txtN2.Text);
			num3 = Convert.ToDouble(txtN3.Text);
			num4 = Convert.ToDouble(txtN4.Text);
			lblSumatoria.Text = Convert.ToString(Sumatoria(num1,num2,num3,num4));
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtN1.Text = "";
			txtN2.Text = "";
			txtN3.Text = "";
			txtN4.Text = "";
			lblSumatoria.Text = "";
		}
	}
}
