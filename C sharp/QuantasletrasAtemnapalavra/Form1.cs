namespace QuantasletrasAtemnapalavra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = textBox1.Text;
            var quebrarPalavra = nome.ToArray();
            var resultado = string.Empty;
            var contador = 0;

            for (var i = 0; i < nome.Count(); i++)
            {
                if (quebrarPalavra[i].ToString() == "a") 
                {
                    contador++; 
                }
            }
            label1.Text = "Quantas letras A tem a palavra acima:" + contador;
            // usar resultado para aparecer o numero de letras A
        }
    }
}
