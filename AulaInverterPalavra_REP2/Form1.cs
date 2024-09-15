namespace AulaInverterPalavra_REP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var palavra = textBox1.Text;
            var resultado = inverterPalavra(palavra);
            label1.Text = resultado;
        }

        public string inverterPalavra(string palavra)
        {
            string palavraInvertida = "";

            for (int i = palavra.Length - 1; i >= 0; i--) 
            { 
                palavraInvertida += palavra[i];
            }

            return palavraInvertida;
        }
    }
}
