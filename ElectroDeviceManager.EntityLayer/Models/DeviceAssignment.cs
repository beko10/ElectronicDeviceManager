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
        public Guid UserId { get; set; }
        public User? User { get; set; }
        
        public DateTime AssignedDate { get; set; } //teslim tarihi

        /*
         Device ile bire bir ilişki kurulmalı.
         public Guid DeviceId { get; set; }
         public Device? Device { get; set; }
         */
    }

}
