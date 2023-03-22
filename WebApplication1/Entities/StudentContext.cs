using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Entities
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Programme> Programmes { get; set; }
    }
}
