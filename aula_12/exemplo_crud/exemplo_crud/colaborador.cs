using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Biblioteca de conexão do SQL
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace exemplo_crud
{
    class colaborador : conexao
    {
        private string nome;
        private string sobrenome;
        private string cpf;
        private string codigo;

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public string getCodigo()
        {
            return this.codigo;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public string getSobrenome()
        {
            return this.sobrenome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return this.cpf;
        }
        //Criação do método inserir()
        public void inserir()
        {
            string query = "insert into colaborador(nome_colaborador,sobrenome_colaborador,cpf_colaborador) values('" + getNome() + "','" + getSobrenome() + "','" + getCpf() + "')";
            //Abrir conexão, enviar ao banco de dados e fechar conexão
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

        }
        public void excluir()
        {
            string query = "delete from colaborador where codigo_colaborador = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
        //Metodo para visualisar os dados
        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "Select * from colaborador";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            //Visualisar os dados partir da select
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void alterar()
        {
            string query = "update colaborador set nome_colaborador = '" + getNome() + "', sobrenome_colaborador = '" + getSobrenome() + "', cpf_colaborador = '" + getCpf() + "'where codigo_colaborador = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

    }
}


