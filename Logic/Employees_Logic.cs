using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
  public  class Employees_Logic
    {
         private Employees_DAO employees_DAO;

         public  Employees_Logic ()
        {
            employees_DAO = new Employees_DAO();
        }

        public Employees Insert_New_LondonEmployee( Employees employees)
        {
            
            employees.HireDate = DateTime.Now;
            employees.City = "London";
            employees.Country = "UK";
            return employees_DAO.Insert(employees);
        }

        public List<Employees> List_London_Employees ()
        {
            try
            {
                List<Employees> list_London_Employees =  employees_DAO.GetAll().Where(r => r.City.Equals("London")).ToList();
                return list_London_Employees;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Delete_Employee(Employees employees)
        {
            employees_DAO.Delete(employees);
        }

        public void Update_Employee(Employees employees)
        {
             employees_DAO.Update(employees);
        }


    }
}
