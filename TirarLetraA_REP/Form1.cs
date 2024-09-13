namespace TirarLetraA_P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = textBox1.Text;
            var resultado = contadorDeLetras(nome);
            label1.Text = resultado.ToString();
        }

        public int contadorDeLetras(string nome) 
        {
            var quebrarPalavra = nome.ToArray();
            var contador = 0;

            for (var i = 0; i < nome.Count(); i++)
            {
                if (quebrarPalavra[i].ToString() == "a")
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
