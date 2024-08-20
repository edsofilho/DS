using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace atividade_pet
{
    class animal : conexao
    {
        private string nome;
        private string especie;
        private string idade;
        private string cor;
        private string sexo;
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


        public void setEspecie(string especie)
        {
            this.especie = especie;
        }
        public string getEspecie()
        {
            return this.especie;
        }

        public void setIdade(string idade)
        {
            this.idade = idade;
        }
        public string getIdade()
        {
            return this.idade;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }
        public string getCor()
        {
            return this.cor;
        }

        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }
        public string getSexo()
        {
            return this.sexo;
        }
        public void inserir()
        {
            string query = "insert into animal(nome, especie, idade, cor, sexo) values('" + getNome() + "','" + getEspecie() + "','" + getIdade() + "','" + getCor() + "','" + getSexo() + "')";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

        }

        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "Select * from animal";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void excluir()
        {
            string query = "delete from animal where codigo = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        public void alterar()
        {
            string query = "update animal set nome = '" + getNome() + "', especie = '" + getEspecie() + "', idade = '" + getIdade() + "', cor = '" +getCor()+"', sexo = '"+ getSexo() + "'where codigo = '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
    }
}

