using FluentValidation;
using NLayer.Core.DTOs;
using NLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validation
{
    public class AccountDtoValidator : AbstractValidator<AccountDto>
    {
        private readonly AppDbContext _appDbContext;

        public AccountDtoValidator(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;


            //Email
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .NotNull().WithMessage("{PropertyName} is required")
                .Must(mail => mail.Contains("@")).WithMessage("Please enter valid {PropertyName} (use '@')")
                .Must(mail => mail.EndsWith(".com")).WithMessage("Please enter valid {PropertyName} (use '.com')")
                .Must(mail => mail.Length <= 125).WithMessage("Your {PropertyName} cannot exceed 125 characters");

            //Password
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .NotNull().WithMessage("{PropertyName} is required")
                .Must(pass => pass.Length > 8).WithMessage("Your {PropertyName} must be at least 8 characters")
                .Must(pass => pass.Length < 55).WithMessage("Your {PropertyName} can be a maximum of 55 characters")
                .Matches(@"[A-Z]+").WithMessage("Your {PropertyName} must contain at least one uppercase letter")
                .Matches(@"\d+").WithMessage("Your {PropertyName} must contain at least one lowercase letter")
                .Matches(@"[\W_]+").WithMessage("Your {PropertyName} must contain at least one symbol");

            //AccountType
            RuleFor(x => x.AccountType)
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .NotNull().WithMessage("{PropertyName} is required")
                .Must(type => type == "SUPER_ADMIN" || type == "ADMIN" || type == "RENTER" || type == "USER")
                .WithMessage("{PropertyName} must be 'SUPER_ADMIN' , 'ADMIN' , 'RENTER' or 'USER'");

            //UserId
            RuleFor(x => x.UserId)
                .NotNull().WithMessage("{PropertyName} is required")
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0");

        }
    }
}
