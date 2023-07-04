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
    public partial class frmExtra04 : Form
    {
        private JogoAdivinhacao jogo;

        public frmExtra04()
        {
            InitializeComponent();
            jogo = new JogoAdivinhacao();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int palpite;
            if (int.TryParse(txtPalpite.Text, out palpite))
            {
                string resultado = jogo.VerificarPalpite(palpite);
                MessageBox.Show(resultado);

                if (resultado == "Correto!")
                {
                    DialogResult opcao = MessageBox.Show("Você acertou! Deseja jogar novamente?",
                        "Jogo de Adivinhação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcao == DialogResult.Yes)
                    {
                        jogo.GerarNumeroSecreto();
                        txtPalpite.Clear();
                    }
                    else
                    {
                        Close();
                    }
                }
                txtPalpite.Clear();
                txtPalpite.Focus();
            }
            else
            {
                MessageBox.Show("Digite um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmExtra04_Load(object sender, EventArgs e)
        {

        }
    }

    public class JogoAdivinhacao
    {
        private int numeroSecreto;
        private Random random;

        public JogoAdivinhacao()
        {
            random = new Random();
            GerarNumeroSecreto();
        }

        public void GerarNumeroSecreto()
        {
            numeroSecreto = random.Next(1, 101);
        }

        public string VerificarPalpite(int palpite)
        {
            if (palpite < numeroSecreto)
            {
                return "Muito baixo! Tente novamente.";
            }
            else if (palpite > numeroSecreto)
            {
                return "Muito alto! Tente novamente.";
            }
            else
            {
                return "Correto!";
            }
        }
    }
}
