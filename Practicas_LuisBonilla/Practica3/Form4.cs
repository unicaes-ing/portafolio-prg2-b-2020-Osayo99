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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void btnLanzar_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			int cant = 1, c = 0;
			while ( cant <= 5000)
			{
				int num = r.Next(1, 7);
				lstDatos.Items.Add(num);
				cant++;
				if (num==6)
				{
					c++;
				}
			}
			MessageBox.Show("Usted saco el numero 6, esta cantidad de veces: " + c); 
		}
	}
}
