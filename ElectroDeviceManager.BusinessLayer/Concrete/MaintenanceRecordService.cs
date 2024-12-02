using ElectronicDeviceManager.BusinessLayer.Abstract;
using ElectronicDeviceManager.DataAccessLayer.Repositories;
using ElectronicDeviceManager.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.BusinessLayer.Concrete
{
    public class MaintenanceRecordService : IManager<MaintenanceRecord>
    {
        private readonly MaintenanceRecordRepository uRepo;
        public MaintenanceRecordService(MaintenanceRecordRepository MaintenanceRecordRepo)
        {
            uRepo = MaintenanceRecordRepo;
        }
        public void Create(MaintenanceRecord entity)
        {
            uRepo.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var value = uRepo.GetById(Id);
            if (value != null)
            {
                uRepo.Delete(Id);
            }
        }

        public IEnumerable<MaintenanceRecord> GetAll()
        {
            return uRepo.GetAll();
        }

        public MaintenanceRecord GetById(Guid Id)
        {
            return uRepo.GetById(Id);
        }

        public void Update(MaintenanceRecord entity)
        {
            if (entity != null)
            {
                uRepo.Update(entity);
            }
        }
    }
}
