using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioPOO_1
{
    class Automóvil : Transporte
    {
        public Automóvil(int pasajero, int numeroTransporte) : base(pasajero, numeroTransporte)
        {
          
        }

        public override string Avanzar()
        {
            return "El automovil arranco";
        }
        public override string Imprimir()
        {
            return "Automóvil " + base.NumeroTransporte.ToString()+ ": " +  base.Imprimir() + " pasajeros";
        }
    }
}
