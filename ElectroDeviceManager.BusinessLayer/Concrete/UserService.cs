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
    public class UserService : IManager<User>
    {
        private readonly UserRepository uRepo;
        public UserService(UserRepository userRepo)
        {

            uRepo = userRepo;
        }
        public void Create(User entity)
        {
            uRepo.Create(entity);
        }

        public void Delete(Guid Id)
        {
            var value = uRepo.GetById(Id);
            if (value != null) { 
            uRepo.Delete(Id);
            }
        }

        public IEnumerable<User> GetAll()
        {
            return uRepo.GetAll();
        }

        public User GetById(Guid Id)
        {
            return uRepo.GetById(Id);
        }

        public void Update(User entity)
        {
            if (entity != null) { 
            uRepo.Update(entity);
            }
        }
    }
}
