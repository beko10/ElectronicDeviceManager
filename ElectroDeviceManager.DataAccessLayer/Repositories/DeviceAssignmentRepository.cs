using ElectronicDeviceManager.DataAccessLayer.Context;
using ElectronicDeviceManager.EntityLayer.Models;

namespace ElectronicDeviceManager.DataAccessLayer.Repositories
{
    public class DeviceAssignmentRepository : GenericRepository<DeviceAssignment>
    {
        public DeviceAssignmentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
