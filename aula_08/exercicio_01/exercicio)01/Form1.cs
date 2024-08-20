using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            calcular calc = new calcular();
            double nota1 = double.Parse(txt_nota1.Text);
            double nota2 = double.Parse(txt_nota2.Text);
            double nota3 = double.Parse(txt_nota3.Text);
            double nota4 = double.Parse(txt_nota4.Text);
            txt_media.Text = "" + calc.cal(nota1, nota2, nota3, nota4);
        }
    }
}
