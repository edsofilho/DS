using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_polimorfia
{
    class horista : empregado
    {
        private double precoHora;
        private double horasTrabalhadas;

        public void setPrecoHora(double precoHora)
        {
            this.precoHora = precoHora;
        }

        public double getPrecoHora()
        {
            return this.precoHora;
        }

        public void setHorasTrabalhadas (double horasTrabalhadas)
        {
            this.horasTrabalhadas = horasTrabalhadas;
        }
        public double getHorasTrabalhadas(double horasTrabalhadas) {
            return this.horasTrabalhadas;
        }

        public override Double vencimento (double valor)
        {
            valor = 1000;
            return valor;
        }
        
    }
}
