using System;
using System.Windows.Forms;

namespace UD19_EJ3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.SetRange(0, 10);
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = "" + trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resRadio = "";
            string resCheck = "";

            //radiobutton
            if (radioButton1.Checked)
                resRadio = "Windows";
            else if (radioButton2.Checked)
                resRadio = "Linux";
            else if(radioButton3.Checked)
                resRadio = "Mac";

            //checkbox
            if (checkBox1.Checked)
                resCheck += "Programación ";
            if (checkBox2.Checked)
                resCheck += "Diseño gráfico ";
            if (checkBox3.Checked)
                resCheck += "Administración ";

            //mostrar
            MessageBox.Show("Sistema operativo: " + resRadio + "\nEspecialidad: " + resCheck + "\nHoras: " + trackBar1.Value);

            //limpiar
            resRadio = "";
            resCheck = "";
        }

    }
}
