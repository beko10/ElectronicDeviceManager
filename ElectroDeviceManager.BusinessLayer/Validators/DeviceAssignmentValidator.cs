using ElectronicDeviceManager.EntityLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.BusinessLayer.Validators
{
    public class DeviceAssignmentValidator : AbstractValidator<DeviceAssignment>
    {
        public DeviceAssignmentValidator()
        {
            RuleFor(da => da.AssignedDate).NotEmpty().WithMessage("Teslim Tarihi Boş Geçilemez");
            RuleFor(da => da.EmployeeId).NotEmpty().WithMessage("Bu alan boş geçilemez");
        }
    }
}
