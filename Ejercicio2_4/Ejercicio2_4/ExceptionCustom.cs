using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_4
{
    class PrecioErroException : Exception
    {
        public PrecioErroException() : base("El precio del producto no puede ser 0 ni mayor a 50.000") { }
    }
}
