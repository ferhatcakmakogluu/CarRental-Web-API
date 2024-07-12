using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWork;
using NLayer.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class AccountService : Service<Account>, IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;

        public AccountService(IGenericRepository<Account> repository, IUnitOfWork unitOfWork, IMapper mapper, IAccountRepository accountRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _accountRepository = accountRepository;
        }

        public async Task<AccountWithUserDto> GetAccountWithUserById(int id)
        {
            var accountWithUser = await _accountRepository.GetAccountWithUserById(id);
            if (accountWithUser == null)
            {
                throw new NotFoundException($"Account ({id}) not found!");
            }
            var accountWithUserDto = _mapper.Map<AccountWithUserDto>(accountWithUser);
            return accountWithUserDto;
        }
    }
}
