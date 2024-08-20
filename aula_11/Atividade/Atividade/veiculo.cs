using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class veiculo
    {
        private string modelo;
        private string cor;
        private int ano;

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public void setCor(string cor)
        {
            this.cor = cor;
        }
        public void setAno(int ano)
        {
            this.ano = ano;
        }

        public string getModelo()
        {
            return this.modelo;
        }
        public string getCor()
        {
            return this.cor;
        }
        public int getAno()
        {
            return this.ano;
        }

    }
}
