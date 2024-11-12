namespace WinFormsApp1
{
    public partial class AulaConcatenacaoREP2 : Form
    {
        public AulaConcatenacaoREP2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var primeiraPalavra = textBox1.Text;
            var segundaPalavra = textBox2.Text;
            var resultado = concatenacao(primeiraPalavra, segundaPalavra);
            label1.Text = resultado;
        }

        public string concatenacao(string primeiraPalavra, string segundaPalavra)
        {
            return primeiraPalavra + segundaPalavra;
        }
    }
}
