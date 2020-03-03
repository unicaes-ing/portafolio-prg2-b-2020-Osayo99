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
	public partial class P1E1 : Form
	{
		public P1E1()
		{
			InitializeComponent();
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			Double Ex1, Ex2, Ex3, Prom;
			Ex1 = Convert.ToDouble(txtEx1.Text);
			Ex2 = Convert.ToDouble(txtEx2.Text);
			Ex3 = Convert.ToDouble(txtEx3.Text);
			Prom = (Ex1 + Ex2 + Ex3) / 3;
			txtProm.Text = String.Format("{0:N2}",Prom);
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtEx1.Text = " ";
			txtEx2.Text = " ";
			txtEx3.Text = " ";
			txtProm.Text = " ";
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
