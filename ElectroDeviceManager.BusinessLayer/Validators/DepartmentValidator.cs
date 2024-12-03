using ElectronicDeviceManager.EntityLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceManager.BusinessLayer.Validators
{
    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(d => d.Name).NotEmpty().WithMessage("Departman Adı Boş Geçilemez");
            RuleFor(d => d.Description).NotEmpty().WithMessage("Açıklama Kısımı Boş Geçilemez");

        }
    }
}
