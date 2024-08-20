using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_somar_Click(object sender, EventArgs e)
        {
            /*
            operações matematicas é o nome da classe
            op é o nome do objeto(apelido)
            new operacoes_matematicas é a criaçao do construtor da classe.
            o codigo abaixo utilizado para ligar a classe com o formulario (instanciar objeto)
            */
            operacoes_matematicas op = new operacoes_matematicas();
            int n1 = int.Parse(text_numero1.Text);
            int n2 = int.Parse(text_numero2.Text);
            text_resultado.Text = "" + op.som(n1,n2);
        }

        private void btn_som_Click(object sender, EventArgs e)
        {
            operacoes_matematicas op = new operacoes_matematicas();
            int n1 = int.Parse(text_numero1.Text);
            int n2 = int.Parse(text_numero2.Text);
            text_resultado.Text = "" + op.sub(n1, n2);
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            operacoes_matematicas op = new operacoes_matematicas();
            int n1 = int.Parse(text_numero1.Text);
            int n2 = int.Parse(text_numero2.Text);
            text_resultado.Text = "" + op.div(n1, n2);
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            operacoes_matematicas op = new operacoes_matematicas();
            int n1 = int.Parse(text_numero1.Text);
            int n2 = int.Parse(text_numero2.Text);
            text_resultado.Text = "" + op.mul(n1, n2);
        }
    }
    }

