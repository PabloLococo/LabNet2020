using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO_1
{
    public abstract class Transporte
    {
        #region Parametros

        private int pasajero;

        public int Pasajeros
        {
            get { return this.pasajero; }
        }

        private int numeroTranporte;

        public int NumeroTransporte
        {
            get { return this.numeroTranporte; }
        }
        #endregion

        #region Funciones
        #region Constructor
        public Transporte(int pasajero, int numeroTransporte)
        {
            this.pasajero = pasajero;
            this.numeroTranporte = numeroTransporte;
        }
        #endregion
        public abstract string Avanzar();
        public virtual string Detenerse()
        {
            return "El vehiculo se detuvo";
        }

        public virtual string Imprimir()
        {
            return pasajero.ToString();
        }
        #endregion


    }
}
