using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Logic
{
   public class Customers_Logic
    {
        private DaoCustomers daoCustomers;

        public Customers_Logic()
        {
         daoCustomers = new DaoCustomers();
        }
        public List<Customers> ListCustomers()
        {
            try
            {
                return daoCustomers.GetAll();
            }
            catch(CustomExeptionSql ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Customers Customer(string id)

        {
            try
            {
                return daoCustomers.GetbyId(id);
            }
            catch (CustomExeptionSql ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Customers AddNewCustomer(Customers customers)
        {
            try
            {
             return   daoCustomers.Insert(customers);
            }
            //catch (CustomExeptionSql )
            //{
            //    throw new ;
            //}
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdateCustomer(Customers customers)
        {
            try
            {
                daoCustomers.Update(customers);
            }
            catch (CustomExeptionSql ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteCustomer(Customers customers)
        {
            daoCustomers.Delete(customers);
        }

    }
}
