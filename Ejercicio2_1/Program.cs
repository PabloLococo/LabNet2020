using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine("Ingrese el valor A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor B");
            int b = int.Parse(Console.ReadLine());
            calculadora.Dividir(a, b);
            Console.ReadKey();

        }
    }
}
