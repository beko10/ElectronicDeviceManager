using ElectronicDeviceManager.EntityLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.BusinessLayer.Validators
{
    public class DeviceValidator : AbstractValidator<Device>
    {
        public DeviceValidator()
        {
            RuleFor(d=> d.DeviceName).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(d => d.SerialNumber).NotEmpty().WithMessage("Bu alan boş geçilemez"); 
            RuleFor(d => d.DeviceType).NotEmpty().WithMessage("Bu alan boş geçilemez"); 
            //RuleFor(d => d.DeviceAssignmentId).NotEmpty().WithMessage("Bu alan boş geçilemez"); 
            //Device tanımlarken atama yapmamıza gerek yok(?)
        }
    }
}
