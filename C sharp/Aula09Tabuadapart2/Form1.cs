namespace Aula01._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var de = int.Parse(textBox3.Text);
            var ate = int.Parse(textBox2.Text);
            var imprimir = "";
            

            for (var i = 0; i < ate; i++)
            {
                var resultado = de * i;
                imprimir = imprimir + de + " " + " x " + i + " = " + resultado + "\n";
            }

            label2.Text = imprimir;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
