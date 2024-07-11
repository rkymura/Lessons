namespace Aula_02___qualomesrepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mesLetra = textBox1.Text;

            if (mesLetra == "janeiro" || mesLetra == "Janeiro")
            {
                MessageBox.Show("1");
            }

            else if (mesLetra == "fevereiro" || mesLetra == "Fevereiro")
            {
                MessageBox.Show("2");
            }

            else if (mesLetra == "marco" || mesLetra == "Marco")
            {
                MessageBox.Show("3");
            }

            else if (mesLetra == "abril" || mesLetra == "Abril")
            {
                MessageBox.Show("4");
            }

            else if (mesLetra == "maio" || mesLetra == "Maio")
            {
                MessageBox.Show("5");
            }

            else if (mesLetra == "junho" || mesLetra == "Junho")
            {
                MessageBox.Show("6");
            }

            else if (mesLetra == "julho" || mesLetra == "Julho")
            {
                MessageBox.Show("7");
            }

            else if (mesLetra == "agosto" || mesLetra == "Agosto")
            {
                MessageBox.Show("8");
            }

            else if (mesLetra == "setembro" || mesLetra == "Setembro")
            {
                MessageBox.Show("9");
            }

            else if (mesLetra == "outubro" || mesLetra == "Outubro")
            {
                MessageBox.Show("10");
            }

            else if (mesLetra == "novembro" || mesLetra == "Novembro")
            {
                MessageBox.Show("11");
            }

            else if (mesLetra == "dezembro" || mesLetra == "Dezembro")
            {
                MessageBox.Show("12");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mes = int.Parse(textBox1.Text);

            if (mes <= 0)
            {
                MessageBox.Show("Invalido");
            }

            else if (mes >= 0 && mes <= 1)
            {
                MessageBox.Show("Janeiro");
            }

            else if (mes >= 1 && mes <= 2)
            {
                MessageBox.Show("Fevereiro");
            }

            else if (mes >= 2 && mes <= 3)
            {
                MessageBox.Show("Marco");
            }

            else if (mes >= 3 && mes <= 4)
            {
                MessageBox.Show("Abril");
            }

            else if (mes >= 4 && mes <= 5)
            {
                MessageBox.Show("Maio");
            }

            else if (mes >= 5 && mes <= 6)
            {
                MessageBox.Show("Junho");
            }

            else if (mes >= 6 && mes <= 7)
            {
                MessageBox.Show("Julho");
            }

            else if (mes >= 7 && mes <= 8)
            {
                MessageBox.Show("Agosto");
            }

            else if (mes >= 8 && mes <= 9)
            {
                MessageBox.Show("Setembro");
            }

            else if (mes >= 9 && mes <= 10)
            {
                MessageBox.Show("Outubro");
            }

            else if (mes >= 10 && mes <= 11)
            {
                MessageBox.Show("Novembro");
            }

            else if (mes >= 11 && mes <= 12)
            {
                MessageBox.Show("Dezembro");
            }

            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
