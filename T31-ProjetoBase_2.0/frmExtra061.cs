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
    public partial class frmExtra061 : Form
    {
        private Odomentro odometro;
        public frmExtra061()
        {
            odometro = new Odomentro();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = odometro.Rodar();
            char[] car = num.ToCharArray();

            txt1.Text = car[0].ToString();
            txt2.Text = car[1].ToString();
            txt3.Text = car[2].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num = odometro.Rodar(txt4.Text);
            if (int.TryParse(num, out int n))
            {
                char[] car = num.ToCharArray();

                txt1.Text = car[0].ToString();
                txt2.Text = car[1].ToString();
                txt3.Text = car[2].ToString();
            }
            else
            {
                MessageBox.Show($"{num}");
            }
                
        }
    }
    public class Odomentro
    {
        public Odomentro()
        {
        }
        public string Rodar()
        {
            StringBuilder sb = new StringBuilder();
            string n1 = "", n2 = "", n3 = "";
            for (int i = 0; i <= 999; i++)
            {
                string num = i.ToString();
                char[] car = num.ToCharArray();
                if (car.Length == 1)
                {
                    n3 = car[0].ToString();
                }
                else if (car.Length == 2)
                {
                    n2 = car[0].ToString();
                    n3 = car[1].ToString();
                }
                else if (car.Length == 3)
                {
                    n1 = car[0].ToString();
                    n2 = car[1].ToString();
                    n3 = car[2].ToString();
                }
            }
            sb.AppendLine($"{n1}{n2}{n3}");
            return sb.ToString();
        }
        public string Rodar(string number)
        {
            if (int.TryParse(number, out int n))
            {
                if (number.Length == 3)
                {
                    StringBuilder sb = new StringBuilder();
                    string n1 = "", n2 = "", n3 = "";
                    for (int i = 0; i <= n; i++)
                    {
                        string num = i.ToString();
                        char[] car = num.ToCharArray();
                        if (car.Length == 1)
                        {
                            n3 = car[0].ToString();
                        }
                        else if (car.Length == 2)
                        {
                            n2 = car[0].ToString();
                            n3 = car[1].ToString();
                        }
                        else if (car.Length == 3)
                        {
                            n1 = car[0].ToString();
                            n2 = car[1].ToString();
                            n3 = car[2].ToString();
                        }
                    }
                    sb.AppendLine($"{n1}{n2}{n3}");
                    return sb.ToString();
                }
                else
                {
                    return "digite um numero de trez digitos";
                }
            }
            else
            {
                return "digite um numero valido";
            }
            
        }
    }
}
