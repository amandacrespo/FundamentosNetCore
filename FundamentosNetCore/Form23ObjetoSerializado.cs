using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClases.Models;

namespace FundamentosNetCore
{
    public partial class Form23ObjetoSerializado : Form
    {
        XmlSerializer serializer;
        public Form23ObjetoSerializado()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            Mascota m = null;

            // Para leer los datos dentro de un fichero debemos usar StreamReader
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                m = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();

                this.txtNom.Text = m.Nombre;
                this.txtRaz.Text = m.Raza;
                this.txtYears.Text = m.Years.ToString();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Mascota m = new Mascota();
            m.Nombre = this.txtNom.Text;
            m.Raza = this.txtRaz.Text;
            m.Years = int.Parse(this.txtYears.Text);

            // Para guardar los datos dentro de un fichero debemos usar StreamWriter
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                this.serializer.Serialize(writer, m);
                await writer.FlushAsync();
                writer.Close();
                MessageBox.Show("Objeto serializado correctamente");
            }

            this.txtNom.Text = "";
            this.txtRaz.Text = "";
            this.txtYears.Text = "";
        }
    }
}
