using ElectronicDeviceManager.EntityLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.BusinessLayer.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator() { 
        RuleFor(e=> e.FirstName).NotEmpty().WithMessage("Bu alan boş geçilemez");
        RuleFor(e=> e.LastName).NotEmpty().WithMessage("Bu alan boş geçilemez");
        RuleForEach(e=> e.Position).NotEmpty().WithMessage("Bu alan boş geçilemez");
        
        }
    }
}
