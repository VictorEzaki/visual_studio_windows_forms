using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decisao_repeticao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                int num, cont, tab;
                num = Convert.ToInt16(inpNum.Text);
                if (cbxFor.Checked) // se a opção escolhida for o FOR
                {
                    for (cont = 0; cont <= 10; cont++)
                    {
                        tab = num * cont;
                        lbxTabuada.Items.Add(num.ToString() + " * " + cont.ToString() + " = "
                       + tab.ToString());
                    }
                }
                if (cbxDoWhile.Checked) // se a opção escolhida for o Do While
                {
                    cont = 0;
                    do
                    {
                        tab = num * cont;
                        lbxTabuada.Items.Add(num.ToString() + " * " + cont.ToString() + " = " +
                        tab.ToString());
                        cont++;
                    }
                    while (cont <= 10);
                }
                if (cbxWhile.Checked) // se a opção escolhida for o While
                {
                    cont = 0;
                    while (cont <= 10)
                    {
                        tab = num * cont;
                        lbxTabuada.Items.Add(num.ToString() + " * " + cont.ToString() + " = "
                       + tab.ToString());
                        cont++;
                    }
                }
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbxFor.Checked = false;
            cbxWhile.Checked = false;
            cbxDoWhile.Checked = false;
            lbxTabuada.Items.Clear();

        }

        private void cbxFor_CheckedChanged(object sender, EventArgs e)
        {
            cbxDoWhile.Checked = false;
            cbxWhile.Checked = false;
        }

        private void cbxDoWhile_CheckedChanged(object sender, EventArgs e)
        {
            cbxFor.Checked = false;
            cbxWhile.Checked = false;
        }

        private void cbxWhile_CheckedChanged(object sender, EventArgs e)
        {
            cbxDoWhile.Checked = false;
            cbxFor.Checked = false;
        }
    }
}
