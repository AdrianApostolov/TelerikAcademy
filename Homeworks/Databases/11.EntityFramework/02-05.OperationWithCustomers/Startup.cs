namespace OperationWithCustomers
{
    using System;
    using System.Linq;
    using _01.CreateNorthwindDbContext;

    public class Startup
    {
        static void Main()
        {
            //02.Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers.
            //Write a testing class.

            var dataAccessObject = new DataAccessObject();
            var customer = new Customer()
            {
                CustomerID = "123",
                CompanyName = "Gosho LTD",
                ContactName = "Stamat",
                ContactTitle = "CEO",
                Address = "Al. Malinov 33",
                City = "Sofia",
                PostalCode = "1000",
                Country = "USA",
                Phone = "0888123456",
                Fax = "0888123456"
            };

            //dataAccessObject.Add(customer);
            //dataAccessObject.Update(customer);
            //dataAccessObject.Delete(customer);

            //03.Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
            FindCustomersByCriteriaUsingLambda();

            //04.Implement previous by using native SQL query and executing it through the DbContext.
            FindCustomersByCriteriaUsingSqlQuery();

            //05.Write a method that finds all the sales by specified region and period (start / end dates).
            FindSaleByCreteria("RJ", new DateTime(1997, 1, 1), new DateTime(1997, 12, 31));

        }

        private static void FindSaleByCreteria(string region, DateTime startData, DateTime endDate)
        {
            using (var db = new NorthwindEntities())
            {
                var filteredOrders = db.Orders
                    .Where(o => o.ShipRegion == region && o.OrderDate > startData && o.OrderDate < endDate)
                    .ToList();


                Console.WriteLine("All orders by region and data");
                foreach (var order in filteredOrders)
                {
                    Console.WriteLine(order.OrderID);
                }
            }
        }

        private static void FindCustomersByCriteriaUsingSqlQuery()
        {
            using (var db = new NorthwindEntities())
            {
                var query = String.Format("SELECT * FROM Customers, Orders " +
                               "WHERE Customers.CustomerID=Orders.CustomerID " +
                               "AND YEAR(Orders.ShippedDate) = {0} " +
                               "AND Orders.ShipCountry = '{1}'", 1997, "Canada");

                var filteredCustomers = db.Database.SqlQuery<Customer>(query).ToList();


                Console.WriteLine("Company names covered the criteria:");
                foreach (var customer in filteredCustomers)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }


        }

        private static void FindCustomersByCriteriaUsingLambda()
        {
            using (var db = new NorthwindEntities())
            {
                var filteredCustmers = db.Orders
                    .Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCity == "Canada")
                    .Select(c => c.Customer)
                    .ToList();

                Console.WriteLine(filteredCustmers.Count);
                Console.WriteLine("Company names covered the criteria:");
                foreach (var customer in filteredCustmers)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
        }
    }
}
