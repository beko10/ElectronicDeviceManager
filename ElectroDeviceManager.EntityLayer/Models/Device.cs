using ElectronicDeviceManager.EntityLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.EntityLayer.Models

{
    public class Device : Entity
    {

        public string? DeviceName { get; set; }
        public string? SerialNumber { get; set; }
        public string? DeviceDescription { get; set; }
        public string? DeviceType { get; set; }
        public Guid SoftwareLicenseId { get; set; }
        public SoftwareLicense? softwareLicense  { get; set; }
        public Guid DeviceAssignmentId { get; set; }
        public DeviceAssignment? deviceAssignment { get; set; }
    
    }


}