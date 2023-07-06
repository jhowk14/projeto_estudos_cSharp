using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace T31_ProjetoBase
{
    public partial class frmExtra02 : Form
    {
        public frmExtra02()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            // Obter a cidade selecionada no ComboBox
            string? selectedCity = cboCidades.SelectedItem as string;

            if (selectedCity != null)
            {
                // Exibir uma mensagem com a cidade selecionada
                MessageBox.Show($"Cidade selecionada: {selectedCity}");
            }
        }
    }
}
