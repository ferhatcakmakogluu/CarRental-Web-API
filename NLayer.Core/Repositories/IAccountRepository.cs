﻿using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
        Task<Account> GetAccountWithUserById(int id);
        Task<Account> GetAccountByUserId(int id);
    }

}
