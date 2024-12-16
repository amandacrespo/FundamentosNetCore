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
    public partial class Form13ColeccionNumeros : Form
    {
        public Form13ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int n = random.Next(0, 10);
                this.lstNumeros.Items.Add(n);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int pares = 0;
            int impares = 0;

            foreach (int item in this.lstNumeros.Items)
            {
                suma += item;

                if (item%2==0)
                {
                    pares += item;
                } 
                else
                {
                    impares += item;
                }
            }

            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = pares.ToString();
            this.txtImpares.Text = impares.ToString();
        }
    }
}
