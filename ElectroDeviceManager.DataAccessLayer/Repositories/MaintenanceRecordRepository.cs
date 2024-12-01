using ElectronicDeviceManager.DataAccessLayer.Context;
using ElectronicDeviceManager.EntityLayer.Models;

namespace ElectronicDeviceManager.DataAccessLayer.Repositories
{
    public class MaintenanceRecordRepository : GenericRepository<MaintenanceRecord>
    {
        public MaintenanceRecordRepository(AppDbContext context) : base(context)
        {
        }
    }
}
