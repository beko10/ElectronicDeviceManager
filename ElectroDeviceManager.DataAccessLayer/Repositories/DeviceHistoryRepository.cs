using ElectronicDeviceManager.DataAccessLayer.Context;
using ElectronicDeviceManager.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.DataAccessLayer.Repositories
{
    public class DeviceHistoryRepository : GenericRepository<DeviceHistory>
    {
        public DeviceHistoryRepository(AppDbContext context) : base(context) { }
    }
}