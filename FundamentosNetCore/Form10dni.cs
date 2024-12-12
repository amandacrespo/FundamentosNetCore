using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form10dni : Form
    {
        public Form10dni()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string cadena = this.txtDni.Text;

            if (cadena.Length < 9)
            {
                this.lblRes.Text = "El formato del DNI no es válido.";
                return;
            }

            string numeroParte = cadena.Substring(0, cadena.Length - 1);
            char letraProporcionada = cadena[^1];

            int resto = int.Parse(numeroParte) % 23;
            char[] tablaLetras = {
                'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D',
                'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L',
                'C', 'K', 'E', 'T'
            };
            char letraCorrecta = tablaLetras[resto];

            if (char.ToUpper(letraProporcionada) == letraCorrecta)
            {
                this.lblRes.Text = "El DNI es válido.";
            }
            else
            {
                this.lblRes.Text = $"El DNI no es correcto. La letra correcta es: {letraCorrecta}";
            }

        }
    }
}
