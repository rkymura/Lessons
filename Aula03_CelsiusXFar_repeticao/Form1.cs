namespace Aula03_CelsiusXFar_repeticao
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
            MessageBox.Show(temperatura + "Celsius");
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            var temperatura2 = int.Parse(textBox1.Text) * 9 / 5 + 32;
            MessageBox.Show(temperatura2 + "Fahrenheit");
        }
    }
}
