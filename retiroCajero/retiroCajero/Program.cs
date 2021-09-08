using clasesept.Entidades;
using clasesept.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un valor: ");
            double dato = Convert.ToDouble(Console.ReadLine());

            Datos datos = new Datos(dato);

            Cajero cajero = new Cajero();
            Console.WriteLine(cajero.retiroDinero(dato));
            Console.ReadLine();
        }
    }
}
