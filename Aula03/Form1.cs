namespace Aula03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var temperatura = int.Parse(textBox1.Text) - 32 * 5 / 9;
            MessageBox.Show(temperatura + "celsius");
        }

             private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var temperatura = int.Parse(textBox1.Text) * 9 / 5 + 32;
            MessageBox.Show(temperatura + "farenheit");
        }
    }
}