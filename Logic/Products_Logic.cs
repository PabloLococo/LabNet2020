using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
   public class Products_Logic 
    {
        private DaoProducts daoProducts;



        public Products_Logic()
        {
            daoProducts = new DaoProducts();
        }

       public List<Products> ListofProducts ()
        {
            try
            {
             return daoProducts.GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

        public Products Product (int id)
        {
            try
            {
                return daoProducts.GetbyId(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void AddNewProduct(Products products)
        {
            try
            {
                daoProducts.Insert(products);
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

        public void UpdateProduct(Products products)
        {
            try
            {
                daoProducts.Update(products);
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
        public void DeleteProduct(Products products)
        {
            try
            {
                daoProducts.Delete(products);
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }
    }
}

