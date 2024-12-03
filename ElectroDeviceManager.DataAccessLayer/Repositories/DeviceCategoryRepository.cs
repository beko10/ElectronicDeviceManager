using ElectronicDeviceManager.DataAccessLayer.Context;
using ElectronicDeviceManager.EntityLayer.Models;

namespace ElectronicDeviceManager.DataAccessLayer.Repositories
{
    public class DeviceCategoryRepository : GenericRepository<DeviceCategory>
    {
        public DeviceCategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
