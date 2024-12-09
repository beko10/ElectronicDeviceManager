using ElectronicDeviceManager.BusinessLayer.Abstract;
using ElectronicDeviceManager.BusinessLayer.Validators;
using ElectronicDeviceManager.DataAccessLayer.Repositories;
using ElectronicDeviceManager.EntityLayer.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ElectronicDeviceManager.BusinessLayer.Concrete
{
    public class DepartmentService : IManager<Department>
    {
        private readonly DepartmentRepository _uRepo;

        public DepartmentService(DepartmentRepository uRepo)
        {
            _uRepo = uRepo;
        }

        public void Create(Department entity)
        {
            _uRepo.Create(entity);
        }

        public void Delete(Guid Id)
        {
            _uRepo.Delete(Id);
        }

        public IEnumerable<Department> GetAll()
        {
            return _uRepo.GetAll();
        }

        public Department GetById(Guid Id)
        {
            return _uRepo.GetById(Id);
        }

        public void Update(Department entity)
        {
            _uRepo.Update(entity);
        }
    }
}
