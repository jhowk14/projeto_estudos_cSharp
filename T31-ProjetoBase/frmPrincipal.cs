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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Olá Seja Bem-Vindo", "Testando janela...",
            //    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void algorítmo01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg1 frm = new frmAlg1();
            //frm.Show();
            frm.ShowDialog();
        }

        private void algorítmo02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg2 frm = new frmAlg2();
            frm.ShowDialog();
        }

        private void algorítmo03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlg3 frm = new frmAlg3();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlg4 frm = new frmAlg4("Estou nascendo");
            frm.ShowDialog();
        }

        private void extra01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtra01 frm = new frmExtra01();
            frm.ShowDialog();
        }

        private void extra02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtra02 frm = new frmExtra02();
            frm.ShowDialog();
        }

        private void extra03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtra03 frm = new frmExtra03();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAlg5 frm = new frmAlg5();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAlg6 frm = new frmAlg6();
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmAlg7 frm = new frmAlg7();
            frm.ShowDialog();
        }

        private void extra04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtra04 frm = new frmExtra04();
            frm.ShowDialog();
        }

        private void extra06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtra06 frm = new frmExtra06();
            frm.ShowDialog();
        }

        private void ntdExemplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBco1 frm = new frmBco1();
            frm.ShowDialog();
        }

        private void ntwExemplo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBco2 frm = new frmBco2();
            frm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBco31 frm = new frmBco31();
            frm.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBco4 frm = new frmBco4();
            frm.ShowDialog();
        }
    }
}
