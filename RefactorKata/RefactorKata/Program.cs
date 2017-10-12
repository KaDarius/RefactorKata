using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace RefactorKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = GetProducts();

            foreach (var product in products)
            {
                Console.WriteLine("This product is called: " + product.Name);
            }

        }



        private static IEnumerable<Product> GetProducts()
        {
            using (var conn = new SqlConnection("Server=.;Database=myDataBase;User Id=myUsername;Password = myPassword;"))
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "Select * from Products";
                cmd.CommandText = "Select * from Invoices";
            }

            /*creating while loop to link my products var with my Product list, I believe to link the foreach statement? maybe*/

            var reader = cmd.ExecuteReader();
            var products = new List<Product>();

            while (reader.Read())
            {
                
            }

            /*
             * lost myself on IEnum, following along with c repo to explain what I do understand past IEnum
            var cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Products";
            /*
             * cmd.CommandText = "Select * from Invoices";
             */
           /* SqlDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
/*
            //TODO: Replace with Dapper
            while (reader.Read())
            {
                var prod = new Product();
                Product.Name = reader["Name"].ToString();
                products.Add(prod);
            }
            conn.Dispose();
            Console.WriteLine("Products Loaded!");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].name);
            }*/



        }
    }
