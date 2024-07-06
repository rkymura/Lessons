namespace Aula_01___idade_repeticao
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

            else if (idade >= 1  && idade <= 9)
            {
                MessageBox.Show("voce eh uma crianca");
            }

            else if (idade >= 10 && idade <= 17)
            {
                MessageBox.Show("voce eh um adolescente");
            }

            else if (idade >= 18 && idade <= 60)
            {
                MessageBox.Show("Voce eh um adulto");
            }

            else if (idade >= 61 && idade <= 100)
            {
                MessageBox.Show("Voce eh um idoso");
            }

            else if (idade >= 101 && idade <= 130)
            {
                MessageBox.Show("Voce eh um anciao");
            }

            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
