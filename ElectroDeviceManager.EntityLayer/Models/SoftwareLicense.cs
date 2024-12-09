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
        public Guid DeviceID { get; set; }
        public Device? Device { get; set; }
        public override string ToString()
        {
            return $"{DeviceID}, {LicenseName} {StartDate} - {EndDate} tarihlerine kadar lisanslandı";
        }
    }
}
