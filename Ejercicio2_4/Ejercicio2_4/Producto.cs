using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_4
{
   public class Producto
    {
        #region Propiedades
        private string nombre;

        public string Nombre { get { return nombre; } }

        private int precio;

        public int Precio { get { return precio; } }
        #endregion

        public Producto(int p, string n)
        {
            precio = p;
            nombre = n;
        }

    }
}
