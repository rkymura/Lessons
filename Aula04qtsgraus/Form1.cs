namespace Aula04qtsgraus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int temperatura = int.Parse(textBox1.Text);

            if (temperatura >= 0 && temperatura <= 18)
            {
                MessageBox.Show("Esta frio");
            }
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)

        {

        }
    }
}