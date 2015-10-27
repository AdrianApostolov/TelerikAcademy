namespace InheritingEmployeeClass
{
    using System;
    using System.Data.Linq;
    using System.Linq;
    using _01.CreateNorthwindDbContext;


    public class Startup
    {
        public static void Main()
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var employee = northwindEntities.Employees.First();

                // New model is in 01.CreateNorthwindDbContext with name EmmployeeExtendet
                EntitySet<Territory> territories = employee.TerritoriesSet;

                Console.WriteLine("All territories for employee {0} are:", employee.FirstName);

                foreach (var territory in territories)
                {
                    Console.WriteLine(territory.TerritoryDescription);
                }
            }
        }
    }
}
