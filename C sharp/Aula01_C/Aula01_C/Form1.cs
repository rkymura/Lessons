using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Diagnostics.Eventing.Reader;

namespace Aula01_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(textBox1.Text);

            if (idade <= 0)
            {
                MessageBox.Show("Invalido");
            }
            else if (idade >= 130)
            {
                MessageBox.Show("Anciao");
            }
            else if (idade >= 1 && idade <= 9)
            {
                MessageBox.Show("Voce eh uma crianca");
            }
            else if (idade >= 10 && idade <= 17)
            {
                MessageBox.Show("Voce eh uma adolescente");
            }
            else if (idade >= 18 && idade <= 60)
            {
                MessageBox.Show("Voce eh um adulto");
            }
            else if (idade >= 60 && idade <= 130)

                MessageBox.Show("Voce eh um idoso");

            }
            
            
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
