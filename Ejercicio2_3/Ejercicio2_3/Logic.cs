using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio2_3
{
 public   class Logic
    {
        //Habia hecho este primero pero me habia dado cuenta que no tiraba una exepcion por negocio si no por error
        //public string Encuesta (string critica )
        //{

        //        if (critica == "si" )
        //        {
        //          return "Que bien" ;
        //        }
        //        else if (critica == "no")
        //        {
        //          return "Pues andate a la mierda";
        //        }
        //        else
        //        {
        //          throw new ArgumentException();
        //        }  
        //}



        private List<Producto> productos = new List<Producto>();

        public List<Producto> Productos
        {
            get
            {
                return productos;
            }
        }


        public void IngresarProductos (string nombre, int precio)
        {
            if (precio == 0 | precio > 50000)
            {
                throw new ArgumentException();
            }
            else
            {
                Productos.Add(new Producto(precio, nombre));
            }
        }
    }
}
