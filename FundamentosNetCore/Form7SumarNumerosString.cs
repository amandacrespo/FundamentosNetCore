using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FundamentosNetCore
{
    public partial class Form7SumarNumerosString : Form
    {
        public Form7SumarNumerosString()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtSumar.Text;
            int suma = 0;
            for (int i = 0; i < textoNumeros.Length; i++)
            {
                char caracter = textoNumeros[i];
                //int n = int.Parse(caracter.ToString());
                int n = Convert.ToInt32(caracter.ToString());
                suma += n;
            }

            this.lblRes.Text = "La suma es: " + suma;
        }
    }
}
