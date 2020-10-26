using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            int i = 1;
            while (i == 1)
            {
                try
                {
                    Console.WriteLine("Ingrese nombre de producto");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese precio de producto");
                    int precio = int.Parse(Console.ReadLine());
                    logic.IngresarProductos(nombre, precio);
                    Console.WriteLine("Desea ver la lista 1:SI");
                    int x = int.Parse(Console.ReadLine());
                    if (x == 1)
                    {
                        foreach (Producto producto in logic.Productos)
                        {
                            Console.WriteLine(producto.Nombre);
                            Console.WriteLine(producto.Precio);
                        }
                        x = 0;
                    }
                }
                catch (PrecioErroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Imprevisto");
                    Console.WriteLine(ex);
                }
                Console.ReadKey();
            }

        }
    }
}
