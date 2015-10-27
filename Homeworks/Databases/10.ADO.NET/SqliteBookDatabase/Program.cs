using System;
using System.Data.SQLite;

namespace SqliteBookDatabase
{
    public class Program
    {
        public static void Main()
        {
            SQLiteConnection.CreateFile("../../Library.sqlite");
            var connection = new SQLiteConnection("Data Source=../../Library.sqlite;Version=3;");
            CreateLibraryTable(connection);

            AddBook("Harry Pother", "J. K. Rolling", "111-111-111-11", connection);
            AddBook("Of Mice and Men", "John Steinbeck", "222-222-222-22", connection);
            Console.WriteLine();
            ListAllBooks(connection);
            Console.WriteLine();
            FindBookById(2, connection);
        }

        private static void CreateLibraryTable(SQLiteConnection connection)
        {
            string crateTableSql = "create table books (" +
                                             "id integer primary key autoincrement, " +
                                             "name nvarchar(100), " +
                                             "author nvarchar(200)," +
                                             "isbn nvarchar(20))";
            
            using (connection = new SQLiteConnection(connection))
            {
                connection.Open();
                var command = new SQLiteCommand(crateTableSql, connection);
                command.ExecuteNonQuery();
            }
        }

        private static void ListAllBooks(SQLiteConnection connection)
        {
            using (connection = new SQLiteConnection(connection))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select name, author from books", connection);
                SQLiteDataReader reader = command.ExecuteReader();

                Console.WriteLine("Books currently in library: ");
                Console.WriteLine();

                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(string.Format("- {0} -\t by {1}", reader["name"], reader["author"]));
                    }
                }
            }
        }

        private static void FindBookById(int id, SQLiteConnection connection)
        {
            using (connection = new SQLiteConnection(connection))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("select name, author from books " +
                                                          "where id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        Console.WriteLine("The book with id of " + id + " is: ");
                        Console.WriteLine(string.Format("- {0} -\t by {1}", reader["name"], reader["author"]));
                    }
                    else
                    {
                        Console.WriteLine("There is no book with id of " + id + " in the library.");
                    }
                }
            }
        }

        private static void AddBook(string name, string author, string isbn, SQLiteConnection connection)
        {
            using (connection = new SQLiteConnection(connection))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("insert into books (name, author, isbn)" +
                                                          "values (@name, @author, @isbn)", connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@isbn", isbn);
                command.ExecuteNonQuery();

                Console.WriteLine(string.Format(@"Book ""{0}"" added!", name));
            }
        }
    }
}
