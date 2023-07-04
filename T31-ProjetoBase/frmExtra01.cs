using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T31_ProjetoBase
{
    public partial class frmExtra01 : Form
    {
        public frmExtra01()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Obtém o valor digitado pelo usuário
            string entrada = txtNumero.Text;

            // Converte o valor para um número inteiro
            int numero;
            bool successo = int.TryParse(entrada, out numero);

            if (successo)
            {
                // Verifica se o número é par ou ímpar
                string resultado = (numero % 2 == 0) ? "par" : "ímpar";

                // Exibe uma mensagem com o resultado
                MessageBox.Show($"O número {numero} é {resultado}.");
            }
            else
            {
                // Exibe uma mensagem de erro caso o valor digitado não seja um número
                MessageBox.Show("Digite um número válido.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int idade = random.Next(0, 50);
            string nome = "João";

            string mensagem = $"{nome} tem {idade} {(idade >= 18 ? "anos" : "anos > Ainda não pode tirar a CNH")}.";

            MessageBox.Show(mensagem);

        }
    }
}
