using Microsoft.EntityFrameworkCore;
using Sheet3.Models;

namespace ThirdDemo.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // DbContextOptions => Take Data Connection
        }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        //public DbSet<Dependent> Dependents { get; set; }
        //public DbSet<Project> Projects { get; set; }
        //public DbSet<WorksFor> worksFors { get; set; }

    }
}
