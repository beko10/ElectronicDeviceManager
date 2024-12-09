using ElectronicDeviceManager.BusinessLayer.Abstract;
using ElectronicDeviceManager.DataAccessLayer.Repositories;
using ElectronicDeviceManager.EntityLayer.Models;

namespace ElectronicDeviceManager.BusinessLayer.Concrete
{
    public class DeviceService : IManager<Device>
    {
        private readonly DeviceRepository _devRepository;
        public DeviceService(DeviceRepository devRepo)
        {
            _devRepository = devRepo;
        }
        public void Create(Device entity)
        {
            _devRepository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            _devRepository.Delete(Id);
        }

        public IEnumerable<Device> GetAll()
        {
            return _devRepository.GetAll();
        }

        public Device GetById(Guid Id)
        {
            return _devRepository.GetById(Id);
        }

        public void Update(Device entity)
        {
            _devRepository.Update(entity);
        }
    }
}
