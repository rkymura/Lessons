namespace Aula_CelsiusXFar_REP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fahrenheit = int.Parse(textBox1.Text);
            var conversao = fahrenheitParaCelsius(fahrenheit);

            MessageBox.Show(conversao + " °C");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var celsius = int.Parse(textBox1.Text);
            var conversao2 = celsiusParaFahrenheit(celsius);

            MessageBox.Show(conversao2 + " °F");
        }

        public int fahrenheitParaCelsius(int fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public int celsiusParaFahrenheit(int celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}