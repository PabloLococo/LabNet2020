using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    interface IAltaBajaMedia <T,S>
    {
        List<T> GetAll();

        T GetbyId(S id);
        T Insert(T entity);
        void Update(T entity);
    }
}
