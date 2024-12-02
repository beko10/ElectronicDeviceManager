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
    public class DeviceCategoryService : IManager<DeviceCategory>
    {
        private readonly DeviceCategoryRepository uRepo;
        public DeviceCategoryService(DeviceCategoryRepository DeviceCategoryRepo)
        {
            uRepo = DeviceCategoryRepo;
        }
        public void Create(DeviceCategory entity)
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

        public IEnumerable<DeviceCategory> GetAll()
        {
            return uRepo.GetAll();
        }

        public DeviceCategory GetById(Guid Id)
        {
            return uRepo.GetById(Id);
        }

        public void Update(DeviceCategory entity)
        {
            if (entity != null)
            {
                uRepo.Update(entity);
            }
        }
    }
}
