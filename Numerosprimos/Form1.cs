namespace Numerosprimos
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var de = int.Parse(textBox1.Text);
            var ate = int.Parse(textBox2.Text);
            var imprimir = "";

            for (var i = de; i <= ate; i++)
            {
                if (i % 2 == 0)
                {
                    imprimir = imprimir + i + "\n";
                }

                label1.Text = imprimir;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var de = int.Parse(textBox1.Text);
            var ate = int.Parse(textBox2.Text);
            var imprimir = "";

            for (var i = de; i <= ate; i++)
            {
                if (i % 2 == 1)
                {
                    imprimir = imprimir + i + "\n";
                }
            }

            label1.Text = imprimir;
        }
            
        private void button3_Click(object sender, EventArgs e)
        {
            var de = int.Parse(textBox5.Text);
            var ate = int.Parse(textBox3.Text);
            var imprimir = "";
            var primo = 0;
            var tem_primo = 0;


            for (int i = de; i <= ate; i++)
            {

                //Inicia o verificador sempre como zero  primo=0;

                for (int x = 1; x <= i; x++)
                {

                    if (i % x == 0)
                    {
                        primo++;
                    }

                }
                if (primo == 2)
                {
                    imprimir = imprimir + i + "\n";
                    //Mostra na tela os numeros primos um a umprintf("%d; ", i);
                    tem_primo = 1;
                }
            }

            label1.Text = imprimir;
        }

    }
}