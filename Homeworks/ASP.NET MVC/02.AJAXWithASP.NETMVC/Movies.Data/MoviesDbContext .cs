using Movies.Models;

namespace Movies.Data
{
    using System.Data.Entity;

    public class MoviesDbContext : DbContext, IMoviesDbContext
    {
        public MoviesDbContext()
            : base("DefaultConnection")
        {
        }

        public virtual IDbSet<Actor> Stories { get; set; }

        public virtual IDbSet<Movie> Donations { get; set; }

        public static MoviesDbContext Create()
        {
            return new MoviesDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasRequired(c => c.LeadingMaleRole)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .HasRequired(c => c.LeadingFemaleRole)
                .WithMany()
                .WillCascadeOnDelete(false);
        }
    }
}
