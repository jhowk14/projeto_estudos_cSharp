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
    public partial class frmExtra06 : Form
    {
        public frmExtra06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 999; i++)
            {
                   string num = i.ToString();
                    char[] car = num.ToCharArray();
                if (car.Length == 1) { 
                    txt3.Text = car[0].ToString();
                }
                else if (car.Length == 2)
                {
                    txt2.Text = car[0].ToString();
                    txt3.Text = car[1].ToString();
                }
                else if (car.Length == 3)
                {
                    txt1.Text = car[0].ToString();
                    txt2.Text = car[1].ToString();
                    txt3.Text = car[2].ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num;
            if(int.TryParse(txt4.Text, out int n))
            {  
                for (int i = 0; i <= n; i++)
                {
                        if(txt4.Text.Length == 3)
                        {
                            num = i.ToString();
                            char[] car = num.ToCharArray();
                            if (car.Length == 1) txt3.Text = car[0].ToString();
                            else if (car.Length == 2) {
                                txt2.Text = car[0].ToString();
                                txt3.Text = car[1].ToString();
                            }
                            else if (car.Length == 3) {
                                txt1.Text = car[0].ToString();
                                txt2.Text = car[1].ToString();
                                txt3.Text = car[2].ToString();
                                }
                        }
                        else
                            {
                                MessageBox.Show("digite um numero valido de 3 digitos");
                                break;
                            }
                }
            }
            else
            {
                MessageBox.Show("digite um numero valido");
            }
        }
    }
}
