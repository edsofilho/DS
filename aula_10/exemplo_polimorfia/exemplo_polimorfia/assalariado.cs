﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_polimorfia
{
    class assalariado : empregado
    {
        private double salario;

        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return this.salario;
        }
        /*O método vencimento da classe assalariado e herdado da classe empregado que também possui um método de nome vencimento.
          Sendo assim necessário adicionar a palavra override(sobrepor) na frente da visibilidade*/
        public override Double vencimento (double valor)
        {
            valor = 1000;
            return valor;
        }
    }
}
