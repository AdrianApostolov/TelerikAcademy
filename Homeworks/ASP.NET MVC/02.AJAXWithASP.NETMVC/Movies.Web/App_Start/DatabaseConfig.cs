namespace Movies.Web.App_Start
{
    using System.Data.Entity;

    using Movies.Data;
    using Movies.Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoviesDbContext, Configuration>());
            MoviesDbContext.Create().Database.Initialize(true);
        }
    }
}