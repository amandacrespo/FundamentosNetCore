using System;
using System.Collections;
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
    public partial class Form16ArrayList : Form
    {
        public Form16ArrayList()
        {
            InitializeComponent();
            //ArrayList list = new ArrayList();
            //list.Add(this.button1);
            //list.Add(this.button2);
            //list.Add(this.button3);
            //list.Add(this.textBox1);

            //((TextBox)list[0]).BackColor = Color.Yellow;

            //foreach (Button btn in list)
            //{
            //    btn.BackColor = Color.LightBlue;
            //}

            //foreach (Control ctrl in list)
            //{
            //    ctrl.BackColor =  ctrl is TextBox ?  Color.Yellow : Color.LightBlue;

            //    if (ctrl is TextBox)
            //    {
            //        ((TextBox)ctrl).Paste();
            //    }
            //}

            //List<Button> list = new List<Button>();
            //list.Add(this.button1);
            //list.Add(this.button2);
            //list.Add(this.button3);
            //list.Add(this.textBox1); // Da error antes de compilar, con ArrayList no nos enteramos.

            this.button1.Click += Button1_Click;
            this.button2.Click += MetodoDelegado;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form16ArrayList_Load(object sender, EventArgs e)
        {

        }

        void MetodoDelegado(object sender, EventArgs e)
        {

        }
    }
}
