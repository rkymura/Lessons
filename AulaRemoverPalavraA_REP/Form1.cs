namespace AulaRemoverPalavraA
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

            for (var i = 0; i < quebrarPalavra.Count(); i++) 
            { 
                if (quebrarPalavra[i].ToString() != "a")
                {
                    resultado = resultado + quebrarPalavra[i].ToString();
                }

                label1.Text = "A palavra sem a letra A eh:" + resultado;         
            }
        }
    }
}
