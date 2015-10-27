namespace GetNameAndDescriptionOfAllCategories
{
    using System;
    using System.Data.SqlClient;

    public class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
                                                    "Database=Northwind; Integrated Security=true");

            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmdCategories = new SqlCommand(
                    "SELECT CategoryID, CategoryName, Description FROM Categories", dbCon);
                SqlDataReader reader = cmdCategories.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int categoryId = (int)reader["CategoryID"];
                        string categoryName = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];
                        Console.WriteLine("{0}. {1} - {2}", categoryId, categoryName, description);
                    }
                }
            }
        }
    }
}
