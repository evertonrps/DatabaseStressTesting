using DatabaseEF.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseEF.Mapping;


public class LeadMapping : IEntityTypeConfiguration<Lead>
{
    public void Configure(EntityTypeBuilder<Lead> builder)
    {
        builder.Property(c => c.Id).HasColumnName("id");
        builder.Property(c => c.Age).HasColumnName("age");
        builder.Property(c => c.Name).HasColumnName("name");
        builder.Property(c => c.UpdatedAt).HasColumnName("updatedat");
        builder.Property(c => c.CreatedAt).HasColumnName("createdat");
        builder.ToTable("lead");
    }
}