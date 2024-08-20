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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja mesmo sair?", "Exemplo Projeto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
