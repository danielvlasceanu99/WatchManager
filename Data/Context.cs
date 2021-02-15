using Microsoft.EntityFrameworkCore;
using Watch_manager.Models;

namespace Watch_manager.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
    }

}
