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
    public partial class Calculadora : Form
    {
        string operador;
        int a = 0;
        bool validar = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            CalculoTxt.Text = CalculoTxt.Text + bt.Text;
        }

        private void btnapaga_Click(object sender, EventArgs e)
        {
            CalculoTxt.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(CalculoTxt.Text);
                label1.Text = Convert.ToString(a) + "+ ";
                CalculoTxt.Text = "";
                operador = "+";

            }
            else
            {
                label1.Text = CalculoTxt.Text + btnmais.Text;
                a = a + Convert.ToInt32(CalculoTxt.Text);
                CalculoTxt.Text = "";
                operador = "+";
                validar = true;

            }
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(CalculoTxt.Text);
                label1.Text = Convert.ToString(a) + "  -";
                CalculoTxt.Text = "";
                operador = "-";

            }
            else
            {
                label1.Text = CalculoTxt.Text + btnmenos.Text;
                a = a + Convert.ToInt32(CalculoTxt.Text);
                CalculoTxt.Text = "";
                operador = "-";
                validar = true;


            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToInt32(CalculoTxt.Text);
                label1.Text = Convert.ToString(a) + "/ ";
                CalculoTxt.Text = "";
                operador = "/";

            }
            else
            {
                label1.Text = CalculoTxt.Text + btndiv.Text;
                a = a + Convert.ToInt32(CalculoTxt.Text);
                CalculoTxt.Text = "";
                operador = "/";
                validar = true;


            }
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToInt32(CalculoTxt.Text);
                label1.Text = Convert.ToString(a) + " * ";
                CalculoTxt.Text = "";
                operador = "*";

            }
            else
            {
                label1.Text = CalculoTxt.Text + btnmult.Text;
                a = a + Convert.ToInt32(CalculoTxt.Text);
                CalculoTxt.Text = "";
                operador = "*";
                validar = true;


            }

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                label1.Text = label1.Text + CalculoTxt.Text + "=";
                CalculoTxt.Text = Convert.ToString(a + Convert.ToSingle(CalculoTxt.Text));

            }

            else if (operador == "-")
            {
                label1.Text = label1.Text + CalculoTxt.Text + "=";
                CalculoTxt.Text = Convert.ToString(a - Convert.ToSingle(CalculoTxt.Text));

            }

            else if (operador == "*")
            {
                label1.Text = label1.Text + CalculoTxt.Text + "=";
                CalculoTxt.Text = Convert.ToString(a * Convert.ToSingle(CalculoTxt.Text));
            }


            if (operador == "/")
            {
                label1.Text = label1.Text + CalculoTxt.Text + "=";
                CalculoTxt.Text = Convert.ToString(a / Convert.ToSingle(CalculoTxt.Text));
            }
        }
    }
}
