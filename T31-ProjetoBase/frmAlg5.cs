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
        public frmAlg5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lboResultado.Items.Clear(); 
            for (int i = 1; i <= 10; i++)
            {
                lboResultado.Items.Add(i + " x " + txtTabuada.Text + 
                    " = " + i * int.Parse(txtTabuada.Text));
            }
        }
    }
}
