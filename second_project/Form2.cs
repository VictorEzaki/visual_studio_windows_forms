using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace second_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLimites_Click(object sender, EventArgs e)
        {
            int inicio, fim, i;

            inicio = Convert.ToInt16(inpInicial.Text);
            fim = Convert.ToInt16(inpFinal.Text);

            if( inicio < fim )
            {
                for (i = inicio; i <= fim; i++)
                {
                    ltbLista.Items.Add(i);
                }
            }
            else
            {
                MessageBox.Show("ERRO DIGITE CERTO", "ATENÇÃO --> P E R I G O");
                inpInicial.Text = "";
                inpFinal.Text = "";
            }
        }
    }
}
