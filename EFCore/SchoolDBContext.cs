using EFCore.Configurations;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore;

public class SchoolDBContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=School; User Id=sa; Password=Aa123456");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Student>()
        //     .Property(x => x.FirstName).IsRequired().HasMaxLength(400);
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentConfiguration).Assembly);

    }
}