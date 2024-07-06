namespace Aula07Concatenacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var palavra = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var palavra2 = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = (textBox1.Text) + (textBox2.Text);
            MessageBox.Show(resultado + "  ");
        }
    }
}
