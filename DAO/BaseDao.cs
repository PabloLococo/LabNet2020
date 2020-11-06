using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResourceAcceess;
namespace DAO
{
  public abstract  class  BaseDao
    {
        protected  NordwindContext context;

        public BaseDao()
        {
            this.context = new NordwindContext();
        }

        public BaseDao(NordwindContext context)
        {
            this.context = context;
        }


    }
}
