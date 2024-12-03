using ElectronicDeviceManager.DataAccessLayer.Abstraction;
using ElectronicDeviceManager.DataAccessLayer.Context;
using ElectronicDeviceManager.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.DataAccessLayer.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>
    {
        public DepartmentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
