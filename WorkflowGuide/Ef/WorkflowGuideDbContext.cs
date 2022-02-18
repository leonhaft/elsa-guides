using Elsa.Persistence.EntityFramework.Core;
using Elsa.Persistence.EntityFramework.SqlServer;
using Microsoft.EntityFrameworkCore;

public class WorkflowGuideDbContext : ElsaContext
{
    public WorkflowGuideDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PartNumber> PartNumbers { get; set; }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().HasData(
            new Category(1,"P-包材"),
            new Category(2,"C-结构"),
            new Category(3,"整机"),
            new Category(4,"机头"),
            new Category(5,"Capacitor"),
            new Category(6,"Inductor"),
            new Category(7,"IC"),
            new Category(8,"Resistor"),
            new Category(9,"Misc")
            );
    }
}