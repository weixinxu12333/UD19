using System;
using System.Windows.Forms;

namespace UD19_EJ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
            textBox2.Text = "";
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }
    }
}
