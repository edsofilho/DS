using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_operacao_forms
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, soma, mul, div, sub, n3;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            n3 = double.Parse(txt_numero3.Text);

            soma = n1 + n2 + n3;

            txt_resultado.Text = soma.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1, n2, soma, mul, div, sub, n3;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            n3 = double.Parse(txt_numero3.Text);
           
            sub = n1 - n2 - n3;

            txt_resultado.Text = sub.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2, soma, mul, div, sub, n3;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            n3 = double.Parse(txt_numero3.Text);

            div = n1 / n2 / n3;
            txt_resultado.Text = div.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1, n2, soma, mul, div, sub, n3;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            n3 = double.Parse(txt_numero3.Text);

            mul = n1 * n2 * n3;
        
            txt_resultado.Text = mul.ToString();
        }
    }
}
