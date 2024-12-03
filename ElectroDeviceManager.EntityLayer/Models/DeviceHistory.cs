using ElectronicDeviceManager.EntityLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.EntityLayer.Models

{
    public class DeviceHistory : Entity
    {
        public int DeviceHistoryId { get; set; }
        public Guid DeviceId { get; set; }   
        public Device Device { get; set; }
        public string? DeviceName { get; set; }
        public string? Action { get; set; }
        public DateTime date{ get; set; }

    }

}