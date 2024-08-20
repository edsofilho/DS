using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            calcular resul = new calcular();
            double valor = double.Parse(txt_val.Text);
            double tempo = double.Parse(txt_dia.Text);
            double taxa = double.Parse(txt_tax.Text);
            txt_res.Text = "" + resul.cal(valor, tempo, taxa);
        }
    }
}
