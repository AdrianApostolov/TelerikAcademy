namespace OperationWithCustomers
{
    using System;
    using System.Linq;
    using _01.CreateNorthwindDbContext;

    public class DataAccessObject
    {
        public void Add(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                db.Customers.Add(customer);
                var affectedRows = db.SaveChanges();
                Console.WriteLine("({0} row(s) affected)", affectedRows);
            }
        }

        public void Update(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                var customerToUpdate = db.Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
                customerToUpdate.Country = "Bulgaria";
                var affectedRows = db.SaveChanges();
                Console.WriteLine("({0} row(s) affected)", affectedRows);
            }
        }

        public void Delete(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                var customerToUpdate = db.Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
                db.Customers.Remove(customerToUpdate);
                var affectedRows = db.SaveChanges();
                Console.WriteLine("({0} row(s) affected)", affectedRows);
            }
        }
    }
}
