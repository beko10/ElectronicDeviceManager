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
    public class DeviceService : IManager<Device>
    {

        private readonly DeviceRepository _deviceRepo;
        public DeviceService(DeviceRepository deviceRepo)
        {
                _deviceRepo = deviceRepo;
        }
        public void Create(Device entity)
        {
            if (entity != null)
            {
                _deviceRepo.Create(entity);
            }
            
        }

        public void Delete(Guid Id)
        {
            var value = _deviceRepo.GetById(Id);
            if (value != null)
            {
                _deviceRepo.Delete(Id);
            }
        }

        public IEnumerable<Device> GetAll()
        {
            return _deviceRepo.GetAll();
        }

        public Device GetById(Guid Id)
        {
            return _deviceRepo.GetById(Id);
        }

        public void Update(Device entity)
        {
            if (entity != null)
            {
                _deviceRepo.Update(entity);
            }
        }
    }
}
