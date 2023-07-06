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
        double num;
        
        public frmAlg6()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out num))
            {
                lboNum.Items.Add(num);
                txtNumero.Text = "";
            }
            else
            {
                MessageBox.Show("INFORME UM NUMERO VALIDO", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Text = "";
            }
        }

        private void frmAlg6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> numeros = lboNum.Items.Cast<double>().ToList();
            numeros.Sort();
            lboNum.Items.Clear();
            lboNum.Items.AddRange(numeros.Select(num => (object)num).ToArray());
        }

    }
}
