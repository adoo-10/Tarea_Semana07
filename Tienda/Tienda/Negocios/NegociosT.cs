using Tienda.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tienda.Negocios
{
    class NegociosT
    {
        Producto producto = new Producto();
        Producto resultado = new Producto();

        public string calcularDescuento(double monto, int dia)
        {
            if (dia == 1)
            {
                double resultado =  monto;
                Console.WriteLine("Lo sentimos, no cuenta con ningun descuento. Su monto total a pagar es de: $" +
                     monto);
                
            }
            else if (dia == 2)
            {
                double resultado = monto;
                Console.WriteLine("Lo sentimos, no cuenta con ningun descuento. Su monto total a pagar es de: $" +
                     monto);
            }
            else if (dia == 3)
            {
                double resultado = monto * 0.15 ;
                double total = monto - resultado;
                Console.WriteLine("Estimado cliente, su compra cuenta con un descuento del 15%, " +
                    "por lo que su monto a cancelar es de: $" + total);
            }
            else if (dia == 4)
            {
                double resultado = monto;
                Console.WriteLine("Lo sentimos, no cuenta con ningun descuento. Su monto total a pagar es de: $" +
                     monto);
            }
            else if (dia == 5)
            {
                double resultado = monto * 0.15;
                double total = monto - resultado;
                Console.WriteLine("Estimado cliente, su compra cuenta con un descuento del 15%, " +
                    "por lo que su monto a cancelar es de: $" + total);
            }
            else if (dia == 6)
            {
                double resultado = monto;
                Console.WriteLine("Lo sentimos, no cuenta con ningun descuento. Su monto total a pagar es de: $" +
                     monto);
            }
            else if (dia == 7)
            {
                double resultado = monto;
                Console.WriteLine("Lo sentimos, no cuenta con ningun descuento. Su monto total a pagar es de: $" +
                     monto);
            }
            if (dia > 7)
            {
                return "POR FAVOR DIGITE UN DIA VALIDO";
            }
           
            return null;
        }
    }
}
