using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    interface IAMBC<T>
    {
        List<T> GetAll();
        T Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
