namespace decisao_repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                double l1, l2, l3; //lados do triângulo
                l1 = Convert.ToDouble(inpLadoUm.Text);
                l2 = Convert.ToDouble(inpLadoDois.Text);
                l3 = Convert.ToDouble(inpLadoTres.Text);
                if ((l1 + l2 >= l3) && (l1 + l3 >= l2) && (l2 + l3 >= l1))//verifica se é triângulo
                {
                    if (l1 == l2 && l2 == l3 && l3 == l1)//lados iguais?
                    {
                        lblResult.Text = "Triangulo Equilátero";
                    }
                    else if (l1 == l2 || l2 == l3 || l3 == l1)// dois lados são iguais?
                    {
                        lblResult.Text = "Triangulo Isósceles";
                    }
                    else if (l1 != l2 && l2 != l3 && l3 != l1)//os lados são diferentes?
                    {
                        lblResult.Text = "Triangulo Escaleno";
                    }
                }
                else
                {
                    lblResult.Text = "Não é um triângulo";
                }
            }
            catch
            {
                lblResult.Text = "Error!";
                MessageBox.Show("Insira valores numéricos válidos!", "Erro");
            }

        }
    }
}
