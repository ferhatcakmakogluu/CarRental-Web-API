using FluentValidation;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validation
{
    public class CarFeatureDtoValidator : AbstractValidator<CarFeatureDto>
    {
        public CarFeatureDtoValidator()
        {
            //Color
            RuleFor(x => x.Color)
                .NotNull().WithMessage("{PropertyName} is required")
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .Must(color => color.Length <= 125).WithMessage("{PropertyName} must be maximum 125 character");

            //Km
            RuleFor(x => x.Km)
                .NotNull().WithMessage("{PropertyName} is required")
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .Must(km => !km.StartsWith("0")).WithMessage("{PropertyName} should not start with 0")
                .Matches("^[0-9]+$").WithMessage("{PropertyName} must contain only numbers 0-9");

            //FuelType
            RuleFor(x => x.FuelType)
                .NotNull().WithMessage("{PropertyName} is required")
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .Must(type => type == "DIESEL" || type == "LPG" || type == "GASOLINE" || type == "HYBRID" || type == "ELECTRIC")
                .WithMessage("{PropertyName} must be 'DIESEL' , 'LPG' , 'GASOLINE' , 'HYBRID' or 'ELECTRIC'");

            //BodyType
            RuleFor(x => x.BodyType)
                .NotNull().WithMessage("{PropertyName} is required")
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .Must(type => type == "SEDAN" || type == "COUPE" || type == "HATCHBACK" || type == "ROADSTER" || type == "CABRIO" || type == "SUV" || type == "CROSSOVER" || type == "PICKUP")
                .WithMessage("{PropertyName} must be 'SEDAN' , 'COUPE' , 'HATCHBACK' , 'ROADSTER' , 'CABRIO' , 'SUV' , 'CROSSOVER' or 'PICKUP'");


            //GearType
            RuleFor(x => x.GearType)
                .NotNull().WithMessage("{PropertyName} is required")
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .Must(type => type == "AUTOMATIC" || type == "MANUEL" || type == "SEMI_AUTOMATIC")
                .WithMessage("{PropertyName} must be 'AUTOMATIC' , 'MANUEL' or 'SEMI_AUTOMATIC'");

            //CarId
            RuleFor(x => x.CarId)
                .NotNull().WithMessage("{PropertyName} is required")
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0");

        }
    }
}
