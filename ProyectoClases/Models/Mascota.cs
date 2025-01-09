using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Models
{
    public class Mascota
    {
        public string Nombre {  get; set; }
        public string Raza { get; set; }
        public int Years { get; set; }

        public Mascota(string nom, string raz) 
        { 
            this.Nombre = nom;
            this.Raza = raz;
        }

        public string GetMascota()
        {
            return this.Nombre + "," + this.Raza;
        }
    }
}
