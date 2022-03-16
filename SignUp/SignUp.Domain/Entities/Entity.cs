using FluentValidation;
using FluentValidation.Results;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignUp.Domain.Entities
{
    public class Entity
    {
        public Guid Id { get; set; }

        [NotMapped]
        public bool IsValid { get; set; }

        [NotMapped]
        public ValidationResult ValidationResult { get; set; }

        public bool Validate<T>(T model, AbstractValidator<T> validations)
        {
            ValidationResult = validations.Validate(model);
            return this.IsValid = ValidationResult.IsValid;
        }
    }
}
