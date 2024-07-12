using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class AccountController : CustomBaseController
    {
        private readonly IAccountService _accountService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public AccountController(IAccountService accountService, IMapper mapper, IUserService userService)
        {
            _accountService = accountService;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAccounts()
        {
            var accounts = await _accountService.GetAllAsync();
            var accountsDto = _mapper.Map<List<AccountDto>>(accounts);
            return CreateActionResult(CustomResponseDto<List<AccountDto>>.Success(200, accountsDto));
        }

    [ServiceFilter(typeof(NotFoundFilter<Account>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountWithId(int id)
        {
            var account = await _accountService.GetByIdAsync(id);
            var accountDto = _mapper.Map<AccountDto>(account);
            return CreateActionResult(CustomResponseDto<AccountDto>.Success(200, accountDto));
        }

    [ServiceFilter(typeof(NotFoundFilter<Account>))]
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetAccountWithUserById(int id)
        {
            var accountWithUser = await _accountService.GetAccountWithUserById(id);
            //var accountWithUserDto = _mapper.Map<AccountDto>(accountWithUser);
            return CreateActionResult(CustomResponseDto<AccountWithUserDto>.Success(200, accountWithUser));
        }

        [HttpPost]
        public async Task<IActionResult> SaveAccount(AccountDto account)
        {
            await _accountService.AddAsync(_mapper.Map<Account>(account));
            return CreateActionResult(CustomResponseDto<AccountDto>.Success(201, account));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAccount(AccountDto account)
        {
            await _accountService.UpdateAsync(_mapper.Map<Account>(account));
            return CreateActionResult(CustomResponseDto<AccountDto>.Success(204, account));
        }

    [ServiceFilter(typeof(NotFoundFilter<Account>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAccount(int id)
        {
            var account = await _accountService.GetByIdAsync(id);
            int userId = account.UserId;
            await _accountService.RemoveAsync(account);

            var user = _userService.Where(x=>x.Id == userId).FirstOrDefault();
            if (user != null)
            {
                //hesaba bagli kiside db den silinir
                await _userService.RemoveAsync(user);
            }

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
