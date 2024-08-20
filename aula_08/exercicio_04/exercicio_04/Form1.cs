using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Contas cal = new Contas();
            double total = double.Parse(txt_total.Text);
            double pagas = double.Parse(txt_pagas.Text);
            double valor = double.Parse(txt_valor.Text);

            txt_pago.Text = "" + cal.pago(pagas, valor);
            txt_restante.Text = "" + cal.restante(pagas, valor, total);
        }
    }
}
