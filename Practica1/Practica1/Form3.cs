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
    public partial class P1E3 : Form
    {
        public P1E3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double InvUno, InvDos, InvTres, Total, PorcUno, PorcDos, PorcTres;
            InvUno = Convert.ToDouble(txtInv1.Text);
            InvDos = Convert.ToDouble(txtInv2.Text);
            InvTres = Convert.ToDouble(txtInv3.Text);
            Total = InvUno + InvDos + InvTres;
            txtTot.Text = "$" + Convert.ToString(Total);
            PorcUno = (InvUno/Total)*100;
            PorcDos = (InvDos/Total) * 100;
            PorcTres = (InvTres/Total) * 100;
            txtPor1.Text = Convert.ToString(PorcUno) + "%";
            txtPor2.Text = Convert.ToString(PorcDos) + "%";
            txtPor3.Text = Convert.ToString(PorcTres) + "%";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInv1.Text = "";
            txtInv2.Text = "";
            txtInv3.Text = "";
            txtPor1.Text = "";
            txtPor2.Text = "";
            txtPor3.Text = "";
            txtTot.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
