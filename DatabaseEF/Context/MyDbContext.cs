using DatabaseEF.Entitites;
using DatabaseEF.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DatabaseEF.Context;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    public DbSet<Lead> Leads { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new LeadMapping());
    }
}