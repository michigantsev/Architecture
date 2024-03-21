using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Xml;
using WaterTourismManager.DTO;
using WaterTourismManager.Models;

public class MyDbContext : DbContext
{
    // DbSet properties representing your entities
    public DbSet<ClientData> Clients { get; set; }
    public DbSet<PeopleSetData> PeopleSets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Use the in-memory database
        optionsBuilder.UseInMemoryDatabase("MyInMemoryDatabase");
    }
}
