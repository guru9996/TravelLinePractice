using Domain;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Infrastucture;
internal class ApplicationContext : DbContext, IUnitOfWork
{
    public DbSet<cryptData> Data => Set<cryptData>();
    public ApplicationContext()
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Database=postgres;Port=5432;User Id=postgres;Password=GV9hb8jn7km6");
    }

    public void Commit()
    {
        SaveChanges();
    }
}
