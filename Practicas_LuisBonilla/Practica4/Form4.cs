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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		public static int Mayor(int num1, int num2)
		{
			if (num1>num2)
			{
				return num1;
			}
            else
            {
                return num2;
            }
		}
		public static int Mayor(int num1, int num2, int num3)
		{
			if (num1 > num2)
			{
				if (num1 > num3)
				{
					return num1;
				}
				else
				{
					return num3;
				}
			}
			else
			{
				if (num2>num3)
				{
					return num2;
				}
				else
				{
					return num3;
				}
			}
		}
		private void btnMayor_Click(object sender, EventArgs e)
		{
            int num1, num2, num3, res;
            if (txtN1.Text != "" && txtN2.Text != "" && txtN3.Text == "")
            {
                num1 = Convert.ToInt32(txtN1.Text);
                num2 = Convert.ToInt32(txtN2.Text);
                res = Mayor(num1, num2);
            }
            else if (txtN1.Text != "" && txtN3.Text != "" && txtN2.Text == "")
            {
                num1 = Convert.ToInt32(txtN1.Text);
                num3 = Convert.ToInt32(txtN3.Text);
                res = Mayor(num1, num3);
            }
            else if (txtN2.Text != "" && txtN3.Text != "" && txtN1.Text == "")
            {
                num2 = Convert.ToInt32(txtN2.Text);
                num3 = Convert.ToInt32(txtN3.Text);
                res = Mayor(num2, num3);
            }
            else
            {
                num1 = Convert.ToInt32(txtN1.Text);
                num2 = Convert.ToInt32(txtN2.Text);
                num3 = Convert.ToInt32(txtN3.Text);
                res = Mayor(num1, num2, num3);
            }
            lblRes.Text = Convert.ToString(res);
		}
	}
}
