using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum EnumGenero { Masculino, Femenino }
    public enum EnumPaises { España, Francia, Italia, Portugal, Alemania }


    public class Persona
    {
        #region PROPIEDADES
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        private int _Edad;
        public int Edad
        {
            get
            {
                return this._Edad;
            }

            set
            {
                // Se puede hacer un error silencioso (cambiar valor) o lanzar excepción (detiene el programa).
                this._Edad = (value > 0) ? value : 0;

                if (value > 0)
                {
                    this._Edad = value;
                }
                else
                {
                    throw new Exception("No has nacido, cabrón!!");
                }
            }
        }

        private EnumGenero _Genero;
        public EnumGenero Genero
        {
            get
            {
                return this._Genero;
            }
            set
            {
                if (value != EnumGenero.Masculino && value != EnumGenero.Femenino)
                {
                    throw new Exception("Error, eres tonto");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }

        public EnumPaises Pais { get; set; }
        #endregion


        #region METODOS
        public string getNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string getNombreCompleto(bool mayus)
        {
            if (mayus)
            {
                return this.getNombreCompleto().ToUpper();
            }
            else
            {
                return this.getNombreCompleto().ToLower();
            }
        }

        public override string ToString()
        {
            return $"{this.Nombre}, {this.Apellidos}, {this.Edad}, {this.Genero}, {this.Pais}, {this.DomicilioVacaciones.ToString()}";
        }
        #endregion
    }
}
