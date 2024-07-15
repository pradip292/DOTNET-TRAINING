using Microsoft.EntityFrameworkCore;

namespace crud.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
    }
}