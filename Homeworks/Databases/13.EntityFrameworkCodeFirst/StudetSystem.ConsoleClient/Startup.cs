namespace StudetSystem.ConsoleClient
{
    using StudentSystem.Data;
    using StudentSystem.Models;

    public class Startup
    {
        static void Main()
        {
            var db = new StudentSystemDbContext();
            db.Studets.Add(new Student()
            {
                Name = "Pesho",
                Number = 1234

            });

            db.SaveChanges();
        }
    }
}
