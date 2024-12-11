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
    public partial class FormDateTime : Form
    {
        public FormDateTime()
        {
            InitializeComponent();
            // Al iniciar la clase escribiremos la fecha actual
            txtFechaAct.Text = DateTime.Now.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkCambiar_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFechaAct.Text);
            if (this.chkCambiar.Checked)
            {
                this.txtFechaAct.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtFechaAct.Text = fecha.ToShortDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFechaAct.Text);
            if (this.rbDias.Checked)
            {
                fecha = fecha.AddDays(incremento);
            } 
            else if(this.rbMeses.Checked)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else if(this.rbAnios.Checked)
            {
                fecha = fecha.AddYears(incremento);
            }
            this.txtNuevaFecha.Text = fecha.ToString();
        }
    }
}
