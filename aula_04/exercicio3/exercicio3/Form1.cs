using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void text_nota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(text_nota1.Text);
            double nota2 = double.Parse(text_nota2.Text);
            double nota3 = double.Parse(text_nota3.Text);

            nota1 = nota1 * 2;
            nota2 = nota2 * 3;
            nota3 = nota3 * 5;

            double media = (nota1 + nota2 + nota3) / 10;

            text_media.Text = media.ToString(); 
        }
    }
}
