using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        
        private String operacao;
        private Double total;
        public Form1()
        {
            InitializeComponent();
        }


        public void calcular()
        {
            Double valor = Double.Parse(txtResultado.Text);
            if ("+".Equals(operacao))
            {
                total = total + valor;
            }
            else if ("-".Equals(operacao))
            {
                total = total - valor;
            }
            else if ("/".Equals(operacao))
            {
                total = total / valor;
            }
            else if ("*".Equals(operacao))
            {
                total = total * valor;
            }

            txtResultado.Text = Convert.ToString(total);
        }


        public void adicionarNumero(String numero)
        {
                     
            txtResultado.Text = txtResultado.Text + numero;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            operacao = "0";
            total = 0;
            txtResultado.Text = "";
        }

        private void but1_Click(object sender, EventArgs e)
        {
            
            adicionarNumero("1");
;
        }

        private void but2_Click(object sender, EventArgs e)
        {
            adicionarNumero("2");
        }

        private void butSomar_Click(object sender, EventArgs e)
        {
            operacao = butSomar.Text;
            if (txtResultado.TextLength<1 || txtResultado.Equals(null))
            {
               total = 0;
            }
            else
            {

               total = Double.Parse(txtResultado.Text);
                txtResultado.Text = "";
            }
        }

        private void butIgual_Click(object sender, EventArgs e)
        {
            if (txtResultado.TextLength < 1 || txtResultado.Equals(null))
            {
                total = 0;
            }
            else
            {
                calcular();
            }
        }

        private void butDividir_Click(object sender, EventArgs e)
        {
            operacao = butDividir.Text;
            if (txtResultado.TextLength < 1 || txtResultado.Equals(null))
            {
                total = 0;
            }
            else
            {
                total = Double.Parse(txtResultado.Text);
                txtResultado.Text = "";
            }
        }

        private void butMultiplicar_Click(object sender, EventArgs e)
        {
            operacao = butMultiplicar.Text;
            if (txtResultado.TextLength < 1 || txtResultado.Equals(null))
            {
                total = 0;
            }
            else
            {
                total = Double.Parse(txtResultado.Text);
                txtResultado.Text = "";
            }
        }

        private void butSubtrair_Click(object sender, EventArgs e)
        {
            operacao = butSubtrair.Text;
            if (txtResultado.TextLength < 1 || txtResultado.Equals(null))
            {
                total = 0;
            }
            else
            {
                total = Double.Parse(txtResultado.Text);
                txtResultado.Text = "";
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            adicionarNumero("3");
        }

        private void but4_Click(object sender, EventArgs e)
        {
            adicionarNumero("4");
        }

        private void but5_Click(object sender, EventArgs e)
        {
            adicionarNumero("5");
        }

        private void but6_Click(object sender, EventArgs e)
        {
            adicionarNumero("6");
        }

        private void but7_Click(object sender, EventArgs e)
        {
            adicionarNumero("7");
        }

        private void but8_Click(object sender, EventArgs e)
        {
            adicionarNumero("8");
        }

        private void but9_Click(object sender, EventArgs e)
        {
            adicionarNumero("9");
        }
    }
}
