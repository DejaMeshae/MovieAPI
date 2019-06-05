namespace Movies.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Movies.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Movies.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Movies.AddOrUpdate(
               new Models.Movie { Title = "The Departed", Genre = "Drama", Directorname = "Martin Scorsese" },
               new Models.Movie { Title = "The Dark Knight", Genre = "Drama", Directorname = "Christopher Nolan" },
               new Models.Movie { Title = "Inception", Genre = "Drama", Directorname = "Christopher Nolan" },
               new Models.Movie { Title = "Pineapple Express", Genre = "Comedy", Directorname = "David Gordon Green" },
               new Models.Movie { Title = "Die Hard", Genre = "Action", Directorname = "John McTiernan" }
           );
        }
    }
}
