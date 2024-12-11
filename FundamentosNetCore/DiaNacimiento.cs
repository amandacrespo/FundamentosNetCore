using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FundamentosNetCore
{
    public partial class DiaNacimiento : Form
    {
        public DiaNacimiento()  
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anio = int.Parse(txtAnio.Text);

            string[] diasSemana = { "Sábado", "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };

            // si el mes es Enero, el Mes será 13 y restaremos uno al año. 
            // Si el Mes es Febrero, el Mes será 14 y restaremos uno al año.

            if (mes == 1)
            {
                mes = 13;
                anio--;
            } 
            else if (mes == 2)
            {
                mes = 14;
                anio--;
            }

            // 1.Multiplicar el Mes más 1 por 3 y dividirlo entre 5
            int op1 = ((mes + 1) * 3) / 5;

            // 2.Dividir el año entre 4
            int op2 = anio / 4;

            // 3.Dividir el año entre 100
            int op3 = anio / 100;

            // 4.Dividir el año entre 400
            int op4 = anio / 400;

            // 5.Sumar el dia, el doble del mes, el año, el resultado de la operación 1,
            // el resultado de la operación 2, menos el resultado de la operación 3 más la operación 4 más 2.
            int op5 = dia + (mes*2) + anio + op1 + op2 - op3 + op4 + 2;

            // 6.Dividir el resultado anterior entre 7.
            int op6 = op5 / 7;

            // 7.Restar el número del paso 5 con el número del paso 6 por 7.
            int op7 = op5 - op6 * 7;

            string res = diasSemana[op7];
            lblRespuesta.Text = res;
        }
    }
}
