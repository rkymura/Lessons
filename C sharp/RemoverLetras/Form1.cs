namespace RemoverLetras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = new List<char>(); //  estudar char
            var resultado = string.Empty;

            lista.Add('p'); //  char aspas simples
            lista.Add('a');
            lista.Add('r');
            lista.Add('a');
            lista.Add('l');
            lista.Add('e');
            lista.Add('l');
            lista.Add('a');
            //lista.RemoveAt(3);// remover as letras "A" fazer codigo na mao
            
            for (var i =  0; i < lista.Count; i++) 
            {
                if (lista[i].ToString() == "a")
                {
                   lista.RemoveAt(i);
                }         
            }

            for (var j = 0; j < lista.Count; j++) 
            { 
                resultado = resultado + lista[j].ToString();
            }
        
            label1.Text = "A palavra removida eh:" + resultado;
        }
    }
}
