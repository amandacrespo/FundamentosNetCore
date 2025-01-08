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
            this.SalarioMinimo = 1200;
        }
        #endregion
    }
}
