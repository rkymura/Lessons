namespace AulaConsultarnomenalistaREP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nomes = textBox1.Text;
            var resultado = string.Empty;

            string[] listaDeNomes = { "Martin", "Paula", "Ines", "Renata" };

            for (var i = 0; i < listaDeNomes.Count(); i++) 
            { 
                if (nomes == listaDeNomes[i]) 
                {
                    resultado = "Sim";
                    break;
                }

                else
                {
                    resultado = "Nao";
                }
            }

            label1.Text = "O nome consta na lista?" + resultado;
        }
    }
}
