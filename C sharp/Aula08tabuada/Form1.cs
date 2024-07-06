namespace Aula29Mar
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
            var numero = int.Parse(textBox1.Text);
            int resultado;

            for (var i = 0; i < 10; i++) 
            {
                resultado = numero * i;
                MessageBox.Show(resultado.ToString());
            }
             
            
        }

    }
}
