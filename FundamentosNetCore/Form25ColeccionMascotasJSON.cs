using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases.Models;
using System.Xml.Serialization;
using System.Text.Json;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;

namespace FundamentosNetCore
{
    public partial class Form25ColeccionMascotasJSON : Form
    {
        ColeccionMascotas mascotasList;
        public Form25ColeccionMascotasJSON()
        {
            InitializeComponent();
            this.mascotasList = new ColeccionMascotas();
        }

        private async void btnNew_Click(object sender, EventArgs e)
        {
            Mascota m = new Mascota()
            {
                Nombre = this.txtNombre.Text,
                Raza = this.txtRaza.Text,
                Years = int.Parse(this.txtYears.Text)
            };

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
            string jsonString = JsonSerializer.Serialize(this.mascotasList);

            FileInfo file = new FileInfo("mascotasJson.json");
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(jsonString);
                await writer.FlushAsync();
                writer.Close();
                this.lstMascotas.Items.Clear();
                this.mascotasList.Clear();
                MessageBox.Show("Objeto serializado correctamente");
            }
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("mascotasJson.json");
            using (TextReader reader = file.OpenText())
            {
                string jsonString = await reader.ReadToEndAsync();
                this.mascotasList = JsonSerializer.Deserialize<ColeccionMascotas>(jsonString);
                reader.Close();
                this.DibujarMascotas();
            }
        }
    }
}
