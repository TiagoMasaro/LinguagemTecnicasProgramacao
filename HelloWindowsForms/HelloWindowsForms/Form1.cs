namespace HelloWindowsForms
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(textPeso.Text);
            double altura = double.Parse(textAltura.Text);
            double imc = peso / (altura * altura);
            lblResultado.Text = $"IMC Calculado: {imc:F2} ";

            if (imc < 18.5)
            {
                lblInterpretacao.Text = "Abaixo do peso! ";
            }else if (imc >=18.5 && imc < 25)
            {
                lblInterpretacao.Text = "Peso ideal!";
            }else if(imc >= 25 && imc < 30)
            {
                lblInterpretacao.Text = "Sobrepeso / GRAU I";
            }else if (imc >= 30 && imc < 40)
            {
                lblInterpretacao.Text = "Obesidade / GRAU II";
            }else if (imc >= 40)
            {
                lblInterpretacao.Text = "Obesidade / GRAU III";
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
