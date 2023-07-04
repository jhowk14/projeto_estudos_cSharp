using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T31_ProjetoBase
{
    public partial class frmBco2 : Form
    {
        private string conexao = ConfigurationManager.ConnectionStrings[1].ConnectionString;


        public frmBco2()
        {
            InitializeComponent();
        }

        private void carregarGrid(string id)
        {
            string sql = "SELECT p.ProductID AS Codigo, p.ProductName AS Produto, p.CategoryID AS Codigo_da_Categoria, p.UnitPrice AS Preço, p.UnitsInStock AS Estoque, c.CategoryName\r\nFROM Products p\r\nINNER JOIN Categories c ON p.CategoryID = c.CategoryID\r\nWHERE p.CategoryID = @id;";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgvCategories.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void carregarCombo()
        {
            SqlConnection con = new SqlConnection(conexao);
            con.Open();
            SqlCommand sql = new SqlCommand();
            sql.Connection = con;
            sql.CommandText = "SELECT CategoryID AS id, CategoryName  AS categoria FROM Categories";
            SqlDataReader dr = sql.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);
            con.Close();

            cboSelecionar.DisplayMember = "categoria";
            cboSelecionar.ValueMember = "id";
            cboSelecionar.DataSource = tb;

        }
        private void cboSelecionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryId = cboSelecionar.SelectedValue.ToString();
            carregarGrid(categoryId);
        }

        private void frmBco2_Load(object sender, EventArgs e)
        {
            carregarCombo();
        }
    }
}
