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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "1234")
            {
                frmPrincipal frm = new frmPrincipal();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Login Inválidos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
