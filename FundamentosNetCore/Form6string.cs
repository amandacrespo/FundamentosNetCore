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
    public partial class Form6string : Form
    {
        public Form6string()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            string mensaje = "";

            // Exista @
            if (!email.Contains('@')) // indexOf('@') == -1
            {
                mensaje += "No existe @ \n";
            }

            // Ni @ al inicio ni al final
            if (email.StartsWith('@') || email.EndsWith('@'))
            {
                mensaje += "Hay @ al inicio o al final \n";
            }

            // No exista más de una @
            if (email.IndexOf('@') != email.LastIndexOf('@'))
            {
                mensaje += "Hay más de un @ \n";
            }

            // Exista un punto 
            if (!email.Contains("."))
            {
                mensaje += "No existe ningún punto \n";
            }

            // Exista un punto después de @
            if (email.Contains("@."))
            {
                mensaje += "Existe un punto después del @ \n";
            }

            // Dominio de 2 a 4 caracteres(com, es, org, como)
            string[] partes = email.Split('.');
            if (partes != null)
            {
                string dominio = partes[partes.Length - 1];
                if (dominio.Length > 4 || dominio.Length < 2)
                {
                    mensaje += "El dominio no tiene entre 2 y 4 caractéres";
                }
            }

            this.lblError.Text = mensaje;
        }
    }
}
