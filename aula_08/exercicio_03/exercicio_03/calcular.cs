 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_03
{
    class calcular
    {
        public double cal(double v, double ta, double t) {
            return (v + (v * (ta / 100) * t));
        }

    }
}
