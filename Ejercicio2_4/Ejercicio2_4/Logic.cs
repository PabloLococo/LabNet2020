using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_4
{
 public   class Logic
    {
        private List<Producto> productos = new List<Producto>();

        public List<Producto> Productos { get 
            {
                return productos;
            }
        }

        public void IngresarProductos(string nombre, int precio)
        {
            if (precio == 0 | precio > 50000)
            {
                throw new PrecioErroException();
            }
            else
            {
                productos.Add(new Producto(precio, nombre));
            }
        }
    }
}
