using Microsoft.EntityFrameworkCore;
using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        public AccountRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Account> GetAccountByUserId(int id)
        {
            return await _context.Accounts.Include(x=> x.User).Where(x=> x.UserId == id).FirstOrDefaultAsync();
        }

        public async Task<Account> GetAccountWithUserById(int id)
        {
            return await _context.Accounts.Include(x => x.User).Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
