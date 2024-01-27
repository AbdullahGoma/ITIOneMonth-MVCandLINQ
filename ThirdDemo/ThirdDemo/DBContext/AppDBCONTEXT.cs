using Microsoft.EntityFrameworkCore;
using ThirdDemo.Models;

namespace ThirdDemo.DBContext
{
    public class AppDBCONTEXT:DbContext
    {
        public AppDBCONTEXT(DbContextOptions<AppDBCONTEXT> options) : base(options) 
        {
            // DbContextOptions => Take Data Connection
        }

        DbSet<Employee> Employees { get; set; }
    }
}
