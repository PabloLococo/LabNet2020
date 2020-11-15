using Ejercicio_5.Models;
using Entities;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio_5.Controllers
{
    public class EmployeeController : Controller
    {

        // GET: Employee
        public ActionResult Index()
        {
            var logic = new Employees_Logic();
            List<Employees> employee = logic.List_London_Employees();
            List<EmployeeView> employeeViews = (from list_Employees in employee
                                                orderby list_Employees.LastName ascending
                                                select new EmployeeView() {
                                                    Id = list_Employees.EmployeeID,
                                                    FirstName = list_Employees.FirstName,
                                                    LastName = list_Employees.LastName,
                                                    Title = list_Employees.Title }).ToList();
            return View(employeeViews);
        }

        public ActionResult Update(EmployeeView employee)
        {        
            return View(employee);
        }

        [HttpPost]
        public ActionResult Updated(EmployeeView employee)
        {
            var logic = new Employees_Logic();
            var employeeEntity = new Employees() { FirstName = employee.FirstName, LastName = employee.LastName, Title = employee.Title , EmployeeID = employee.Id };
            logic.Update_Employee(employeeEntity);
            return RedirectToAction("Index");
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert (EmployeeView employee)
        {
            if (ModelState.IsValid)
            {
                var logic = new Employees_Logic();
                var employeeEntity = new Employees() { FirstName = employee.FirstName, LastName = employee.LastName, Title = employee.Title };
                logic.Insert_New_LondonEmployee(employeeEntity);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Insert");

        }

        [HttpPost]
        public ActionResult Delete(EmployeeView employee)
        {
            var logic = new Employees_Logic();
            var employeeEntity = new Employees() {EmployeeID = employee.Id };
            logic.Delete_Employee(employeeEntity);
            return RedirectToAction("Index");
        }

    }
}