using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T31_ProjetoBase
{
    public partial class Api : Form
    {
        public Api()
        {
            InitializeComponent();
        }

        private async void btnAPI_Click(object sender, EventArgs e)
        {
            string API;
            API = txtAPI.Text;
            try
            {
                // Criar uma instância do HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Fazer uma chamada GET à API
                    HttpResponseMessage response = await client.GetAsync($"{API}");

                    // Verificar se a chamada foi bem-sucedida
                    if (response.IsSuccessStatusCode)
                    {
                        // Ler o conteúdo da resposta como uma string
                        string responseBody = await response.Content.ReadAsStringAsync();
                        lboAPI.Items.Add(responseBody);
                    }
                    else
                    {
                        MessageBox.Show("A chamada à API falhou com o código de status: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao fazer a chamada à API: " + ex.Message);
            }
        }
    }
}
