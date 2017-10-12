using System;
using System.Collections;
using System.Data.SqlClient;

namespace RefactorKata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var products = GetProducts();
            foreach (var products in products)
            {
                Console.WriteLine ("This product is called: " + product.NAme);
            }
        }

        private static IEnumerable<Product> GetProducts()
        {
            using (var conn =new SqlConnection("Server=.;Database=myDataBase;User Id=myUsername;Password = myPassword;"))
            
            {

            }
        }
    }
}