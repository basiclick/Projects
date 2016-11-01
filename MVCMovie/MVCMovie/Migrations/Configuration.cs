namespace MVCMovie.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title, new Models.Movie { Title = "When Harry Met Sally", ReleaseDate = DateTime.Parse("1989-1-11"), Genre = "Romantic Comedy", Price = 7.99M, Rating = "PG" }, new Movie { Title = "Ghostbusters", ReleaseDate = DateTime.Parse("1984-3-13"), Genre = "Comedy", Price = 8.99M, Rating = "PG" },
new Movie { Title = "Force Awakens", ReleaseDate = DateTime.Parse("2015-12-13"), Genre = "Sci-Fi", Price = 19.99M, Rating = "PG" },
new Movie
{ Title = "Avatar", ReleaseDate = DateTime.Parse("2012-09-13"), Genre = "Sci-Fi", Price = 19.99M, Rating = "PG" }, new Movie { Title = "Rio Bravo", ReleaseDate = DateTime.Parse("1959-1-11"), Genre = "Western", Price = 3.99M, Rating = "G" });
        }
    }
}
