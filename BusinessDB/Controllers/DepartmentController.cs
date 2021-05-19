using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using BusinessDB.Models; // Add this manually because it doesnt show automatically



namespace BusinessDB.Controllers
{
    public class DepartmentController : Controller
    {
        static MySqlConnection myDB = new MySqlConnection("Server=localhost;Database=business;Uid=root;Password=abc123");
        public IActionResult Index()
        {
            List<Department> deps = myDB.GetAll<Department>().ToList();
            return View(deps);
        }
        public IActionResult Details(string id)
        {
            Department dep = myDB.Get<Department>(id);
            if (dep == null)
            {
                return Content("No content found.");
            }
            return View(dep);
  
        }
    }
}
