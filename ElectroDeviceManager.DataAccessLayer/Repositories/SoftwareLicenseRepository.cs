using ElectronicDeviceManager.DataAccessLayer.Context;
using ElectronicDeviceManager.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.DataAccessLayer.Repositories
{
    public class SoftwareLicenseRepository : GenericRepository<SoftwareLicense>
    {
        public SoftwareLicenseRepository(AppDbContext context) : base(context)
        {
        }
    }
}
