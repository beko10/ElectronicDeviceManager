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
    public class EmployeeService : IManager<Employee>
    {
        private readonly EmployeeRepository _uRepo;

        public EmployeeService(EmployeeRepository uRepo)
        {
            _uRepo = uRepo;
        }

        public void Create(Employee entity)
        {
            _uRepo.Create(entity);
        }

        public void Delete(Guid Id)
        {
            _uRepo.Delete(Id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _uRepo.GetAll();
        }

        public Employee GetById(Guid Id)
        {
            return _uRepo.GetById(Id);
        }

        public void Update(Employee entity)
        {
            _uRepo.Update(entity);
        }
    }
}
