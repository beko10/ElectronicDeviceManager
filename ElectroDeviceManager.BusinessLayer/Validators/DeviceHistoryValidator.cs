using ElectronicDeviceManager.EntityLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.BusinessLayer.Validators
{
    public class DeviceHistoryValidator : AbstractValidator<DeviceHistory>
    {
        public DeviceHistoryValidator()
        {
            RuleFor(x => x.Action).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.DeliveryDate).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.DeviceName).NotEmpty().WithMessage("Bu alan boş geçilemez");
        }
    }
}
