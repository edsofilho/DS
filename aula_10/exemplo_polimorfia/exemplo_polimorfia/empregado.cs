using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_polimorfia
{
    class empregado
    {
        private string nome;
        private string sobrenome;
        private string cpf;
        public void setNome(string nome)
        {
            this.nome = nome;
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
        public string getNome()
        {
            return this.nome;
        }
        /*Classe empregado e a super classe
          Metodo virtual é um metodo que pode ser substituido por outro metodo do mesmo nome*/
        public virtual Double vencimento (double valor)
        {
            valor = 0;
            return valor;
              
        }

    }
}
