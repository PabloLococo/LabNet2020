using Ejercicio_5.Models;
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
            var employee = logic.List_London_Employees();
            List<EmployeeView> employeeViews = (from employees in employee
                                                orderby employees.LastName ascending
                                                select new EmployeeView(){
                                                    FirstName = employees.FirstName,
                                                    LastName =  employees.LastName,
                                                    Title    =  employees.Title}).ToList();                                                    
            return View(employeeViews);
        }

        public ActionResult Insert()
        {
            return  View();

        }

    }
}