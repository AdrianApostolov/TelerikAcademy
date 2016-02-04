namespace Twitter.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface ITwitterDbContext
    {

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
