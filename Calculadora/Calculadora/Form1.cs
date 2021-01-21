using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        bool calcula = true;
        bool punto = true;

        string simbol;      // + - * /
        string borrado;
        string point;

        double n;           //primer nombre
        double m;           //segon nombre
        double resultat;    //resultat

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (calcula == true)
            {
                textBox1.Text = "";
                textBox1.Text = "1";
                calcula = false;
                punto = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (calcula == true)
            {
                textBox1.Text = "";
                textBox1.Text = "2";
                calcula = false;
                punto = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (calcula == true)
            {
                textBox1.Text = "";
                textBox1.Text = "3";
                calcula = false;
                punto = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (calcula == true)
            {
                textBox1.Text = "";
                textBox1.Text = "4";
                calcula = false;
                punto = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calcula == true)
            {
                textBox1.Text = "";
                textBox1.Text = "5";
                calcula = false;
                punto = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (calcula == true)
            {
                textBox1.Text = "";
                textBox1.Text = "6";
                calcula = false;
                punto = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (calcula == true)
            {
                textBox1.Text = "";
                textBox1.Text = "7";
                calcula = false;
                punto = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (calcula == true)
            {
                textBox1.Text = "";
                textBox1.Text = "8";
                calcula = false;
                punto = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (calcula == true)
            {
                textBox1.Text = "";
                textBox1.Text = "9";
                calcula = false;
                punto = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                return;
            }

            else
            {
                if (calcula == true)
                {
                    textBox1.Text = "0";
                    punto = true;
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";
                }

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            simbol = "+";
            n = double.Parse(textBox1.Text);
            calcula = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            simbol = "-";
            n = double.Parse(textBox1.Text);
            calcula = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            simbol = "*";
            n = double.Parse(textBox1.Text);
            calcula = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            simbol = "/";
            n = double.Parse(textBox1.Text);
            calcula = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            m = double.Parse(textBox1.Text);
            if (simbol == "+")
            {
                resultat = n + m;
                textBox1.Text = resultat.ToString();
                calcula = true;
            }

            if (simbol == "-")
            {
                resultat = n - m;
                textBox1.Text = resultat.ToString();
                calcula = true;
            }

            if (simbol == "*")
            {
                resultat = n * m;
                textBox1.Text = resultat.ToString();
                calcula = true;
            }

            if (simbol == "/")
            {
                resultat = n / m;
                textBox1.Text = resultat.ToString();
                calcula = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (punto == true)
            {
                textBox1.Text = textBox1.Text + ",";
                punto = false;
            }
            else
            {
                return;
            }
            calcula = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            n = 0;
            m = 0;
            calcula = true;
            punto = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int y = 0;
            int z = 0;
            borrado = textBox1.Text;
            point = textBox1.Text;
            y = borrado.Length - 1;
            z = point.Length - 1;
            point = point.Substring(z, 1);
            borrado = borrado.Substring(0, y);
            textBox1.Text = borrado;

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                calcula = true;
            }

            if (textBox1.Text == "-")
            {
                textBox1.Text = "0";
                calcula = true;
            }

            if (point == ",")
            {
                punto = true;
            }
        }
    }
}