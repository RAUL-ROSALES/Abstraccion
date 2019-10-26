using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Areas : Geometricos
    {

        public override string Nombre { get; set; }
        public override int Base { get; set; }
        public override int Altura { get; set; }

        public override void Saludar()
        {
            Areas a = new Areas();
            Console.WriteLine("Area para un triangulo");
        }
    }
}
