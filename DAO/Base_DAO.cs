using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{

   public abstract class Base_DAO
    {
        protected NorthWindContext context;

     public  Base_DAO ()
        {
            this.context = new NorthWindContext();
        }
    }





}

