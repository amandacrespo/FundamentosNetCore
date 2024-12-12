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
    public partial class Form11ColeccionGrafica : Form
    {
        public Form11ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string elem = this.textBox1.Text;
            this.lstElementos.Items.Add(elem);
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            //string elem = this.lstElementos.SelectedItems.ToString();
            //this.lstElementos.Items.Remove(elem);
            int i = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(i);

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndexSeleccionado.Text = "Index: " + this.lstElementos.SelectedIndex;
                this.lblItemSeleccionado.Text = "Item: " + this.lstElementos.SelectedItem;
            }
        }
    }
}
