using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Saludar();
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.Saludar();
            Areas area = new Areas();
            area.Saludar();

            Console.ReadKey();
        }
    }
}
