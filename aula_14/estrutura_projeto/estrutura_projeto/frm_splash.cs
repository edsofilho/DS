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
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                timer1.Stop();

                Form formulario = new frm_login();
                formulario.Show();
                this.Hide();
            }
        }
    }
}
