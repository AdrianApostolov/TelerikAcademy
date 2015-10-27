namespace GetNumberOfCategoryRows
{
    using System;
    using System.Data.SqlClient;

    public class Program
    {
        public static void Main()
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
                                                    "Database=Northwind; Integrated Security=true");

            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmdCount = new SqlCommand(
                    "SELECT COUNT(*) FROM Categories", dbCon);
                int categoryCount = (int)cmdCount.ExecuteScalar();
                Console.WriteLine("Categories count: {0} ", categoryCount);
            }
        }
    }
}
