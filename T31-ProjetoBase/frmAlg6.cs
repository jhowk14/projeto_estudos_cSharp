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
    public partial class frmAlg6 : Form
    {
        public frmAlg6()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string entrada = txtNumero.Text;

            // Converte o valor para um número inteiro
            int numero;
            bool successo = int.TryParse(entrada, out numero);

            if (successo)
            {
                lboNumeros.Items.Add(entrada.ToString());
            }
            else
            {
                // Exibe uma mensagem de erro caso o valor digitado não seja um número
                MessageBox.Show("Digite um número válido.", "Atenção", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtNumero.Text = String.Empty;
            txtNumero.Focus();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            OrdenarNumeros();
        }

        private void OrdenarNumeros()
        {
            // Criar uma lista para armazenar os números
            List<int> numeros = new List<int>();

            // Adicionar os números da ListBox à lista
            foreach (var item in lboNumeros.Items)
            {
                if (int.TryParse(item.ToString(), out int numero))
                {
                    numeros.Add(numero);
                }
            }

            // Ordenar a lista de números em ordem crescente
            numeros.Sort();

            // Limpar a ListBox
            lboNumeros.Items.Clear();

            // Adicionar os números ordenados de volta à ListBox
            foreach (int numero in numeros)
            {
                lboNumeros.Items.Add(numero);
            }
        }

    }
}
