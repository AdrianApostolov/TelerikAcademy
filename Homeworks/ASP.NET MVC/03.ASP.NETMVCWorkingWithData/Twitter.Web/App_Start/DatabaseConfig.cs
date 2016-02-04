namespace Twitter.Web.App_Start
{
    using System.Data.Entity;
    using Twitter.Data.Migrations;
    using Twitter.Data;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TwitterDbContext, Configuration>());
            TwitterDbContext.Create().Database.Initialize(true);
        }
    }
}