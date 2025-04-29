using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSIMples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNum2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btlCalcular_Click(object sender, EventArgs e)
        {
            // Pegar os números da interface:
            int n1, n2;
            n1 = (int)numeric1.Value;
            n2 = (int)numeric2.Value;

            //Verificar qual opc está marcada:
            if (rbSoma.Checked)
            {
                txbResultado.Text = (n1 + n2).ToString();
            }
            else if (rbSub.Checked)
            {
                txbResultado.Text = (n1 - n2).ToString();
            }
            else if (rbMult.Checked)
            {
                txbResultado.Text = (n1 * n2).ToString();
            }
            else if (rbDiv.Checked)
            {
                if (n2 != 0)
                {
                    txbResultado.Text = (n1 / n2).ToString();
                }
                else
                {
                    txbResultado.Text = "Erro!";
                }
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Retornar os nud's aos valores originais:
            numeric1.Value = 0;
            numeric2.Value = 0;

            //Retornar os radios para false:
            rbMult.Checked = false;
            rbDiv.Checked = false;
            rbSub.Checked = false;
            rbSoma.Checked = false;

            //Limpar a caixa de resultado:
            txbResultado.Text = "";
            txbResultado.Clear(); //Igual ao de cima
        }
    }
}
