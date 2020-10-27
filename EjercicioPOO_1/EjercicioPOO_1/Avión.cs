using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO_1
{
    class Avión : Transporte
    {
        public Avión(int pasajero,int numeroTransporte) : base(pasajero, numeroTransporte)
        {

        }
        public override string Avanzar()
        {
            return "El avion despego";
        }

        public override string Detenerse()
        {
            return "El avion aterrizo";
        }
        public override string Imprimir()
        {
            return "Avión " + base.NumeroTransporte.ToString() + ": " + base.Imprimir() + " pasajeros";
        }
    }
}
