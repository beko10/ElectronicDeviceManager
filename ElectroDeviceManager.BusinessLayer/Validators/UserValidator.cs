using ElectronicDeviceManager.EntityLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.BusinessLayer.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() { 
        RuleFor(x=> x.UserName).NotEmpty().WithMessage("Bu alan boş geçilemez");
        RuleFor(x=> x.RoleName).NotEmpty().WithMessage("Bu alan boş geçilemez");
        
        }

    }
}
