using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases.Helpers;
using ProyectoClases.Models;

namespace FundamentosNetCore
{
    public partial class Form22ClaseMascota : Form
    {
        public HelperMascotas helper;
        public Form22ClaseMascota()
        {
            InitializeComponent();
            helper = new HelperMascotas("File2.txt");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota m in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(m.GetMascota());
            }
            this.lstMascotas.Items.Add(new Mascota(this.txtNombre.Text, this.txtRaza.Text).GetMascota());
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await this.helper.WriteMascotasAsync();
            MessageBox.Show("Mascotas guardadas");
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            await this.helper.ReadMascotasAsync();
            this.lstMascotas.Items.Clear();
            foreach (Mascota m in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(m.GetMascota());
            }
        }
    }
}
