using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class Territories_DAO : Base_DAO, IAMBC<Territories>
    {
        public void Delete(Territories entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {

                throw ex;
            }
        }

        public List<Territories> GetAll()
        {
            try
            {
                List<Territories> listTerritories = context.Territories.ToList();
                return listTerritories;
            }
            catch (DbUpdateException ex)
            {

                throw ex;
            }
        }

        public Territories Insert(Territories entity)
        {
            try
            {
                Territories newTerritories = context.Territories.Add(entity);
                context.SaveChanges();
                return newTerritories;
            }
            catch (DbUpdateException ex)
            {

                throw ex;
            }
        }

        public void Update(Territories entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {

                throw ex;
            }

        }
    }
}
