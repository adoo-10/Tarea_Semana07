using clasesept.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesept.Negocios
{
    class Cajero
    {
        Datos datos = new Datos();


        public string retiroDinero(double x)

        {   
            if (x % 5 == 0)
            {
                return "Estimado Cliente, si es posible retirar su dinero. ";
            }
            else
            {
                return "Lo sentimos, no es posible retirar su dinero, ingrese una cantidad disible entre 5.";

                    
            }
          
        }

    }
}
