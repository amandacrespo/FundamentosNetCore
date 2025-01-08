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
        protected int SalarioMinimo {  get;  set; }
        protected int Vacaciones { get; set; }
        #endregion

        #region METODOS
        public Empleado() : base("Nombre", "Apellidos")
        {
            Debug.WriteLine("Constructor de Empleado vacío");
            this.SalarioMinimo = 1400;
            this.Vacaciones = 22;
        }

        public Empleado(string nom, string apellidos)
        {
            Debug.WriteLine("Constructor de Empleado con 2 parámetros");
            this.Nombre = nom;
            this.Apellidos = apellidos;
        }

        public int GetSalarioMin()
        {
            return this.SalarioMinimo;
        }

        //public virtual int GetDiasVacaciones()
        public int GetDiasVacaciones()
        {
            Debug.WriteLine("GetDiasVacaciones() Empleado");
            return this.Vacaciones;
        }
        #endregion

    }
}
