namespace Aula02_Qualomes_rep2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mesLetra = textBox1.Text;
            var resultado = contadorDeLetras(mesLetra);
            label1.Text = resultado.ToString();
        }

        public int contadorDeLetras(string mesLetra)
        {
            var contador = 0;

            for (var i = 0; i < mesLetra.Count(); i++)
            {
                if (mesLetra[i].ToString() = mesLetra[i]) 
                {
                    contador++;
                }

                return contador;
            }
        }
    }