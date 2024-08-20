using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        carro car = new carro();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void but_armazenar_Click(object sender, EventArgs e)
        {
            car.setModelo(tex_modelo.Text);
            car.setCor(tex_cor.Text);
            car.setAno (int.Parse(tex_ano.Text));
            car.setPortas (int.Parse(tex_portas.Text));
            car.setMarca(tex_marca.Text);
            car.setCombustivel(tex_combustivel.Text);

            lab_modelo.Text = car.getModelo();
            lab_cor.Text = car.getCor();
            lab_ano.Text = car.getAno().ToString();
            lab_portas.Text =car.getPortas().ToString();
            lab_marca.Text = car.getMarca();
            lab_combustivel.Text = car.getCombustivel();
        }
    }
}
