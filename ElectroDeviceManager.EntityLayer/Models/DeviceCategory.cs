using ElectronicDeviceManager.EntityLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.EntityLayer.Models
{
    public class DeviceCategory : Entity
    {
        public string? DeviceCategoryName { get; set; }
        public string? Description { get; set; }


        /*
         Device ile bire çok ilişki kurulacak.
        public ICollection<Device> Devices {get; set;}s

         //Device ile bire çok ilişki kurulacak.
        public ICollection<Device>? Devices {get; set;}
    }
}
