namespace Concurrency
{
    using System;
    using System.Linq;
    using _01.CreateNorthwindDbContext;

    public class Startup
    {
        static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                using (var db2 = new NorthwindEntities())
                {
                    var employee = db.Customers.First();
                    employee.Country = "USA";
                    Console.WriteLine(employee.Country);

                    var concurrencyEmployee = db2.Customers.First();
                    concurrencyEmployee.Country = "Bulgaria";
                    Console.WriteLine(concurrencyEmployee.Country);

                    db.SaveChanges();
                    db2.SaveChanges();
                }
            }
        }
    }
}