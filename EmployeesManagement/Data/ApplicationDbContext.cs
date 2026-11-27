using Microsoft.EntityFrameworkCore;
using EmployeesManagement.Models;

namespace EmployeesManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }
    pubic DbSet<Employee> Employee { get; set; }
    pubic DbSet<Employee> Departments { get; set; }
    }l
}
