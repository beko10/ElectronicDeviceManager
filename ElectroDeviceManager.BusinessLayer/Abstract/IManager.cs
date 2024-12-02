using ElectronicDeviceManager.EntityLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.BusinessLayer.Abstract
{
    public interface IManager<T> where T : Entity
    {
        void Create(T entity);
        void Delete(Guid Id);
        void Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(Guid Id);
    }
}
