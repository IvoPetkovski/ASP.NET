using Homework02.Models;
using Homework02.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Homework02.Controllers
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
            Employee employee = new Employee(2, "Ivan", "Petkovski", "16 August 2021", Position.TeamLead, 65000);

            Division division = new Division(12, "ASP.NET", employee);

            var employeeDetails = new EmployeeDetails()
            {
                FullEmployeeName = employee.GetFullName(),
                Position = employee.Position,
                DateOfHire = employee.DateOfHire,
                DivisionName = division.Name
            };

            return View(employeeDetails);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
