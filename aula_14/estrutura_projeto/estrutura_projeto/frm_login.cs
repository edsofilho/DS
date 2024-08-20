using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estrutura_projeto
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "123";

            if(txt_usuario.Text == usuario && txt_senha.Text == senha)
            {
              
                    frm_principal formulario = new frm_principal();
                    formulario.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválido");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Exemplo Projeto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
           
        }
    }
}
