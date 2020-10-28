using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_4
{
    class PrecioErroException : Exception
    {
    
            public PrecioErroException(string mensaje) : base("Precio del producto erroneo " + mensaje) { }
    }
}
