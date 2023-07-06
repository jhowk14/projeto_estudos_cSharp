using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace T31_ProjetoBase
{
    public partial class frmBco4 : Form
    {
        private string conexao = ConfigurationManager.ConnectionStrings[2].ConnectionString;
        public frmBco4()
        {
            InitializeComponent();
        }
        private void resetaTela()
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                    textBox.Enabled = false;
                }
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = false;
                    btnAdicionar.Enabled = true;
                }
            }
        }
    }
}
