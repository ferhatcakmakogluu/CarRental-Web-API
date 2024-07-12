using FluentValidation;
using NLayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validation
{
    public class CarDtoValidator : AbstractValidator<CarDto>
    {
        public CarDtoValidator()
        {
            //Brand
            RuleFor(x => x.Brand)
                .NotNull().WithMessage("{PropertyName} is required")
                .NotEmpty().WithMessage("{PropertyName} is not empty");
            
            //Model
            RuleFor(x => x.Model)
                .NotNull().WithMessage("{PropertyName} is required")
                .NotEmpty().WithMessage("{PropertyName} is not empty");
            
            //Price
            RuleFor(x => x.Price)
                .InclusiveBetween(1, decimal.MaxValue).WithMessage("{PropertyName} must be greater than 0");
            
            //Description
            RuleFor(x => x.Description)
                .NotNull().WithMessage("{PropertyName} is required")
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .MaximumLength(250).WithMessage("{PropertyName} can be a maximum of 250 characters");

            //Photos
            RuleFor(x => x.Photos)
                .Must(photos => photos == null || photos.Count <= 10)
                .WithMessage("You can add a maximum of 10 photos");
            
            //UserId
            RuleFor(x => x.UserId)
                .NotNull().WithMessage("{PropertyName} is required")
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .InclusiveBetween(1,int.MaxValue).WithMessage("{PropertyName} must be greater than 0");
            
        }
    }
}
