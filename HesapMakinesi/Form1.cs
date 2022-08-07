using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x,y;
        string islem;
        private void BtnBir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void Btniki_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void BtnUc_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void BtnDort_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void BtnBes_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void BtnAltı_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void BtnYedi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void BtnSekiz_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void BtnDokuz_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if(textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "+";
            label1.Text = textBox1.Text+" + ";
            textBox1.Text = "0";
        }

        private void BtnEsittir_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if (islem == "+")
            {
                textBox1.Text =Convert.ToString(x+y);
                label1.Text = "";
            }
            if (islem == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
                label1.Text = "";
            }
            if(islem== "×")
            {
                textBox1.Text = Convert.ToString(x * y);
                label1.Text = "";
            }
            if(islem== "÷")
            {
                textBox1.Text = Convert.ToString(x / y);
                label1.Text = "";
            }
            if (islem == "mod")
            {
                textBox1.Text = Convert.ToString(x % y);
                label1.Text = "";
            }
        }

        private void BtnCikar_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "-";
            label1.Text = textBox1.Text + " - ";
            textBox1.Text = "0";
        }

        private void BtnCarpma_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "×";
            label1.Text = textBox1.Text + " × ";
            textBox1.Text = "0";
        }

        private void BtnBolme_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "÷";
            label1.Text = textBox1.Text + " ÷ ";
            textBox1.Text = "0";
        }

        private void BtnKare_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(textBox1.Text);
            kare = Math.Pow(kare, 2);
            textBox1.Text = Convert.ToString(kare);
        }

        private void BtnKokAlma_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(textBox1.Text);
            karekok = Math.Sqrt(karekok);
            textBox1.Text = Convert.ToString(karekok);
        }
        private void BtnBolumx_Click(object sender, EventArgs e)
        {
            double bolumx = Convert.ToDouble(textBox1.Text);
            bolumx = 1 / (bolumx);
            textBox1.Text = Convert.ToString(bolumx);
        }
        private void BtnMod_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "mod";
            label1.Text = textBox1.Text+" (mod) ";
            textBox1.Text = "0";
        }
        private void BtnSıfır_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "0";
        }
    }
}
