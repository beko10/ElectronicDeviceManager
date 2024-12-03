using ElectronicDeviceManager.EntityLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.BusinessLayer.Validators
{
    public class SoftwareLicenseValidator : AbstractValidator<SoftwareLicense>
    {
        public SoftwareLicenseValidator()
        {
            RuleFor(x=> x.LicenseName).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x=> x.Vendor).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x=> x.StartDate).NotEmpty().WithMessage("Bu alan boş geçilemez");
        }
    }
}
