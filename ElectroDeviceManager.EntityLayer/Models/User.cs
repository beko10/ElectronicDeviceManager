using ElectronicDeviceManager.EntityLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.EntityLayer.Models
{
    public class User : Entity
    {
        public string? UserName { get; set; }
        public string? RoleName { get; set; }

        /*public Employee EmployeeID
         public Employee Employee
        bire-bir ilişki
         */

        //Bire bir ilişki kuruldu
        public Guid DeviceAssignmentId { get; set; }
        public DeviceAssignment? DeviceAssignment { get; set; }
    }
}
