using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesept.Entidades
{
    class Datos
    {
        private double x;

        public double X { get => x; set => x = value; }

        public Datos(double x)
        {
            this.X = x;
        }
        public Datos() { }
    }
}
