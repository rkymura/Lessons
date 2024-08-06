namespace Aula06InvestimentosREP
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
            var numero2 = int.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = int.Parse(textBox1.Text) / int.Parse(textBox2.Text) * 100;
            MessageBox.Show(resultado.ToString() + " % ");
        }     
    }
}
