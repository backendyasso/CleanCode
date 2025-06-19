using FluentValidation;
using SchoolCore.Features.Subjects.Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCore.Features.Subjects.Command.Validator
{
    public class AddSubjectValidator : AbstractValidator<AddSubjectCommand>
    {
        public AddSubjectValidator()
        {
            RuleFor(x => x.SubjectName).NotEmpty().MaximumLength(500);
            RuleFor(x => x.Period).NotEmpty();
        }
    }
}
