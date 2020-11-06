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

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Customers AddNewCustomer(Customers customers)
        {
            try
            {
                if (customers.CustomerID == null)
                {
                    throw new ArgumentException();
                }
             return   daoCustomers.Insert(customers);
            }
            catch (ArgumentException ex)
            {
                throw ex ;
            }
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
            catch (ArgumentException ex)
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
            try
            {
            daoCustomers.Delete(customers);
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

    }
}
