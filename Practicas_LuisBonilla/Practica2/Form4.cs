using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3_sarahi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            bool valido = false;
            string patronCorreo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txtCorreo.Text, patronCorreo) == false)
            {
                valido = false;
            }
            else
            {
                valido = true;
            }
            if (txtContra.TextLength < 8)
            {
                valido = false;
            }
            else
            {
                string patronContra = "^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,16}$";
                if (Regex.IsMatch(txtContra.Text, patronContra) == false)
                {
                    valido = false;
                }
                else
                {
                    valido = true;
                }
            }
            if (txtContra.Text != "" && txtCorreo.Text != "" && txtValidContra.Text == txtContra.Text)
            {
                valido = true;
            }
            else
            {
                valido = false;
            }
            if (!valido)
            {
                MessageBox.Show("Datos invalidos");
            }
            else
            {
                MessageBox.Show("Datos validados");
            }
        }
    }
}
