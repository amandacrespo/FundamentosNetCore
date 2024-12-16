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
    public partial class Form15Metodos : Form
    {
        public Form15Metodos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void GetDobleValor(int n)
        {
            n *= 2;
        }

        void CambiarColor(Button b)
        {
            b.BackColor = Color.LightBlue;
        }

        void GetDobleReferencia(ref int n)
        {
            n *= 2;
        }

        private void MetodoInventado(object sender, EventArgs e)
        {

        }

        private void btnDobleVal_Click(object sender, EventArgs e)
        {
            int n = int.Parse(this.txtNum.Text);
            this.GetDobleValor(n);
            this.CambiarColor(this.btnDobleVal);
            this.lblRes.Text = n.ToString();
        }

        private void btnDobleRef_Click(object sender, EventArgs e)
        {
            int n = int.Parse(this.txtNum.Text);
            this.GetDobleReferencia(ref n);
            this.CambiarColor(this.btnDobleRef);
            this.lblRes.Text = n.ToString();
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = e.X.ToString() + ", " + e.Y.ToString();
        }

        private void txtSoloNum_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsDigit(e.KeyData) == false)
            {
                // COPIAR LO DE PACO, CON KEYPRESS
            }
        }
    }
}
