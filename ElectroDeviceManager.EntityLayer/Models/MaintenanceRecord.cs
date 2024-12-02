using ElectronicDeviceManager.EntityLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.EntityLayer.Models
{
    public class MaintenanceRecord : Entity
    {
        
        public DateTime MaintenanceDate { get; set; } //Bakım tarihi
        public string? Description { get; set; }
        public bool IsSolved { get; set; }

        /*
         Device ile düşünülmesi gereken?? bir ilişki kurulmalı.
        public int DeviceId { get; set; }
         */
    }

}
