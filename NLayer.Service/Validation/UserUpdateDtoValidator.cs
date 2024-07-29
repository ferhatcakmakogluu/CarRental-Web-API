using FluentValidation;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.DTOs;
using NLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validation
{
    public class UserUpdateDtoValidator : AbstractValidator<UserUpdateDto>
    {
        private readonly AppDbContext _appDbContext;
        public UserUpdateDtoValidator(AppDbContext appDbContext)
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
            When(x => !string.IsNullOrEmpty(x.PhoneNumber), () =>
            {
                RuleFor(x => x.PhoneNumber)
                    .NotEmpty().WithMessage("{PropertyName} boş olamaz!")
                    .NotNull().WithMessage("{PropertyName} alanı doldurulmalı!")
                    .Must(num => num.StartsWith("0")).WithMessage("{PropertyName} 0 ile başlamalı")
                    .Must(phone => CheckPhone(phone).Result == "").WithMessage("Bu telefon numarası kullanılmakta!")
                    .Must(num => num.Length == 11).WithMessage("{PropertyName} en fazla 11 haneli olmalı");
            });


            //Adress
            /*When(x => !string.IsNullOrEmpty(x.Adress), () =>
            {
                RuleFor(x => x.Adress)
                .NotEmpty().WithMessage("{PropertyName} is not empty")
                .NotNull().WithMessage("{PropertyName} is required");
            });*/

            // Photo
            When(x => !string.IsNullOrEmpty(x.Photo), () =>
            {
                RuleFor(x => x.Photo)
                    .NotEmpty().WithMessage("{PropertyName} boş olamaz!")
                    .NotNull().WithMessage("{PropertyName} alanı doldurulmalı!")
                    .Must(photo=> photo.EndsWith(".jpg") || photo.EndsWith(".jpeg") || photo.EndsWith(".png"))
                    .WithMessage("Fotoğraf uzantısı .jpeg, .jpg veya .png olmalı");
            });

            // Email
            When(x => !string.IsNullOrEmpty(x.Email), () =>
            {
                RuleFor(x => x.Email)
                    .NotEmpty().WithMessage("{PropertyName} boş olamaz!")
                    .NotNull().WithMessage("{PropertyName} alanı doldurulmalı!")
                    .Must(mail => mail.Contains("@")).WithMessage("Lütfen geçerli bir eposta adresi kullanın ('@' içermeli)")
                    .Must(mail => mail.EndsWith(".com")).WithMessage("Lütfen geçerli bir eposta adresi kullanın('.com' içermeli)")
                    .Must(mail => CheckEmail(mail).Result == "").WithMessage("Bu mail adresi kullanılmakta!")
                    .Must(mail => mail.Length <= 125).WithMessage("Eposta adresiniz 125 karakterden fazla olamaz!");
            });
            /*
             .MustAsync(async (user, currentPassword, cancellation) =>
                    {
                        var passwordFromDb = await CheckCurrentPassword(user.Id);
                        return passwordFromDb == currentPassword;
                    }).WithMessage("Mevcut şifreniz hatalı!");
             */
            // Current Password
            When(x => !string.IsNullOrEmpty(x.Password), () =>
            {
                RuleFor(x => x.CurrentPassword)
                    .NotEmpty().WithMessage("Mevcut şifrenizi tuşlamalısınız")
                    .NotNull().WithMessage("Mevcut şifrenizi tuşlamalısınız")
                    .Equal(x => CheckCurrentPassword(x.Id).Result).WithMessage("Mevcut şifreniz hatalı!");

            });

            // Password
            When(x => !string.IsNullOrEmpty(x.Password), () =>
            {
                RuleFor(x => x.Password)
                    .NotEmpty().WithMessage("{PropertyName} boş olamaz!")
                    .NotNull().WithMessage("{PropertyName} alanı doldurulmalı!")
                    .Must(pass => pass.Length > 8 && pass.Length < 55).WithMessage("Şifre en az 8, en fazla 55 karakter olmalı!")
                    .Matches(@"[A-Z]+").WithMessage("Şifre en az bir büyük harf içermeli!")
                    .Matches(@"\d+").WithMessage("Şifre en az bir rakam içermeli!")
                    .Matches(@"[\W_]+").WithMessage("Şifre en az bir sembol içermeli!");
            });

            // PasswordAgain
            When(x => !string.IsNullOrEmpty(x.Password), () =>
            {
                RuleFor(x => x.PasswordAgain)
                    .NotEmpty().WithMessage("Şifre Tekrar boş olamaz!")
                    .NotNull().WithMessage("Yeni Şifre alanı doldurulmalı!")
                    .Equal(x => x.Password).WithMessage("Şifreleriniz eşleşmiyor!");
            });
        }
        private Task<string> CheckEmail(string email)
        {
            var response = _appDbContext.Users
                             .AsNoTracking()
                             .FirstOrDefault(user => user.Email == email);
            bool checkOwnEmail = false;

            if (response != null)
            {
                var userId = response?.Id;
                checkOwnEmail = _appDbContext.Accounts
                                        .AsNoTracking()
                                        .Any(x => x.Email == response.Email);
            }

            if (response != null && !checkOwnEmail)
            {
                return Task.FromResult(email);
            }
            return Task.FromResult("");
        }

        private Task<string> CheckCurrentPassword(int userId)
        {
            var account = _appDbContext.Users
                                .AsNoTracking()
                                .Where(x => x.Id == userId)
                                .FirstOrDefault();

            return Task.FromResult(account.Password);
        }

        private Task<string> CheckPhone(string phone)
        {
            var response = _appDbContext.Users
                             .AsNoTracking()
                             .Any(x=> x.PhoneNumber == phone);
            

            bool checkOwnPhone = false;

            if (response)
            {
                int userId = GetUserIdByPhoneNumber(phone);
                checkOwnPhone = _appDbContext.Accounts
                                .AsNoTracking()
                                .Any(x => x.UserId == userId);

            }

            if(response && !checkOwnPhone)
            {
                return Task.FromResult(phone);
            }
            return Task.FromResult("");
        }

        private int GetUserIdByPhoneNumber(string phone)
        {
            var user = _appDbContext.Users
                        .AsNoTracking()
                        .FirstOrDefault(x => x.PhoneNumber == phone);
            return user.Id;
        }
        
    }
}
