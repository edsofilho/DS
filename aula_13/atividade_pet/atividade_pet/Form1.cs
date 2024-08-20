using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_pet
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
            text_nome.Text = "" + dataGridView1[1, i].Value;
            text_idade.Text = "" + dataGridView1[2, i].Value;
            text_cor.Text = "" + dataGridView1[3, i].Value;
            text_sexo.Text = "" + dataGridView1[4, i].Value;
            text_especie.Text = "" + dataGridView1[5, i].Value;


        }
        animal ani = new animal();
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                ani.setNome(text_nome.Text);
                ani.setEspecie(text_especie.Text);
                ani.setIdade(text_idade.Text);
                ani.setCor(text_cor.Text);
                ani.setSexo(text_sexo.Text);

                ani.inserir();
                dataGridView1.DataSource = ani.Consultar();
            }
            finally {
                MessageBox.Show("Informações gravadas com sucesso");
            }
            dataGridView1.Columns["codigo"].HeaderText = "Código";
            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["idade"].HeaderText = "Idade";
            dataGridView1.Columns["cor"].HeaderText = "Cor";
            dataGridView1.Columns["especie"].HeaderText = "Especie";
            dataGridView1.Columns["sexo"].HeaderText = "Sexo";

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ani.Consultar();

            dataGridView1.Columns["codigo"].HeaderText = "Código";
            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["idade"].HeaderText = "Idade";
            dataGridView1.Columns["cor"].HeaderText = "Cor";
            dataGridView1.Columns["especie"].HeaderText = "Especie";
            dataGridView1.Columns["sexo"].HeaderText = "Sexo";
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            ani.setCodigo(tex_codigo.Text);
            ani.excluir();
            dataGridView1.DataSource = ani.Consultar();

            dataGridView1.Columns["codigo"].HeaderText = "Código";
            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["idade"].HeaderText = "Idade";
            dataGridView1.Columns["cor"].HeaderText = "Cor";
            dataGridView1.Columns["especie"].HeaderText = "Especie";
            dataGridView1.Columns["sexo"].HeaderText = "Sexo";
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                //Adicionar
                ani.setNome(text_nome.Text);
                ani.setCodigo(tex_codigo.Text);
                ani.setEspecie(text_especie.Text);
                ani.setIdade(text_idade.Text);
                ani.setCor(text_cor.Text);
                ani.setSexo(text_sexo.Text);
                //Alterar de inserir para alterar
                ani.alterar();
                dataGridView1.DataSource = ani.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
            dataGridView1.Columns["codigo"].HeaderText = "Código";
            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["idade"].HeaderText = "Idade";
            dataGridView1.Columns["cor"].HeaderText = "Cor";
            dataGridView1.Columns["especie"].HeaderText = "Especie";
            dataGridView1.Columns["sexo"].HeaderText = "Sexo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tex_codigo.Text = "";
            text_nome.Text = "";
            text_especie.Text = "";
            text_idade.Text = "";
            text_cor.Text = "";
            text_sexo.Text = "";
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Columns["codigo"].HeaderText = "Código";
            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["idade"].HeaderText = "Idade";
            dataGridView1.Columns["cor"].HeaderText = "Cor";
            dataGridView1.Columns["especie"].HeaderText = "Especie";
            dataGridView1.Columns["sexo"].HeaderText = "Sexo";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibirRegistro(dataGridView1.CurrentRow.Index);
        }
    }
}
