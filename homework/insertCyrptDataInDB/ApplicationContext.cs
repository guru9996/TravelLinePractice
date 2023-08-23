using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace homework.insertCryptDataInDB;

internal class ApplicationContext : DbContext
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
}
