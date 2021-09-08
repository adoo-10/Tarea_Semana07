using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Entidades
{
    class Producto
    {
        private double monto;
        private int dia;
       

        public double Monto { get => monto; set => monto = value; }
        public int Dia { get => dia; set => dia = value; }

        public Producto() { }

        public Producto(double monto, int dia)
        {
            this.Monto = monto;
            this.Dia = dia;
        }
    }
}
