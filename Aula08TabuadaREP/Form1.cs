namespace Aula08TabuadaREP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var de = int.Parse(textBox1.Text);
            var ate = int.Parse(textBox2.Text);
            var imprimir = "";

            for (var i = 0; i < ate; i++)
            {
                var resultado = de * i;
                imprimir = imprimir + de + " " + " x " + i + " = " + resultado + "\n";
            }

            label1.Text = imprimir;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
