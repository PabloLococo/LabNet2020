using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_1
{
   public class Calculadora
    {
        public void Dividir(int a, int b)
        {
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException ex)
            {
         
                Console.WriteLine(ex.Message);
            }           
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("El programa termino");
            }
        }
    }
}
