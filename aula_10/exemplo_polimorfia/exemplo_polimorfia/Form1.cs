using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_polimorfia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //instanciamento do objeto imcompleto
        empregado objeto = null;
        empregado em = new empregado();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (rad_btn_assalariado.Checked)
            {
                objeto = new assalariado();
                double t;
                t = 0;
                lab_vencimento.Text = objeto.vencimento(t).ToString();
            }
            else if (rad_btn_comissionado.Checked)
            {
                objeto = new comissionado();
                double t;
                t = 0;
                lab_vencimento.Text = objeto.vencimento(t).ToString();
            }
            else if (rad_btn_horista.Checked)
            {
                objeto = new horista();
                double t;
                t = 0;
                lab_vencimento.Text = objeto.vencimento(t).ToString();
            }

            em.setNome(txt_nome.Text);
            em.setSobrenome(txt_sobrenome.Text);
            em.setCpf(txt_cpf.Text);

            lab_nome.Text = em.getNome();
            lab_cpf.Text = em.getCpf();
            lab_sobrenome.Text = em.getSobrenome();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
