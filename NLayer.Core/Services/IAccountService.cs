using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IAccountService : IService<Account>
    {
        Task<AccountWithUserDto> GetAccountWithUserById(int id);
        Task<AccountWithUserDto> GetAccountByUserId(int userId);
    }
}
