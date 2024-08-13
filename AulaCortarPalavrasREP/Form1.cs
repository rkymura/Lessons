namespace AulaCortarPalavrasREP
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
            var cortarPalavra = palavra.ToArray();
            var totalDeLetras = cortarPalavra.Length;
            var resultado = string.Empty;

            for (var i = 1; i < palavra.Count(); i++)
            {
                if (i < 4)
                {
                    resultado += cortarPalavra[palavra.Count() - i].ToString();
                }
            }

            var ultimasTresLetras = string.Empty;
            var quebrarPalavraResultado = resultado.ToArray();

            for (var i = 1; i <= resultado.Count(); i++) 
            {
                ultimasTresLetras = ultimasTresLetras + quebrarPalavraResultado[resultado.Count() - i].ToString();
            }
               
            label1.Text = "A palavra cortada eh:\n" + ultimasTresLetras;
        }
    }
}
