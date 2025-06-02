using FluentValidation;
using SchoolCore.Features.Students.Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Students.Command.Validator
{
    public class AddStudentValidator : AbstractValidator<AddStudentCommand>
    {
        public AddStudentValidator()
        {
            ApplyValidationRule();
            ApplyCustomValidationRule();
        }

        public void ApplyValidationRule()
        {
            RuleFor(n => n.Name).NotNull().WithMessage("Name Mustn't be Null")
                .NotEmpty().WithMessage("Name Mustn't be empty")
                .MaximumLength(10);

            RuleFor(n => n.Address).NotNull().WithMessage("{PropertyValue} Mustn't be Null")
               .NotEmpty().WithMessage("Address Mustn't be empty")
               .MaximumLength(10);
        }


        public void ApplyCustomValidationRule()
        {

        }
    }
}
