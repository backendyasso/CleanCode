using FluentValidation;
using SchoolCore.Features.Departments.Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Departments.Command.Validator
{
    public class UpdateDepartmentValidator : AbstractValidator<UpdateDepartmentCommand>
    {
        public UpdateDepartmentValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id is required");

            RuleFor(x => x.DName)
                .NotEmpty().WithMessage("Department name is required")
                .MaximumLength(100).WithMessage("Department name too long");
        }
    }
}
