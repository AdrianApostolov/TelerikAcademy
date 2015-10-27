using System;
using System.Data.OleDb;

namespace AppendRowsToExcelFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                                      @"Data Source=..\..\users.xlsx; Extended Properties='Excel 12.0 Xml;HDR=YES;'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                for (int i = 0; i < 10; i++)
                {
                    var command = new OleDbCommand(@"INSERT INTO [Users$] Values(@name, @score)", connection);
                
                    command.Parameters.AddWithValue("@name", "User" + i);
                    command.Parameters.AddWithValue("@score", 100 + (10 * i) + (i % 10));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
