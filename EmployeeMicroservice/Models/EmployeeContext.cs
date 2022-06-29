using Microsoft.EntityFrameworkCore;
using OfferMicroservice.Models;
//using System.Data.Entity;
namespace EmployeeMicroservice.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OfferData> Offers { get; set; }
        public DbSet<PointsData> Points { get; set; }
    }
}
