﻿// Written By Jacob Tang


using Microsoft.AspNetCore.Mvc;
using mvc_app1.Models;
using System.Data;
using System.Diagnostics;

namespace mvc_app1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public ActionResult Employees()
        {

            // Using Visual basic CSV import function and import data into a datatable . Parse datatable into a list of employee objects.
            // MVC to render table of employee objects.

            List<EmployeeModel> employeesList = new List<EmployeeModel>();
 
            var employees = new mvc_app1.Models.Employee();
            employeesList = employees.UpdateDT(employees.updateEmployee(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/MVC_Lab/Employees.csv"));

            return View(employeesList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}