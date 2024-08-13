using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.Models;

namespace MovieStore.Data
{
    public class MovieStoreContext : DbContext
    {
        public MovieStoreContext (DbContextOptions<MovieStoreContext> options)
            : base(options)
        {
        }

        public DbSet<MovieStore.Models.Movie> Movie { get; set; } = default!;
    }
}
