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
    public partial class frmAlg7 : Form
    {
        public frmAlg7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoma.Text, out int n))
            {
                int soma = 0;

                for (int i = 0; i <= n; i++)
                {
                    soma += i;
                    
                }
                lboSoma.Items.Clear();
                lboSoma.Items.Add(soma);

            }
            else
            {
                MessageBox.Show("INFORME UM NUMERO VALIDO", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSoma.Text = "";
            }
            txtSoma.Text = "";
            txtSoma.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtSoma.Text, out int n))
            {
                lboSoma.Items.Clear();
                int soma = (n/2) * (1 + n);
                lboSoma.Items.Add(soma);
            }
            else
            {
                MessageBox.Show("INFORME UM NUMERO VALIDO", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSoma.Text = "";
            }
            txtSoma.Text = "";
            txtSoma.Focus();


        }
    }
}
