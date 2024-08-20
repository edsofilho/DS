using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class carro : veiculo
    {
        private int portas;
        private string marca;
        private string combustivel;

        public void setPortas(int portas)
        {
            this.portas = portas;
        }
        public void setMarca(string marca)
        {
            this.marca = marca;
        }
        public void setCombustivel(string combustivel)
        {
            this.combustivel = combustivel;
        }

        public int getPortas()
        {
            return this.portas;
        }
        public string getMarca()
        {
            return this.marca;
        }
        public string getCombustivel()
        {
            return this.combustivel;
        }
    }
}
