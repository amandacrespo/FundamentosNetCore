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
    public partial class Form24ColeccionSerializada : Form
    {
        XmlSerializer serializer;
        ColeccionMascotas mascotasList;
        public Form24ColeccionSerializada()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(ColeccionMascotas));
            this.mascotasList = new ColeccionMascotas();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Mascota m = new Mascota();
            m.Nombre = this.txtNombre.Text;
            m.Raza = this.txtRaza.Text;
            m.Years = int.Parse(this.txtYears.Text);
            this.mascotasList.Add(m);
            this.DibujarMascotas();
            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtYears.Clear();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota m in this.mascotasList)
            {
                this.lstMascotas.Items.Add(m.GetMascota());
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("mascotasList.xml"))
            {
                this.serializer.Serialize(writer, this.mascotasList);
                await writer.FlushAsync();
                writer.Close();
                this.lstMascotas.Items.Clear();
                this.mascotasList.Clear();
                MessageBox.Show("Objeto serializado correctamente");
            }
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("mascotasList.xml"))
            {
                this.mascotasList = (ColeccionMascotas)this.serializer.Deserialize(reader);
                reader.Close();
                this.DibujarMascotas();
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;
            if (index != -1)
            {
                Mascota mascota = this.mascotasList[index];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtYears.Text = mascota.Years.ToString();
            }
        }
    }
}
