using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Intrinsics.X86;

namespace Aula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mes = textBox1.Text;
            //int mes = int(texto);

            if (mes == "Janeiro" || mes == "janeiro")
            {
                MessageBox.Show("1");
            }
            else if (mes == "Fevereiro" || mes == "fevereiro")
            {
                MessageBox.Show("2");
            }
            else if (mes == "Marco" || mes == "marco")
            {
                MessageBox.Show("3");
            }
            else if (mes == "Abril" || mes == "abril")
            {
                MessageBox.Show("4");
            }
            else if (mes == "Maio" || mes == "maio")
            {
                MessageBox.Show("5");
            }
            else if (mes == "Junho" || mes == "julho")
            {
                MessageBox.Show("6");
            }
            else if (mes == "Julho" || mes == "abril")
            {
                MessageBox.Show("7");
            }
            else if (mes == "Agosto" || mes == "agosto")
            {
                MessageBox.Show("8");
            }
            else if (mes == "Setembro" || mes == "setembro")
            {
                MessageBox.Show("9");
            }
            else if (mes == "Outubro" || mes == "outubro")
            {
                MessageBox.Show("10");
            }
            else if (mes == "Novembro" || mes == "novembro")
            {
                MessageBox.Show("11");
            }
            else if (mes == "Dezembro" || mes == "dezembro")
            {
                MessageBox.Show("12");
            }
            else
            {
                MessageBox.Show("Invalido");
            }
            
            
                var numero = int.Parse(textBox1.Text);

            if (numero <= 0)
            {
                MessageBox.Show("Invalido");
            }
            else if (numero == 1)
            {
                MessageBox.Show("Janeiro");
            }
            else if (numero > 1 && numero == 2)
            {
                MessageBox.Show("Fevereiro");
            }
            else if (numero > 2 && numero == 3)
            {
                MessageBox.Show("Marco");
            }
            else if (numero > 3 && numero == 4)
            {
                MessageBox.Show("Abril");
            }
            else if (numero > 4 && numero == 5)
            {
                MessageBox.Show("Maio");
            }
            else if (numero > 5 && numero == 6)
            {
                MessageBox.Show("Junho");
            }
            else if (numero > 6 && numero == 7)
            {
                MessageBox.Show("Julho");
            }
            else if (numero > 7 && numero == 8)
            {
                MessageBox.Show("Agosto");
            }
            else if (numero > 8 && numero == 9)
            {
                MessageBox.Show("Setembro");
            }
            else if (numero > 9 && numero == 10)
            {
                MessageBox.Show("Outubro");
            }
            else if (numero > 10 && numero == 11)
            {
                MessageBox.Show("Novembro");
            }
            else if (numero > 11 && numero == 12)
            {
                MessageBox.Show("Dezembro");
            }
            else if (numero > 12)
            {
                MessageBox.Show("Invalido");

            }
        }
         private void textBox1_TextChanged(object sender, EventArgs e)
         {
         
         }
    }
}