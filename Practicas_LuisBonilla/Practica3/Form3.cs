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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			dataGridView1.Size = new Size(210, 220);
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.ScrollBars = ScrollBars.None;
			dataGridView1.ColumnCount = 10;
			dataGridView1.ColumnHeadersVisible = false;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			Random R = new Random();
			for (int f = 0; f < 10; f++)
			{
				dataGridView1.Rows.Add();
				for (int c = 0; c < 10; c++)
				{
					dataGridView1.Rows[f].Cells[c].Value = R.Next(10, 100);
				}
			}
			dataGridView1.ClearSelection();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			int busqueda = Convert.ToInt32(txtBusqueda.Text);
			for (int i = 0; i <= 9; i++)
			{
				for (int f = 0; f < dataGridView1.Rows.Count; f++)
				{
					if (dataGridView1.Rows[f].Cells[i].Value.Equals(busqueda))
					{
						dataGridView1.Rows[f].Cells[i].Style.BackColor = Color.Green;
					}
					else
					{
						dataGridView1.Rows[f].Cells[i].Style.BackColor = Color.White;
					}
				}
			}
		}
	}
}
