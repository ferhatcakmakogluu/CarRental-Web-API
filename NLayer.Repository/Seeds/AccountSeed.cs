using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;
using NLayer.Core.Enums.EntityTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class AccountSeed : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            
            builder.HasData(
                new Account
                {
                    Id = 1,
                    Email = "ferhatcakmakoglu@gmail.com",
                    Password = "123456",
                    AccountCreatedDate = DateTime.UtcNow,
                    AccountType = AccountEnum.AccountTypeEnum.RENTER.ToString(),
                    UserId = 1,
                },
                new Account
                {
                    Id = 2,
                    Email = "tryit@gmail.com",
                    Password = "123456789",
                    AccountCreatedDate = DateTime.UtcNow,
                    AccountType = AccountEnum.AccountTypeEnum.RENTER.ToString(),
                    UserId = 2,
                },
                new Account
                {
                    Id = 3,
                    Email = "helloworld@gmail.com",
                    Password = "147852369",
                    AccountCreatedDate = DateTime.UtcNow,
                    AccountType = AccountEnum.AccountTypeEnum.RENTER.ToString(),
                    UserId = 3,
                },
                new Account
                {
                    Id = 4,
                    Email = "ali@gmail.com",
                    Password = "159852364",
                    AccountCreatedDate = DateTime.UtcNow,
                    AccountType = AccountEnum.AccountTypeEnum.USER.ToString(),
                    UserId = 4,
                },
                new Account
                {
                    Id = 5,
                    Email = "veli@gmail.com",
                    Password = "236547895",
                    AccountCreatedDate = DateTime.UtcNow,
                    AccountType = AccountEnum.AccountTypeEnum.USER.ToString(),
                    UserId = 5,
                }
            );
        }
    }
}
