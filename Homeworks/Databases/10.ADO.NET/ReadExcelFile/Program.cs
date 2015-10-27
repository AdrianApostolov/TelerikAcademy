using System;
using System.Data.OleDb;

namespace ReadExcelFile
{
    public class Program
    {
        public static void Main()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=..\..\users.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [Users$]", connection);
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader["Name"];
                        var score = reader["Score"];
                        Console.WriteLine("Name - {0}; Score - {1}", name, score);
                    }
                }
            }
        }
    }
}
