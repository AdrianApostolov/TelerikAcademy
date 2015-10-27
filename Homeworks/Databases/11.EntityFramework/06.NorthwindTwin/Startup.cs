namespace NorthwindTwin
{
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;
    using _01.CreateNorthwindDbContext;

    public class Startup
    {
        static void Main()
        {
            IObjectContextAdapter ctx = new NorthwindEntities();
            var northwindTwin = ctx.ObjectContext.CreateDatabaseScript();

            string createNorthwindTwinCommand = "CREATE DATABASE NorthwindTwin ON PRIMARY " +
                                                "(NAME = NorthwindTwin, " +
                                                "FILENAME = 'D:\\NorthwindTwin.mdf', " +
                                                "SIZE = 5MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                                                "LOG ON (NAME = NorthwindTwinLog, " +
                                                "FILENAME = 'D:\\NorthwindTwin.ldf', " +
                                                "SIZE = 1MB, " +
                                                "MAXSIZE = 5MB, " +
                                                "FILEGROWTH = 10%)";

            SqlConnection dbConForCreatingDB = new SqlConnection("Server=LOCALHOST; " +
                                                                 "Database=master; " +
                                                                 "Integrated Security=true");

            dbConForCreatingDB.Open();

            using (dbConForCreatingDB)
            {
                SqlCommand createDB = new SqlCommand(createNorthwindTwinCommand, dbConForCreatingDB);
                createDB.ExecuteNonQuery();
            }

            SqlConnection dbConForCloning = new SqlConnection("Server=LOCALHOST; " +
                                                              "Database=NorthwindTwin; " +
                                                              "Integrated Security=true");

            dbConForCloning.Open();

            using (dbConForCloning)
            {
                SqlCommand cloneDB = new SqlCommand(northwindTwin, dbConForCloning);
                cloneDB.ExecuteNonQuery();
            }
        }
    }
}
