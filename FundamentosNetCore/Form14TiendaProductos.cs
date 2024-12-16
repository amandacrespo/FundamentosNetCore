using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace FundamentosNetCore
{
    public partial class Form14TiendaProductos : Form
    {
        public Form14TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string prod = this.txtAgregar.Text;
            this.lstTienda.SelectedIndex = -1;

            if (this.lstTienda.Items.Contains(prod))
            {
                for (int i = 0; i < this.lstTienda.Items.Count; i++)
                {
                    if (this.lstTienda.Items[i].ToString() == prod)
                    {
                        this.lstTienda.SelectedIndex = i;
                    }
                }
            }
            else
            {
                this.lstTienda.Items.Add(prod);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numSeleccionados = this.lstTienda.SelectedIndices.Count;
            for (int j = (numSeleccionados - 1); j >= 0; j--)
            {
                int i = this.lstTienda.SelectedIndices[j];
                this.lstTienda.Items.RemoveAt(i);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                string item = this.lstTienda.Items[index].ToString();
                this.lstAlmacen.Items.Add(item);
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (var item in this.lstTienda.Items)
            {
                this.lstAlmacen.Items.Add(item);
            }

            this.lstTienda.Items.Clear();
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            this.btnSubir.Enabled = index == 0 ? false : true;
            this.btnBajar.Enabled = index == this.lstAlmacen.Items.Count - 1 ? false : true;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            if (index > 0)
            {
                string item = this.lstAlmacen.Items[index].ToString();
                this.lstAlmacen.Items.RemoveAt(index);
                this.lstAlmacen.Items.Insert(index - 1, item);
                this.lstAlmacen.SelectedIndex = index - 1;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            if (index < this.lstAlmacen.Items.Count - 1)
            {
                string item = this.lstAlmacen.Items[index].ToString();
                this.lstAlmacen.Items.RemoveAt(index);
                this.lstAlmacen.Items.Insert(index + 1, item);
                this.lstAlmacen.SelectedIndex = index + 1;
            }
        }
    }
}
