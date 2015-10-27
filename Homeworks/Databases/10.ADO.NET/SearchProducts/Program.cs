using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SearchProducts
{
    public class Program
    {
        public static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
                                                    "Database=Northwind; Integrated Security=true");

            Console.Write("Search for products: ");
            var searchString = Console.ReadLine();
            Console.WriteLine();

            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmdCategories = new SqlCommand(
                    "SELECT ProductName FROM Products", dbCon);

                var products = new List<string>();
                SqlDataReader reader = cmdCategories.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string productName = (string)reader["ProductName"];
                        if (productName.Contains(searchString))
                        {
                            products.Add(productName);
                        }
                    }
                }

                Console.WriteLine(string.Format(@"Products containing '{0}'", searchString));

                foreach (var product in products)
                {
                    Console.WriteLine("- {0}", product);
                }
            }
        }
    }
}
