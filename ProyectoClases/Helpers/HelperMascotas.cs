using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas {  get; set; }
        private string Path;

        public HelperMascotas(string path)
        {
            this.Mascotas = new List<Mascota>();
            this.Path = path;
        }

        public string ConvertirColeccionString()
        {
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                data += mascota.GetMascota() + "@";
            }
            data = data.Trim('@');
            return data;
        }

        public void ConvertirStringColeccion(string data)
        {
            this.Mascotas.Clear();
            string[] datos = data.Split('@');
            foreach (var item in datos)
            {
                string[] props = item.Split(",");
                this.Mascotas.Add(new Mascota(props[0], props[1]));
            }
        }

        public async Task WriteMascotasAsync()
        {
            string data = this.ConvertirColeccionString();
            await HelpersFiles.WriteFilesAsync(this.Path, data);
        }

        public async Task ReadMascotasAsync()
        {
            string data = await HelpersFiles.ReadFilesAsync(this.Path);
            this.ConvertirStringColeccion(data);
        }
    }
}
