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
          return  daoProducts.GetAll();
        }

        public Products Product (int id)
        {
            return daoProducts.GetbyId(id);
        }

        public void AddNewProduct(Products products)
        {
            daoProducts.Insert(products);
        }

        public void UpdateProduct(Products products)
        {
            daoProducts.Update(products);
        }
        public void DeleteProduct(Products products)
        {
            daoProducts.Delete(products);
        }
    }
}

