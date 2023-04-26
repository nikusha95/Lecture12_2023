using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Student");
        builder.Property(x => x.FirstName).HasMaxLength(100);
        builder.Property(x => x.DateOfBirth).HasDefaultValueSql("GETDATE()");
        
    }
}