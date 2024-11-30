using ElectronicDeviceManager.EntityLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.EntityLayer.Models
{
    public class SoftwareLicense : Entity
    {
        public string? LicenseName { get; set; }
        public string? Vendor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        /*
        public Device DeviceID
        public Device Device
        bire-çok ilişki
         */
    }
}
