using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            calcular calc = new calcular();
            double qua = double.Parse(txt_est.Text);
            double maxi = double.Parse(txt_max.Text);
            txt_resul.Text = "" + calc.cal(maxi, qua);
        }
    }
}
