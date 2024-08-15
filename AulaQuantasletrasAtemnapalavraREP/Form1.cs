namespace AulaQuantasletrasAtemnapalavraREP
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
            var contador = 0;

            for (var i = 0; i < palavra.Count(); i++) 
            { 
                if (quebrarPalavra[i].ToString() == "a")
                {
                    contador++;
                }
            }

            label1.Text = "Quantas palavras A tem na frase?" + contador;
        }
    }
}
