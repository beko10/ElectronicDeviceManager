using ElectronicDeviceManager.EntityLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.BusinessLayer.Validators
{
    public class MaintenanceRecordValidator : AbstractValidator<MaintenanceRecord>
    {
        public MaintenanceRecordValidator()
        {
            RuleFor(x => x.IsSolved).NotEmpty().WithMessage("Bakım kaydı boş geçilemez");
            RuleFor(x => x.MaintenanceDate).NotNull().WithMessage("Bakım tarihi boş geçilemez");
        }
    }
}
