using ElectronicDeviceManager.EntityLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.BusinessLayer.Validators
{
    public class DeviceCategoryValidator : AbstractValidator<DeviceCategory>
    {
        public DeviceCategoryValidator()
        {
            RuleFor(dc => dc.DeviceCategoryName).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(dc => dc.Description).NotEmpty().WithMessage("Bu alan boş geçilemez");
        }
    }
}
