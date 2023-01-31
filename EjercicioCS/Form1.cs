namespace EjercicioCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            distancia dist = new distancia(double.Parse(txtX1.Text), double.Parse(txtY1.Text), double.Parse(txtX2.Text), double.Parse(txtY2.Text));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtX1.Text = "";
            txtX2.Text = "";
            txtY1.Text = "";
            txtY2.Text = "";

        }
    }
}