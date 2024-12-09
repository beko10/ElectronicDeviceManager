using ElectronicDeviceManager.EntityLayer.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.EntityLayer.Models
{
    public class Department:Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DisplayInfo => $"{Name} - {(IsActive ? "Aktif" : "Pasif")}";

        // Navigation Property
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
