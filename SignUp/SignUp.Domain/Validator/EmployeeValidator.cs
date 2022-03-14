using FluentValidation;
using SignUp.Domain.Entities;

namespace SignUp.Domain.Validator
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Id)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEqual(new Guid())
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MaximumLength(20)
                .NotEmpty()
                .NotNull();
            
            RuleFor(x => x.Age)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .GreaterThanOrEqualTo(18)
                .WithMessage("Employee must be 18 or older")
                .NotNull();

            RuleFor(x => x.Occupation)
                .IsInEnum()
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.EntryDate)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull();

            RuleFor(x => x.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .EmailAddress();
        }
    }
}
