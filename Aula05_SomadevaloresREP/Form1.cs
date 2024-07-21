namespace Aula05_SomadevaloresREP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var numero1 = int.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var operador = textBox3.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var numero2 = int.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var operador = textBox3.Text;

            if (operador == "+")
            {
                var resultado = int.Parse(textBox2.Text) + int.Parse(textBox1.Text);
                MessageBox.Show(resultado + "");
            }

            else if (operador == "-")
            {
                var resultado = int.Parse(textBox2.Text) - int.Parse(textBox1.Text);
                MessageBox.Show(resultado + "");
            }

            else if (operador == "*")
            {
                var resultado = int.Parse(textBox2.Text) * int.Parse(textBox1.Text);
                MessageBox.Show(resultado + "");
            }

            else if (operador == "/")
            {
                var resultado = int.Parse(textBox2.Text) / int.Parse(textBox1.Text);
                MessageBox.Show(resultado + "");
            }
        }
    }
}
