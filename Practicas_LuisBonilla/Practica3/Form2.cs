﻿using System;
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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void btnGenerar_Click(object sender, EventArgs e)
		{
			
			char letra = 'A';

			while (letra <= 'Z')
			{
				lstAbc.Items.Add(letra);
				letra++;
			}
			lstAbc.Items.Insert(14, "Ñ");
		}
	}
}
