using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
  public  class CustomExeptionSql: Exception
    {
        public CustomExeptionSql(string mensaje) : base("Hubo un error en base de datos " + mensaje) { }
    }
}
