using BlazorAppForCipherStudio.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppForCipherStudio.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
