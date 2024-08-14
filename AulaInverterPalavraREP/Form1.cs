using System.Numerics;

namespace AulaInverterPalavraREP
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
            var inverterPalavra = string.Empty;
            var totalDeLetras = quebrarPalavra.Count();
            var palavraAlternativa = palavra.Reverse().ToArray();

            for (var i = 0; i < quebrarPalavra.Count(); i++)
            {
                inverterPalavra = inverterPalavra + quebrarPalavra[totalDeLetras - 1].ToString();
                totalDeLetras = totalDeLetras - 1;

                label1.Text = "A palavra invertida é:" + "\n" + inverterPalavra;
            }
        }
    }
}
