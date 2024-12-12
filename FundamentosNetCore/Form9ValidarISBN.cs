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
    public partial class Form9ValidarISBN : Form
    {
        public Form9ValidarISBN()
        {
            InitializeComponent();
        }

        private void lblRes_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string cadena = this.txtISBN.Text;

            if (cadena.Length != 10)
            {
                this.lblRes.Text = "Debes introducir 10 caracteres";
                return;
            }

            if (!cadena.All(char.IsDigit))
            {
                this.lblRes.Text = "El ISBN debe contener solo números.";
                return;
            }

            int suma = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                char c = cadena[i]; 
                int n = int.Parse(c.ToString());
                suma += n * (i + 1);
            }

            int resto = suma % 11;
            this.lblRes.Text = resto == 0
                             ? "El ISBN es correcto"
                             : "El ISBN es incorrecto";
        }
    }
}
