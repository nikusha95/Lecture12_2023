using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Configurations;

public class GradeConfiguration : IEntityTypeConfiguration<Grade>
{
    public void Configure(EntityTypeBuilder<Grade> builder)
    {
        builder.Property(x => x.Section).HasMaxLength(200);
        
        builder.HasMany(x => x.Students)
            .WithOne(x => x.Grade)
            .HasForeignKey(x => x.GradeId);
    }
}