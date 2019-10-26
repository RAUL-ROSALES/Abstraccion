using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Geometricos
    {
        public abstract void Saludar();
        public abstract string Nombre { get; set; }
        public abstract int Base { get; set; }
        public abstract int Altura { get; set; }
    }
}
