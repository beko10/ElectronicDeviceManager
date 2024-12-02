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
    public class DeviceAssignmentService : IManager<DeviceAssignment>
    {
        private readonly DeviceAssignmentRepository uRepo;
        public DeviceAssignmentService(DeviceAssignmentRepository DeviceAssignmentRepo)
        {
            uRepo = DeviceAssignmentRepo;
        }
        public void Create(DeviceAssignment entity)
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

        public IEnumerable<DeviceAssignment> GetAll()
        {
            return uRepo.GetAll();
        }

        public DeviceAssignment GetById(Guid Id)
        {
            return uRepo.GetById(Id);
        }

        public void Update(DeviceAssignment entity)
        {
            if (entity != null)
            {
                uRepo.Update(entity);
            }
        }
    }
}
