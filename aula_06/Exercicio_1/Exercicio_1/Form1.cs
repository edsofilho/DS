using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_1
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

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, media;

            nota1 = double.Parse(txt_nota1.Text);
            nota2 = double.Parse(txt_nota2.Text);
            nota3 = double.Parse(txt_nota3.Text);
            nota4 = double.Parse(txt_nota4.Text);

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media < 5)
            {
                label_resultado.Text = "Sua nota final é I";
                label_resultado.ForeColor = Color.Red;
            }
            else if (media >= 5 && media < 7)
            {
                label_resultado.Text = "Sua nota final é R";
                label_resultado.ForeColor = Color.Orange;
            }
            else if(media >=7 && media < 9)
            {
                label_resultado.Text = "Sua nota final é B";
                label_resultado.ForeColor = Color.Blue;
            }
            else
            {
                label_resultado.Text = "Sua nota final é MB";
                label_resultado.ForeColor = Color.Green;
            }

        }
    }
}
