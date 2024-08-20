using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void exibirRegistro(int i)
        {
            tex_codigo.Text = "" + dataGridView1[0, i].Value;
            tex_cpf.Text = "" + dataGridView1[3, i].Value;
            tex_nome.Text = "" + dataGridView1[1, i].Value;
            tex_sobrenome.Text = "" + dataGridView1[2, i].Value;


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        colaborador c = new colaborador();
        private void but_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCpf(tex_cpf.Text);
                c.setNome(tex_nome.Text);
                c.setSobrenome(tex_sobrenome.Text);
                //Chamar o metodo inserir
                c.inserir();
                dataGridView1.DataSource = c.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
            dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
            dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
            dataGridView1.Columns["codigo_colaborador"].HeaderText = "Codigo";
            dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.Consultar();

            dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
            dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
            dataGridView1.Columns["codigo_colaborador"].HeaderText = "Codigo";
            dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCodigo(tex_codigo.Text);
                c.excluir();
                dataGridView1.DataSource = c.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações excluidas com sucesso");
            }
            dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
            dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
            dataGridView1.Columns["codigo_colaborador"].HeaderText = "Codigo";
            dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                //Adicionar
                c.setCodigo(tex_codigo.Text);
                c.setCpf(tex_cpf.Text);
                c.setNome(tex_nome.Text);
                c.setSobrenome(tex_sobrenome.Text);
                //Alterar de inserir para alterar
                c.alterar();
                dataGridView1.DataSource = c.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
            dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
            dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
            dataGridView1.Columns["codigo_colaborador"].HeaderText = "Codigo";
            dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tex_codigo.Text = "";
            tex_cpf.Text = "";
            tex_sobrenome.Text = "";
            tex_nome.Text = "";
            dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
            dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
            dataGridView1.Columns["codigo_colaborador"].HeaderText = "Codigo";
            dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibirRegistro(dataGridView1.CurrentRow.Index);
        }
    }
}

