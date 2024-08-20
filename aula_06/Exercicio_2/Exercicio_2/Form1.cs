using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double altura, peso, resultado;

            altura = double.Parse(txt_altura.Text);
            peso = double.Parse(txt_peso.Text);
            resultado = peso / (altura * altura);

            if(resultado < 16)
            { 
                label_resultado.Text = "Baixo peso de grau III";
            }
            else if(resultado >= 16 && resultado < 17)
            {
                label_resultado.Text = "Baixo peso de grau II";
            }
            else if (resultado >= 17 && resultado < 18.5)
            {
                label_resultado.Text = "Baixo peso de grau I";
            }
            else if (resultado >= 18.5 && resultado < 25)
            {
                label_resultado.Text = "Peso saudavel";
            }
            else if (resultado >= 25 && resultado < 30)
            {
                label_resultado.Text = "Sobrepeso";
            }
            else if (resultado >= 30 && resultado < 35)
            {
                label_resultado.Text = "Obesidade de grau I";
            }
            else if (resultado >= 35 && resultado < 40)
            {
                label_resultado.Text = "Obesidade de grau II";
            }
            else if(resultado >= 40)
            {
                label_resultado.Text = "Obesidade de grau III";
            }
        }

        private void txt_altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
