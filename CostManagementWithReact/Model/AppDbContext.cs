using CostManagementWithReact.Model.Data;
using Microsoft.EntityFrameworkCore;

namespace CostManagementWithReact.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
