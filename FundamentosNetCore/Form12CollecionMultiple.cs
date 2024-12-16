using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form12CollecionMultiple : Form
    {
        public Form12CollecionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtNuevoElemento.Focus();
            this.txtNuevoElemento.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";

            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ",";
            }

            this.lblIndexSeleccionado.Text = indices.Trim(',');

            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ",";
            }

            this.lblItemSeleccionado.Text = items.Trim(',');
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            // Al eliminar hay reposicionamiento, para que nos borre los elementos que necesitamos, hay que hacer el bucle desde el ultimo numero.
            int numSeleccionados = this.lstElementos.SelectedIndices.Count;
            for (int j = (numSeleccionados - 1); j >=0 ; j--)
            {
                int i = this.lstElementos.SelectedIndices[j];
                this.lstElementos.Items.RemoveAt(i);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lblItemSeleccionado_Click(object sender, EventArgs e)
        {

        }
    }
}
