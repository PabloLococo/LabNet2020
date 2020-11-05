using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAO
{
    public class DaoCustomers : BaseDao, IAltaBajaMedia<Customers,string>
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public List<Customers> GetAll()
        {
            try
            {
                log.Info("Llame a Sql para obtener ListofCustomers");
                var listCustomers = context.Customers.ToList();
                log.Info("Obtuve ListofCustomers");
                return listCustomers;
            }
            catch (SqlException ex)
            {
                log.Info("La funcion Getall tuvo un error de SQL" + ex.Message);
                var mensaje = "";
                throw new CustomExeptionSql(mensaje);
            }

            catch (Exception ex)
            {
                log.Info("La funcion tuvo un error inesperado"+ ex.Message);
                throw ex;
            }
        }

        public Customers GetbyId(string id)
        {
            try
            {
                log.Info("Llame a Sql para obtener Customer por Id");
                var customer = context.Customers.FirstOrDefault(r => r.CustomerID.Equals(id));
                log.Info("Obtuve Customer por Id");
                return customer;
            }
            catch (SqlException ex)
            {
                log.Info("La función GetbyId tuvo un error de SQL" + ex.Message);
                string mensaje = "Por favor verifique que el ID ingresado sea valido o llame a mantenimiento si el problema persiste";
                throw new CustomExeptionSql(mensaje);
            }
            catch (Exception ex)
            {
                log.Info("La funcion tuvo un error inesperado" + ex.Message);
                throw ex;
            }
        }

        public Customers Insert(Customers entity)
        {
            try
            { 
                Customers newCustomer = context.Customers.Add(entity);
                log.Info("Llamo a Sql para actualizar Customer");
                context.SaveChanges();
                log.Info("La actulización fue exitosa");
                return newCustomer;
            }
            catch (DbUpdateException ex)
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

        public void Update(Customers entity)
        {
            try
            {
                log.Info("Llame a Sql para actualizar Customers");
                context.Entry(entity).State = EntityState.Modified;
                log.Info("La actualización fue exitosa");
                context.SaveChanges();
            }
            catch(DbUpdateException ex)
            {
                log.Info("La llamada a Sql tuvo un error en Sql" + ex.Message);
                var mensaje = "Por favor comprueve que los datos sean validos o llame a mantenimiento si el problema persiste";
                throw new CustomExeptionSql(mensaje);
            }
            catch (Exception ex)
            {
                log.Info("Error inesperado" + ex.Message);
                throw ex;
            }

        }

        public void Delete(Customers entity)
        {
            try
            {
                log.Info("Llame a Sql para borrar un Customers");
                context.Entry(entity).State = EntityState.Deleted;           
                context.SaveChanges();
                log.Info("El borrado fue exitoso");
            }
            catch (DbUpdateException ex)
            {
                log.Info("La llamada a Sql tuvo un error en Sql" + ex.Message);
                var mensaje = "Por favor comprueve que los datos existan o llame a mantenimiento si el problema persiste";
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
