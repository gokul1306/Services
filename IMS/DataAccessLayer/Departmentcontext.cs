using Microsoft.EntityFrameworkCore;
using IMS.Model;
namespace IMS.DataAccessLayer
{
public class Departmentcontext : DbContext
{
    public DbSet<Department> Departments {get; set;}    
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        optionsBuilder.UseSqlServer(@"Server=ASPIREREN032;Database=InterviewManagementSystem;Trusted_Connection=True;");
    }
}
}