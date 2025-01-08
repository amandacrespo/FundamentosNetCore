using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace FundamentosNetCore
{
    public partial class Form21Files : Form
    {
        private string Path { get; set; }

        public Form21Files()
        {
            InitializeComponent();
            // Cuando hablamos de rutas de ficheros, con caracteres especiales (\) hay 2 posibilidades:
            // C:\carpeta\file1.txt

            // 1) Utilizar \\ para escapar el caracter:
            // C:\\carpeta\\file1.txt

            // 2) Indicar que en string sea literal (@):
            // @"C:\carpeta\file1.txt"

            this.Path = "file1.txt";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
        }

        public string GetNombresListbox()
        {
            string data = "";
            foreach (var name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            //// Tenemos una clase FileInfo para generar un writer o reader.
            //FileInfo file = new FileInfo(this.Path);

            //// Creamos el fichero con TextWriter.
            //using (TextWriter writer = file.CreateText())
            //{
            //    string contenido = this.GetNombresListbox();
            //    await writer.WriteAsync(contenido);

            //    // Después de escribir en cualquier fichero se debe aplicar el metodo flush para que libere la memoria y lo deje de forma física.
            //    await writer.FlushAsync();

            //    // Por ultimo, cerramos el fichero.
            //    writer.Close();
                
            //    MessageBox.Show("Datos almacenados");
            //}

            string data = this.GetNombresListbox();
            await HelpersFiles.WriteFilesAsync(this.Path, data);
            MessageBox.Show("Datos guardados");
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            //FileInfo file = new FileInfo(this.Path);

            //// Creamos el fichero con TextWriter.
            //using (TextReader reader = file.OpenText())
            //{
            //    string contenido = await reader.ReadToEndAsync();
            //    reader.Close();
            //    this.txtContenido.Text = contenido;
            //    this.RellenarListbox(contenido);
            //}

            string data = await HelpersFiles.ReadFilesAsync(this.Path);
            this.txtContenido.Text = data;
            this.RellenarListbox(data);
        }

        public void RellenarListbox(string contenido)
        {
            string[] data = contenido.Split(',');
            this.lstNombres.Items.Clear();
            foreach (var name in data)
            {
                this.lstNombres.Items.Add(name);
            }
        }

    }
}
