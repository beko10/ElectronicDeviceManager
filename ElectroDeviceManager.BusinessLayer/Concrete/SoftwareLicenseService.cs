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
    public class SoftwareLicenseService : IManager<SoftwareLicense>
    {
        private readonly SoftwareLicenseRepository uRepo;
        public SoftwareLicenseService(SoftwareLicenseRepository SoftwareLicenseRepo)
        {
            uRepo = SoftwareLicenseRepo;
        }
        public void Create(SoftwareLicense entity)
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

        public IEnumerable<SoftwareLicense> GetAll()
        {
            return uRepo.GetAll();
        }

        public SoftwareLicense GetById(Guid Id)
        {
            return uRepo.GetById(Id);
        }

        public void Update(SoftwareLicense entity)
        {
            if (entity != null)
            {
                uRepo.Update(entity);
            }
        }
    }
}
