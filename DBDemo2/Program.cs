using MySql.Data.MySqlClient;
using System;
using Dapper.Contrib.Extensions; // Need to add this manually
using System.Collections.Generic;
using System.Linq;

namespace DBDemo2
{
    // Need to specify what table this matches to (otherwise Dapper assumes with an "s" at the end
    [Table("category")]
    class Category
    {
        // Need to specify which feild is the primary key
        [Key]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return $"{categoryId} {categoryName} {description}";
        }
    }

    class Program
    {
        static MySqlConnection myDB = new MySqlConnection("Server=localhost;Database=Northwind;Uid=root;Password=abc123");

        static void ReadAll()
        {
            
            List<Category> cats = myDB.GetAll<Category>().ToList();
            foreach (Category cat in cats)
            {
                Console.WriteLine(cat);
            }
        }

        static void AddOne() // "C" Create
        {
            Category cat = new Category();
            cat.categoryName = "Something else";
            cat.description = "Some stuff";
            myDB.Insert(cat);
            Console.WriteLine(cat.categoryId); // Dapper filled in our IDs for us, matching what MySQL's autoincrement created
        }

        static void ReadOneAndUpdateIt()
        {
            Category cat = myDB.Get<Category>(1);
            cat.categoryName = "Beverages";
            // UPDATE --> Saves all changes to the datadase
            myDB.Update(cat);
        }

        static void ReadOne()
        {
            Category cat = myDB.Get<Category>(1);
            Console.WriteLine(cat);
        }

        static void DeleteOne() // "D" Delete
        {
            Category cat = myDB.Get<Category>(9);
            myDB.Delete(cat);
        }

        static void Main(string[] args)
        {
            //AddOne();
            //DeleteOne();
            
        }
    }
}
