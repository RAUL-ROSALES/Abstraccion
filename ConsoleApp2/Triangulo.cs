﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public  class Triangulo : Geometricos
    {
        public override string Nombre { get; set; }
        public override int Base { get; set; }
        public override int Altura { get; set; }
        public override void Saludar()
        {
            Console.WriteLine("Bienvenido a abstraccion");
        }
    }
}