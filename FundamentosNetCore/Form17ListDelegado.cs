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
    public partial class Form17ListDelegado : Form
    {
        int contador;
        List<Button> botones;

        public Form17ListDelegado()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            // this.button1.Click += BotonPulsado;
            //this.botones.AddRange(this.button1, this.button2, this.button3, this.button4, this.button5, this.button6);
            foreach (Control btn in this.Controls)
            {
                if (btn is Button)
                {
                    this.botones.Add((Button)btn);
                }
            }

            foreach (var btn in botones)
            {
                btn.Click += BotonPulsado;
            }
        }

        private void Form17ListDelegado_Load(object sender, EventArgs e)
        {

        }

        void BotonPulsado(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightBlue;
            this.contador += int.Parse(btn.Text);
            this.textBox1.Text = this.contador.ToString();
        }
    }
}
