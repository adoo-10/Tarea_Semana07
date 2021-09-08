using Tienda.Entidades;
using Tienda.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO A TIENDAS DON PEPE");
            Console.WriteLine("Estimado cliente, por favor digite el monto de su compra para evaluar su pago. " );
            double monto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Seleccione el codigo correspondiente al dia de ahora. " +
                "\n1 - Domingo" +
                "\n2 - Lunes" +
                "\n3 - Martes" +
                "\n4 - Miercoles" +
                "\n5 - Jueves" +
                "\n6 - Viernes" +
                "\n7 - Sabado");
            int dia = Convert.ToInt32(Console.ReadLine());

            Producto producto = new Producto(monto, dia);
            NegociosT negocios = new NegociosT();
            Console.WriteLine(negocios.calcularDescuento(monto, dia));
            Console.ReadLine();
           


        }
    }
}
