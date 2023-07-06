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
    public partial class frmExtra03 : Form
    {
        public frmExtra03()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            lboResultado.Items.Clear();

            string frase = txtFrase.Text;

            // Exibir a palavra em maiúsculo
            lboResultado.Items.Add("Frase/Palavra em maiúsculo: " + frase.ToUpper());

            // Exibir a palavra de trás para frente
            string Reversa = "";
            // Versão 01
            for (int i = frase.Length - 1; i >= 0; i--)
            {
                Reversa += frase[i];
            }
            lboResultado.Items.Add("Versão1 - Frase/Palavra de trás para frente: " + Reversa);

            // Versão 02
            char[] caracteres = frase.ToCharArray();
            Array.Reverse(caracteres);
            Reversa = string.Join("", caracteres);
            lboResultado.Items.Add("Versão2 - Frase/Palavra de trás para frente: " + Reversa);


            // Exibir o número de caracteres da palavra
            lboResultado.Items.Add("Número de caracteres: " + frase.Length);
        }
    }
}
