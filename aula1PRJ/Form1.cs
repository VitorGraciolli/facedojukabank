using System.Diagnostics.Eventing.Reader;

namespace aula1PRJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTlogar_Click(object sender, EventArgs e)
        {
            //codigo quando o botão logar for clicado
            //senha autenticada usuario autenticado
            if (TXTlogin.Text == "12345678900" && TXTsenha.Text == "123321")
            {

                LBLloginmensagem.Text = "usuario autenticado";
            }
            else
            {

                LBLloginmensagem.Text = "login ou senha errada";

            }

        }

        private void LBLloginmensagem_Click(object sender, EventArgs e)
        {

        }
    }
}