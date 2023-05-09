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

            string mensagem;
            

            if (TXTlogin.Text == string.Empty || TXTsenha.Text == string.Empty)
            {

                mensagem = "preencha os dados corretamente";
            }
            else
            {
                if (TXTlogin.TextLength < 11 || TXTsenha.TextLength < 6)
                {

                    mensagem = "confirme os caracteres e numeros digitados";

                }
                else
                {

                    if (TXTlogin.Text == "12345678900" && TXTsenha.Text == "123321")
                    {

                        mensagem = "usuario autenticado";

                    }
                    else
                    {

                        mensagem = "login ou senha errada";


                    }

                }
            }

            //mensagem no label 

            MessageBox.Show(mensagem, "aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
        
        
        
        }
        private void LBLloginmensagem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TXTsenha.UseSystemPasswordChar = false;
            if (true)
            {

                TXTsenha.UseSystemPasswordChar = true;

            }
        }
    }
}