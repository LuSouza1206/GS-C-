using Microsoft.EntityFrameworkCore;
using SmartOffice.Api.Models;

namespace SmartOffice.Api.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } 
    }
}