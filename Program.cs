using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace BestBuyBestPractices
{
    class Program
    {
        static IConfiguration config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

        static string connString = config.GetConnectionString("DefaultConnection");

        private static IDbConnection connection;

        IDbConnection conn = new MySqlConnection(connString);

        static void Main(string[] args)
        {
            var repo = new ProductRepository(connection);

            var products = repo.GetAllProducts();

            foreach(var product in products)
            {
                Console.WriteLine($"{product.ProductID} {product.Name}");
            }
        }


    }
}
