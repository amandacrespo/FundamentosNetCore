using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        private int CodigoPostal { get; set; }

        public Direccion()
        {
            Debug.WriteLine("Constructor direccion SIN params");
        }

        public Direccion(string calle,string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;

            Debug.WriteLine("Constructor direccion CON 2 params");
        }

        public Direccion(string calle, string ciudad, int cod)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cod;

            Debug.WriteLine("Constructor direccion CON 3 params");
        }

        
        public override string ToString()
        {
            return $"{this.Calle}, {this.Ciudad}, {this.CodigoPostal}";
        }
    }
}
