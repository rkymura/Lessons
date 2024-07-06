namespace Consultanomenalista
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

            string[] listaDeNomes = { "Andre", "Paula", "Ines", "Martin", "Renata" };

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


            //loop for. O nome que digitar no textBox existe na lista de nomes. Se tiver o nome, o label aparece sim ou nao (consta ou nao consta na lista)
            //if e else if Lista de nomes
        }
    }
}
