using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        #region PROPIEDADES
        #endregion

        #region METODOS
        public Director() 
        {
            Debug.WriteLine("Constructor de Director vacío");
            this.SalarioMinimo += 200;
        }

        //public override int GetDiasVacaciones()
        public new int GetDiasVacaciones() // Metodo sobreescrito
        {
            Debug.WriteLine("GetDiasVacaciones() Director");
            this.Vacaciones = base.GetDiasVacaciones() + 8;
            return this.Vacaciones;
        }

        public int GetDiasVacaciones(int extras) // Metodo implementado
        {
            Debug.WriteLine("GetDiasVacaciones() Director extras");
            this.Vacaciones = this.GetDiasVacaciones() + extras;
            return this.Vacaciones;
        }
        #endregion
    }
}
