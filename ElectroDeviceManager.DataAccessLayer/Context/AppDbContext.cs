using ElectronicDeviceManager.DataAccessLayer.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ElectronicDeviceManager.DataAccessLayer.Context;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(DbConfiguration.GetConnectionString());
    }
}
