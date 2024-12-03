using ElectronicDeviceManager.EntityLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.EntityLayer.Models
{
    public class DeviceAssignment : Entity
    {
        //User ile bire bir ilişki kuruldu.
        public Guid EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        
        public DateTime AssignedDate { get; set; } //teslim tarihi

      
       
         public Guid DeviceId { get; set; }
         public Device? Device { get; set; }
        
    }

}
