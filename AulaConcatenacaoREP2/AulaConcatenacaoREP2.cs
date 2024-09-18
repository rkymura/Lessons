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
            var resultado = (textBox1.Text) + (textBox2.Text);
            label1.Text = resultado;
        }

        public string resultado (string primeiraPalavra, string segundaPalavra)// sem utilidade perguntar pro Andre
        {
            return primeiraPalavra + segundaPalavra;// sem utilidade perguntar pro Andre
        }
    }
}
