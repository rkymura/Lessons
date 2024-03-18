namespace Aula05somavalores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var numero1 = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var operador = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var numero2 = int.Parse(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            var operador = textBox2.Text;

            if (operador == "+")
            {
                var resultado = int.Parse(textBox1.Text) + int.Parse(textBox3.Text);
                MessageBox.Show(resultado + "resultado");
            }
            else if (operador == "-")
            {
                var resultado2 = int.Parse(textBox1.Text) - int.Parse(textBox3.Text);
                MessageBox.Show(resultado2 + "resultado");
            }
            else if (operador == "*")
            {
                var resultado3 = int.Parse(textBox1.Text) * int.Parse(textBox3.Text);
                MessageBox.Show(resultado3 + "resultado");
            }
            else if (operador == "/")
            {
                var resultado4 = int.Parse(textBox1.Text) / int.Parse(textBox3.Text);
                MessageBox.Show(resultado4 + "resultado");
            }
        }   
    }
}
