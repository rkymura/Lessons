namespace AulaFatorialREP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numero = int.Parse(textBox1.Text);
            var resultado = string.Empty;
            var calculo = 1;

            for (var i = numero; i > 0; i--)
            {
                var sinal = string.Empty;

                if (i > 1)
                {
                    sinal = sinal + " * ";
                }

                else
                {
                    sinal = sinal + " = ";
                }

                resultado = resultado + i + sinal;
                calculo = i * calculo;
            }

            label1.Text = resultado + calculo;

            }
        }
    }

