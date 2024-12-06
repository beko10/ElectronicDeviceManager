using ElectronicDeviceManager.DataAccessLayer.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ElectronicDeviceManager.DataAccessLayer.Context;

public class AppDbContext:DbContext
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<DeviceCategory> DeviceCategories { get; set; }
    public DbSet<DeviceHistory> DeviceHistories { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }
    public DbSet<SoftwareLicense> SoftwareLicenses { get; set; }
    public DbSet<User>Users  { get; set; }
    public DbSet<Device> Devices { get; set; }
    public DbSet<DeviceAssignment> DeviceAssignments { get;     set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnectionBYZT"]?.ConnectionString);
    }
}
