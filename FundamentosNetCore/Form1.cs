namespace FundamentosNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Esto es una propiedad";
            this.Activate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblRespuesta_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Solo escribimos aqui, entre las llaves de los eventos.
            lblRes.Text = "Hola " + txtNombre.Text;
            txtNombre.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lblRes.Text = "";
            //lblRes.Location = new Point(20, 10);
            //lblRes.TextAlign = HorizontalAlignment.Center;
            lblRes.BackColor = Color.Yellow;
            string texto = "";
        }
    }
}
