using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_herança
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        funcionario f = new funcionario();
        private void button1_Click(object sender, EventArgs e)
        {
            //Captura das informações
            f.setNome(txt_nome.Text);
            f.setCartao(txt_cartao.Text);
            f.setRg(txt_rg.Text);

            //Demonstrar as informações
            lb_nome.Text = f.getNome();
            lb_cartao.Text = f.getCartao();
            lb_rg.Text = f.getRg();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
