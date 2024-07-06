namespace Cortarpalavras
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
            var totalDeLetras = quebrarPalavra.Length;
            var resultado = string.Empty;
            
            // inserir mais uma variavel (opcional) e checar o raciocinio de detectar as 3 ultimas letras ** checar exercicio palavra invertida

            for (var i = 1; i < palavra.Count(); i++)
            {
                if (i < 4)
                {
                   // resultado += quebrarPalavra[palavra.Count() - i].ToString();
                   resultado = resultado + quebrarPalavra[palavra.Count() - i].ToString();
                }
                
            }

            var ultimasTresLetras = string.Empty;
            var quebraPalavraResultado = resultado.ToArray();
            
            for (var i = 1; i <= resultado.Count(); i++) // fazer a palavra reversa pra aparecer "Motorista" (sta) ao inves de (ats)
            {
                ultimasTresLetras = ultimasTresLetras + quebraPalavraResultado[resultado.Count() - i].ToString();// corrigir no label a ordem das 3 ultimas letras OK
            }

            label1.Text = "As 3 ultimas letras são:\n" + ultimasTresLetras;

        }
    }
}
