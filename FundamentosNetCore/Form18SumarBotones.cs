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
    public partial class Form18SumarBotones : Form
    {
        List<Button> btns;
        int suma;

        public Form18SumarBotones()
        {
            InitializeComponent();
            this.btns = new List<Button>();
            this.suma = 0;

            foreach (Button item in this.panelButtons.Controls)
            {
                this.btns.Add(item);
                item.Click += SumarNum; // Como solo queremos darle la accion 1 vez, se la asignamos en el constructor.
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.suma = 0;
            this.textBox1.Text = this.suma.ToString();
            foreach (Button item in this.btns)
            {
                item.Text = rnd.Next(1,20).ToString();
            }
        }

        void SumarNum(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.suma += int.Parse(btn.Text);
            this.textBox1.Text = this.suma.ToString();
        }
    }
}
