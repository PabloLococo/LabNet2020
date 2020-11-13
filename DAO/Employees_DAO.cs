using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data_Access;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DAO
{
    public class Employees_DAO : Base_DAO, IAMBC<Employees>
    {
        public void Delete(Employees entity)
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

        public List<Employees> GetAll()
        {
            try
            {
                List<Employees> listEmployees = context.Employees.ToList();
                return listEmployees;
            }
            catch (DbUpdateException ex)
            {

                throw ex;
            }
        }

        public Employees Insert(Employees entity)
        {
            try
            {
                Employees newEmployees = context.Employees.Add(entity);
                context.SaveChanges();
                return newEmployees;
            }
            catch (DbUpdateException ex)
            {

                throw ex;
            }
        }

        public void Update(Employees entity)
        {
            try
            {
                Employees employees = context.Employees.FirstOrDefault(r => r.EmployeeID.Equals(entity.EmployeeID));
                employees.FirstName = entity.FirstName;
                employees.LastName = entity.LastName;
                employees.Title = entity.Title;


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
