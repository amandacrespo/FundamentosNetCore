using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClases.Models;

namespace FundamentosNetCore
{
    public partial class Form23ObjetoSerializado : Form
    {
        XmlSerializer serializer;
        public Form23ObjetoSerializado()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
           
        }
    }
}
