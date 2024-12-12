using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form8stringbuilder : Form
    {
        public Form8stringbuilder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtTexto.Text;
            int longuitud = cadena.Length;
            krono.Start();
            for (int i = 0; i < longuitud; i++)
            {
                char letra = cadena[longuitud - 1];
                cadena = cadena.Remove(longuitud - 1, 1);
                cadena = cadena.Insert(i, letra.ToString());
            }
            krono.Stop();
            this.lblTiempoo.Text = "Segundos: " + krono.Elapsed.Seconds + ", Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            StringBuilder cadena = new StringBuilder();
            cadena.Append(this.txtTexto.Text);
            int longuitud = cadena.Length;
            krono.Start();
            for (int i = 0; i < longuitud; i++)
            {
                char letra = cadena[longuitud - 1];
                cadena = cadena.Remove(longuitud - 1, 1);
                cadena = cadena.Insert(i, letra.ToString());
            }
            krono.Stop();
            this.lblTiempoo.Text = "Segundos: " + krono.Elapsed.Seconds + ", Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena.ToString();
        }
    }
}
