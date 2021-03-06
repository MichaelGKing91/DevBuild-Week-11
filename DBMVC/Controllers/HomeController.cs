using DBMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace DBMVC.Controllers
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
            MySqlConnection myDB = new MySqlConnection("Server=localhost;Database=Northwind;Uid=root;Password=abc123");
            List<Category> cats = myDB.GetAll<Category>().ToList();
            return View(cats);
        }

        
        public IActionResult detail(int id)
        {
            MySqlConnection myDB = new MySqlConnection("Server=localhost;Database=Northwind;Uid=root;Password=abc123");
            Category cat = myDB.Get<Category>(id);
            return View(cat);
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
