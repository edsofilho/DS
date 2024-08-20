using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_2
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

        private void button1_Click(object sender, EventArgs e)
        {
            double brancos = double.Parse(txt_brancos.Text);
            double nulos = double.Parse(txt_nulos.Text);
            double validos = double.Parse(txt_validos.Text);
            double total = brancos + nulos + validos;

            double brancosPor = (total / 100) * brancos;
            double nulosPor = (total / 100) * nulos;
            double validosPor = (total / 100) * validos;

            brancos_resultado.Text = brancosPor + "%".ToString();
            nulos_resultado.Text = nulosPor + "%".ToString();
            validos_resultado.Text = validosPor + "%".ToString();
        }
    }
}
