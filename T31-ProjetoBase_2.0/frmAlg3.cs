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
    public partial class frmAlg3 : Form
    {
        double v1, v2, resultado;

        public frmAlg3()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(txtValor1.Text);
            v2 = double.Parse(txtValor2.Text);

            resultado = v1 + v2;
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(txtValor1.Text);
            v2 = double.Parse(txtValor2.Text);

            resultado = v1 - v2;
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(txtValor1.Text);
            v2 = double.Parse(txtValor2.Text);

            resultado = v1 / v2;
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            v1 = double.Parse(txtValor1.Text);
            v2 = double.Parse(txtValor2.Text);

            resultado = v1 * v2;
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }

        private void frmAlg3_Load(object sender, EventArgs e)
        {

        }
    }
}
