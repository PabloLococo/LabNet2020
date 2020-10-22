using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
            
                Avión avión = new Avión(rand.Next(1, 100),i+1);
                Console.WriteLine(avión.Imprimir());
            }
            for (int i = 0; i < 5; i++)
            {
                
                Automóvil automóvil  = new Automóvil(rand.Next(1, 4),i+1);
                Console.WriteLine(automóvil.Imprimir());
            }
            Console.ReadKey();
        }
    }
}
