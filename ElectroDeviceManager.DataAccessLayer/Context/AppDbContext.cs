using ElectronicDeviceManager.EntityLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Configuration;

namespace ElectronicDeviceManager.DataAccessLayer.Context;

public class AppDbContext:DbContext
{
    
    public DbSet<Device> Devices { get; set; }

    public DbSet<DeviceAssignment> DeviceAssignments { get;     set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnectionAzad"]?.ConnectionString);
    }
}
