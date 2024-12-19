using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosNetCore
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            //Persona persona = new Persona();
            //persona.Nombre = "Alumno";
            //persona.Apellidos = "Navidad";
            //persona.Edad = rnd.Next(1, 30);
            //persona.Genero = rnd.Next(0, 2) == 0 ? EnumGenero.Masculino : EnumGenero.Femenino;
            //persona.Pais = EnumPaises.España;
            //persona.Domicilio.Ciudad = "";

            Persona persona = new Persona
            {
                Nombre = "Alumno",
                Apellidos = "Navidad",
                Edad = rnd.Next(1, 30),
                Genero = rnd.Next(0, 2) == 0 ? EnumGenero.Masculino : EnumGenero.Femenino,
                Pais = EnumPaises.España,
                //Domicilio = new Direccion(),
                DomicilioVacaciones = new Direccion("El patio de mi casa", "Es particular", 23456),
            };

            this.lstClases.Items.Add(persona.ToString());
        } 
    }
}