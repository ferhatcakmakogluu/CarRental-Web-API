using FluentValidation;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.DTOs;
using NLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validation
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        private readonly AppDbContext _appDbContext;

        public UserDtoValidator(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

            //Name
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} boş olamaz!")
                .NotNull().WithMessage("{PropertyName} alanı doldurulmalı!");

            //LastName
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("{PropertyName} boş olamaz!")
                .NotNull().WithMessage("{PropertyName} alanı doldurulmalı!");

            //PhoneNumber
            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("{PropertyName} boş olamaz!")
                .NotNull().WithMessage("{PropertyName} alanı doldurulmalı!")
                .Must(num => num.StartsWith("0")).WithMessage("{PropertyName} 0 ile başlamalı")
                .Must(phone => CheckPhone(phone).Result == "").WithMessage("Bu telefon numarası kullanılmakta!")
                .Must(num => num.Length == 11).WithMessage("{PropertyName} en fazla 11 haneli olmalı");

            //Adress
            /*RuleFor(x => x.Adress)
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .NotNull().WithMessage("{PropertyName} is required");*/

            //Email
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("{PropertyName} boş olamaz!")
                .NotNull().WithMessage("{PropertyName} alanı doldurulmalı!")
                .Must(mail => mail.Contains("@")).WithMessage("Lütfen geçerli bir eposta adresi kullanın ('@' içermeli)")
                .Must(mail => mail.EndsWith(".com")).WithMessage("Lütfen geçerli bir eposta adresi kullanın('.com' içermeli)")
                .Must(mail => CheckEmail(mail).Result == "").WithMessage("Bu mail adresi kullanılmakta!")
                .Must(mail => mail.Length <= 125).WithMessage("Eposta adresiniz 125 karakterden fazla olamaz!");

            //Password
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("{PropertyName} boş olamaz!")
                .NotNull().WithMessage("{PropertyName} alanı doldurulmalı!")
                .Must(pass => pass.Length > 8 && pass.Length < 55).WithMessage("Şifre en az 8, en fazla 55 karakter olmalı!")
                .Matches(@"[A-Z]+").WithMessage("Şifre en az bir büyük harf içermeli!")
                .Matches(@"\d+").WithMessage("Şifre en az bir büyük küçük içermeli!")
                .Matches(@"[\W_]+").WithMessage("Şifre en az bir sembol içermeli!");

            //PasswordAgain
            RuleFor(x => x.PasswordAgain)
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .NotNull().WithMessage("{PropertyName} is required")
                .Equal(x => x.Password).WithMessage("Şifreleriniz eşleşmiyor!");
            
        }

        private Task<string> CheckEmail(string email)
        {
            bool response = _appDbContext.Users
                             .Any(user => user.Email == email);
            if (response)
            {
                return Task.FromResult(email);
            }
            return Task.FromResult("");
        }

        private Task<string> CheckPhone(string phone)
        {
            bool response = _appDbContext.Users
                             .Any(user => user.PhoneNumber == phone);
            if (response)
            {
                return Task.FromResult(phone);
            }
            return Task.FromResult("");
        }
    }
}
