
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class RepoOperaciones
    {
        public double Convertir(double a, double b, double c = 2)
        {
            double t = (a * b) / c;
            return t;
        }
        public double Convertir(double a )
        {
            double c = a * 39.38;
            return c;
        }
    }
}
