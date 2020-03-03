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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtnumero.Text);
                string roma = " ";
                if (num >= 1 && num <= 10)
                {
                    if (num == 1)
                    {
                        roma = "I";
                    }
                    else if (num == 2)
                    {
                        roma = "II";
                    }
                    else if (num == 3)
                    {
                        roma = "III";
                    }
                    else if (num == 4)
                    {
                        roma = "IV";
                    }
                    else if (num == 5)
                    {
                        roma = "V";
                    }
                    else if (num == 6)
                    {
                        roma = "VI";
                    }
                    else if (num == 7)
                    {
                        roma = "VII";
                    }
                    else if (num == 8)
                    {
                        roma = "VIII";
                    }
                    else if (num == 9)
                    {
                        roma = "IX";
                    }
                    else if (num == 10)
                    {
                        roma = "X";
                    }
                    lblromano.Text = "Equivale a " + roma + " en romano";
                }
                else
                {
                    txtnumero.Focus();
                    txtnumero.SelectAll();
                    lblromano.Text = "Ingrese un número entre 1 y 10";
                }
            }
            catch (Exception)
            {

                txtnumero.Focus();
                txtnumero.SelectAll();
                lblromano.Text = "Ingrese numeros";
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

