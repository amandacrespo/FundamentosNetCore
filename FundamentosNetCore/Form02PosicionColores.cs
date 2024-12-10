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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnMov_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(txtPosX.Text);
            int posY = int.Parse(txtPosY.Text);
            btnMov.Location = new Point(posX, posY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(txtRojo.Text);
            int verde = int.Parse(txtVerde.Text);
            int azul = int.Parse(txtAzul.Text);
            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
