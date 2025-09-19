using Demo.Data_Acess_Layer.Data.Configrations;
using Demo.Data_Acess_Layer.Models;
using Demo.Data_Acess_Layer.Models.Department;
using Demo.Data_Acess_Layer.Models.Employee;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Demo.Data_Acess_Layer.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employees> Employeess { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
