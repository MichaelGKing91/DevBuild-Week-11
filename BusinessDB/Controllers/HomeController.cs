using BusinessDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace BusinessDB.Controllers
{
    public class HomeController : Controller
    {
        static MySqlConnection myDB = new MySqlConnection("Server=localhost;Database=business;Uid=root;Password=abc123");
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Employee> emps = myDB.GetAll<Employee>().ToList();
            List<Department> depts = myDB.GetAll<Department>().ToList();
            // Use 2 methods to pass data
            ViewBag.viewdepts = depts;
            return View(emps);
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
