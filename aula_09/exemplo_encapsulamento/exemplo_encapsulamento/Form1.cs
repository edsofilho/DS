using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        aluno z = new aluno();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            z.setNome(txt_nome.Text);
            z.setCpf(txt_cpf.Text);
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            lb_nome.Text = z.getNome();
            
        }

        private void btn_Get_Click_1(object sender, EventArgs e)
        {
            lb_nome.Text = z.getNome();
            lb_cpf.Text = z.getCpf();
        }
    }
}
