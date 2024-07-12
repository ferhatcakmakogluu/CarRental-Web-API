using FluentValidation;
using NLayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validation
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            //Name
            RuleFor(x=> x.Name)
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .NotNull().WithMessage("{PropertyName} is required");

            //LastName
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .NotNull().WithMessage("{PropertyName} is required");

            //PhoneNumber
            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .NotNull().WithMessage("{PropertyName} is required")
                .Must(num => num.StartsWith("0")).WithMessage("{PropertyName} should starts with 0")
                .Must(num => num.Length == 11).WithMessage("{PropertyName} must be 11 digits long");

            //Adress
            RuleFor(x => x.Adress)
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .NotNull().WithMessage("{PropertyName} is required");

          
        }
    }
}
