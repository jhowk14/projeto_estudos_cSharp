using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T31_ProjetoBase
{
    public partial class POO : Form
    {
        public POO()
        {
            InitializeComponent();

        }

        int numeroSorteado;

        private void btnPalp_Click(object sender, EventArgs e)
        {


            if (int.TryParse(txtPalp.Text, out int n))
            {
                if (n == numeroSorteado)
                {
                    MessageBox.Show("Voce acertou o numero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    string mensagem = n > numeroSorteado ? "Seu palpite está muito alto." : "Seu palpite está muito baixo.";
                    MessageBox.Show($"voce errou o numero {mensagem}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



                }
            }
            else
            {
                MessageBox.Show("INFORME UM NUMERO VALIDO", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPalp.Text = "";
            }
        }

        public void POO_Load(object sender, EventArgs e)
        {
            
                int[] numeros = new int[100];
                for (int i = 0; i < 100; i++)
                {
                    numeros[i] = i + 1;
                }
                Random random = new Random();
                numeroSorteado = numeros[random.Next(100)];
            
        }
    }
    public class Jogo
    {
        public Jogo()
        {

        }
    }
}
