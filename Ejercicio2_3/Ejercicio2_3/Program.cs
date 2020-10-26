using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //while (i == 1)
            //{
            //    try
            //    {
            //      Logic logic = new Logic();                   
            //      Console.WriteLine("Te gusto el juego");
            //      Console.WriteLine(logic.Encuesta(Console.ReadLine()));


            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine("Responde con si o no");
            //        Console.WriteLine(ex);
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine("Error no previsto");
            //        Console.WriteLine(ex);
            //    }

            //    Console.ReadKey();
            //}
            int i = 1;
            Logic logic = new Logic();

            while (i ==1)
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
                catch (ArgumentException ex )
                {
                    Console.WriteLine("El producto no puede tener valor 0 o ser mayor a 50000");
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
