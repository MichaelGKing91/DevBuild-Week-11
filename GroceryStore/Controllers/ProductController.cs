using Dapper.Contrib.Extensions;
using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Controllers
{
    public class ProductController : Controller
    {
        static MySqlConnection myDB = new MySqlConnection("Server=localhost;Database=grocerystore;Uid=root;Password=abc123");
     
        public IActionResult Index()
        {

            List<Product> allProds = myDB.GetAll<Product>().ToList();
            return View(allProds);
        }

        public IActionResult Detail(int id)
        {
            Product aProd = myDB.Get<Product>(id);
            return View(aProd);
        }

        public IActionResult EditForm(int id)
        {
            Product aProd = myDB.Get<Product>(id);
            return View(aProd);
        }
        [HttpPost]
        public IActionResult EditAction(Product aProd)
        {
            myDB.Update(aProd);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            Product aProd = myDB.Get<Product>(id);
            myDB.Delete<Product>(aProd);
            return RedirectToAction("Index");
        }

        public IActionResult AddForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product aProd)
        {
            myDB.Insert(aProd);
            return RedirectToAction("Index");
        }
    }

}
