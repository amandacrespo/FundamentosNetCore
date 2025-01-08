using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        #region PROPIEDADES
        public int SalarioMinimo {  get; protected set; }
        #endregion

        #region METODOS
        public Empleado() : base("Nombre", "Apellidos")
        {
            Debug.WriteLine("Constructor de Empleado vacío");
            this.SalarioMinimo = 1000;
        }

        public Empleado(string nom, string apellidos)
        {
            Debug.WriteLine("Constructor de Empleado con 2 parámetros");
            this.Nombre = nom;
            this.Apellidos = apellidos;
        }
        #endregion

    }
}
