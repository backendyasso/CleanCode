using FluentValidation;
using SchoolCore.Features.Students.Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Students.Command.Validator
{
    public class UpdateStudentValidator : AbstractValidator<UpdateStudentCommand>
    {
        public UpdateStudentValidator()
        {
            RuleFor(n => n.Name)
                .NotNull().WithMessage("Name must not be null")
                .NotEmpty().WithMessage("Name must not be empty")
                .MaximumLength(10).WithMessage("Name must not exceed 10 characters");

            RuleFor(n => n.Address)
                .NotNull().WithMessage("Address must not be null")
                .NotEmpty().WithMessage("Address must not be empty");
        }
    }
}
