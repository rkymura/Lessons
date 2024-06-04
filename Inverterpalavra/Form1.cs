namespace Inverterpalavra
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
            var quebrarPalavra = palavra.ToArray();
            var palavraInvertida = string.Empty;
            var totalDeLetras = quebrarPalavra.Count();
            var palavraAlternativa = palavra.Reverse().ToArray();

            for (var i = 0; i < quebrarPalavra.Count(); i++)
            {
                palavraInvertida = palavraInvertida + quebrarPalavra[totalDeLetras - 1].ToString(); // palavraInvertida += quebrarPalavra[totalDeLetras - 1].ToString();
                totalDeLetras = totalDeLetras - 1; // totalDeLetras += - 1; eh a mesma coisa

                label1.Text = "A palavra invertida é:" + "\n" + palavraInvertida;
            }
        }
    }
}

