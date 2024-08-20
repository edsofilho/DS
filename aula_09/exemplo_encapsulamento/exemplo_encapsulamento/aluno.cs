using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_encapsulamento
{
    class aluno
    {
        // criar atributo
        private string nome;
        private string cpf;
        // a cada atributo necessário criar 2 metodos (Set e Get)
        //metodo sem retorno possui a palavra void e nçao possui a palavra return
        // o nome do metodo deve ser set + o nome do atributo com a primeira palavraem maiusculo (setNome)
        // o metodo set serve para receber valores digitados pelo usuario.
        //os valores digitados pelo usuario é armazenado no parametro (string nome)  repassado ao atributo
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        /* 2º metodo:
            metodo com retorno, o tipo do metodo deve ser do mesmo tipo do atributo que ele está ligado.
            O nome do metodo deverá ser get + o nome do atributo com a 1º letra em maiusculo(getNome)
            Metodo get serve para mostrar valores ao usuario armazenado dentro so metodo set*/
        public string getNome()
        {
            return this.nome;
        }
        public string getCpf()
        {
            return this.cpf;
        }
    }
}
