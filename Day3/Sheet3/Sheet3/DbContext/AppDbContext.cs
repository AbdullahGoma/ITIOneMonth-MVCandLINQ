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
        
        DbSet<Employee> Employees { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Dependent> Dependents { get; set; }
        DbSet<Project> Projects { get; set; }
        DbSet<WorksFor> worksFors { get; set; }

    }
}
