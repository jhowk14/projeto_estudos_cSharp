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
    public partial class frmAlg5 : Form
    {
        double tab, resultado; // declarando as variaveis
        public frmAlg5()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            btoTab.Items.Clear(); //limpar os itens da lista

            lbltab.Text = $"Tabuada do {txtTab.Text}";

            if (double.TryParse(txtTab.Text, out tab)) // fazer a conversao de string para numerico
            {

                for (int i = 0; i <= 10; i++) // loop da que vai conseguir os resultados
                {
                    resultado = tab * i; // formula do resultaso da tabuada

                    btoTab.Items.Add($"{tab} x {i} = {resultado}"); // adiciosnar os resultados da lista
                };
            }
        }

        private void frmAlg5_Load(object sender, EventArgs e)
        {

        }
    }
}
