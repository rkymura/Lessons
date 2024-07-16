using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aula04qtsgraus_repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temperatura = int.Parse(textBox1.Text);

            if (temperatura <= 0)
            {
                MessageBox.Show("Esta congelando!");
            }

            else if (temperatura >= 0 && temperatura <= 18) 
            {
                MessageBox.Show("Esta frio!");
            }

            else if (temperatura >= 23 && temperatura <= 44) 
            {
                MessageBox.Show("Esta calor!");
            }

            else if (temperatura >= 45)
            {
                MessageBox.Show("Esta pegando fogo!");
            }

            else
            {
                MessageBox.Show("Invalido");
            }
        }
    }
}
