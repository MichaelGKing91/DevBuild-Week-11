
using MySql.Data.MySqlClient;
using System;
using Dapper;
using System.Collections;

namespace DBDemo1
{
    class Category
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }

    }
    class Program
    {
        static void ReadAll()
        {
            // We need a connection object -- an instance of a collection class
            var connection = new MySqlConnection("Server=localhost;Database=Northwind;Uid=root;Password=abc123");

            // Send a SELECT statment over to mySQL.
            // We will use a string to hold the SELECT statement.
            // IEnumerable is the base interface for all the collections we've been using
            var result = connection.Query<Category>("select * from category");
            // Console.WriteLine(result);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.categoryId} {item.categoryName} {item.description}");
            }
        }

        static void AddOne()
        {
            // This will actually add data to the database
            Category cat = new Category();
            cat.categoryName = "Candy";
            cat.description = "All the sweet stuff";
            var connection = new MySqlConnection("Server=localhost;Database=Northwind;Uid=root;Password=abc123");
            // The line of code below dosent protect against SQL Injection
            //connection.Execute($"insert into category (categoryName, description) values ('{cat.categoryName}', '{cat.description}')");
            connection.Execute("insert into category (categoryName, description) values (@categoryName, @description)", cat);

        }
        static void Main(string[] args)
        {
            ReadAll();
        }
    }
}
