using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_04
{
    class Contas
    {
        public double pago(double  p, double v)
        {
            return (v * p);
        }
        public double restante(double p, double v, double t)
        {
            return ((t - p) * v);
        }
    }
}
