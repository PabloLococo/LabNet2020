using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAO
{
    public class DaoProducts : BaseDao, IAltaBajaMedia<Products,int>
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public List<Products> GetAll()
        {
            try
            {
                log.Info("Llame a Sql para obtener listOfProducts");
                var listProducts = context.Products.ToList();
                log.Info("Obtuve ListofCustomers");
                return listProducts;
            }
            catch (SqlException ex)
            {
                log.Info("La funcion Getall tuvo un error de SQL" + ex.Message);
                var mensaje = "";
                throw new CustomExeptionSql(mensaje);
            }

            catch (Exception ex)
            {
                log.Info("La funcion tuvo un error inesperado" + ex.Message);
                throw ex;
            }
        }

        public Products GetbyId(int id)
        {
            try
            {
                log.Info("Llame a Sql para obtener Customer por Id");
                var products = context.Products.FirstOrDefault(r => r.ProductID.Equals(id));
                log.Info("Obtuve Customer por Id");
                return products;
            }
            catch (SqlException ex)
            {
                log.Info("La función GetbyId tuvo un error de SQL" + ex.Message);
                var mensaje = "Por favor verifique que el ID ingresado sea valido o llame a mantenimiento si el problema persiste";
                throw new CustomExeptionSql(mensaje);
            }
            catch (Exception ex)
            {
                log.Info("La funcion tuvo un error inesperado" + ex.Message);
                throw ex;
            }
        }

        public Products Insert(Products entity)
        {
            try
            {
                log.Info("Llame a Sql para obtener un Id");
                entity.ProductID =  (from product in context.Products
                              orderby product.ProductID descending
                              select product.ProductID).FirstOrDefault() + 1;
                log.Info("Obtuve el Id de forma exitosa");
                Products newProduct = context.Products.Add(entity);
                log.Info("Llamo a Sql para actualizar Product");
                context.SaveChanges();
                log.Info("La actulización fue exitosa");
                return newProduct;
            }
            catch (SqlException ex)
            {
                log.Info("La llamada a Sql tuvo un error en Sql" + ex.Message);
                var mensaje = "Por favor vuelva a intentarlo o llame a mantenimiento si el problema persiste";
                throw new CustomExeptionSql(mensaje);
            }
            catch (Exception ex)
            {
                log.Info("Error inesperado" + ex.Message);
                throw ex;
            }

        }

        public void Update(Products entity)
        {
            try
            {
                log.Info("Llame a Sql para actualizar Products");
                context.Entry(entity).State = EntityState.Modified;              
                context.SaveChanges();
                log.Info("La actualización fue exitosa");
            }
            catch (SqlException ex)
            {
                log.Info("La llamada a Sql tuvo un error en Sql" + ex.Message);
                var mensaje = " Por favor comprueve que los datos sean validos o llame a mantenimiento si el problema persiste";
                throw new CustomExeptionSql(mensaje);
            }
            catch (Exception ex)
            {
                log.Info("Error inesperado" + ex.Message);
                throw ex;
            }

        }

        public void Delete(Products entity)
        {
            try
            {
                log.Info("Llame a Sql para borrar un Products");
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
                log.Info("El borrado fue exitoso");

            }
            catch (SqlException ex)
            {
                log.Info("La llamada a Sql tuvo un error en Sql" + ex.Message);
                var mensaje = " Por favor compruebe que los datos existan o llame a mantenimiento si el problema persiste";
                throw new CustomExeptionSql(mensaje);
            }
            catch (Exception ex)
            {
                log.Info("Error inesperado" + ex.Message);
                throw ex;
            }
        }
    }

}
