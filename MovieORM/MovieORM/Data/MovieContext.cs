using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieORM.Data.Model;

namespace MovieORM.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("name=MovieContext") {}
        public DbSet<Movie> Movies { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Award> Awards { get; set; }
    }
}
