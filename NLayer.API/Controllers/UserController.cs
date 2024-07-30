using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class UserController : CustomBaseController
    {
        private readonly IUserService _userService;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper, IAccountService accountService)
        {
            _userService = userService;
            _mapper = mapper;
            _accountService = accountService;
        }

        [ServiceFilter(typeof(NotFoundFilter<User>))]
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllAsync();
            var usersDto = _mapper.Map<List<UserDto>>(users);
            return CreateActionResult(CustomResponseDto<List<UserDto>>.Success(200, usersDto));
        }

    //istek controller icine girmeden filtrelenir
    [ServiceFilter(typeof(NotFoundFilter<User>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserWithId(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            var userDto = _mapper.Map<UserDto>(user);
            return CreateActionResult(CustomResponseDto<UserDto>.Success(200, userDto));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetUserWithCars()
        {
            var userWithCars = await _userService.GetUserWithCars();
            return CreateActionResult(CustomResponseDto<List<UserWithCarsDto>>.Success(200, userWithCars));
        }

    [ServiceFilter(typeof(NotFoundFilter<User>))]
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetUserWithCarById(int id)
        {
            var userWithCar = await _userService.GetUserWithCarsById(id);
            return CreateActionResult(CustomResponseDto<UserWithCarsDto>.Success(200, userWithCar));
        }

        [HttpPost]
        public async Task<IActionResult> SaveUser(UserDto userDto)
        {
            await _userService.AddAsync(_mapper.Map<User>(userDto));
            return CreateActionResult(CustomResponseDto<UserDto>.Success(201, userDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UserUpdateDto userUpdateDto)
        {
            await _userService.UpdateAsync(_mapper.Map<User>(userUpdateDto));

            var accounts = await _accountService.GetAllAsync();
            var usId = userUpdateDto.Id;
            var accountOfUser = accounts.FirstOrDefault(x => x.UserId == userUpdateDto.Id);

            if(accountOfUser != null)
            {
                var accountDto = _mapper.Map<AccountDto>(userUpdateDto);
                accountDto.Id = accountOfUser.Id;
                accountDto.UserId = accountOfUser.UserId;
                accountDto.AccountType = accountOfUser.AccountType;

                var account = _mapper.Map<Account>(accountDto);
                await _accountService.UpdateAsync(account);
            }

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [ServiceFilter(typeof(NotFoundFilter<User>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveUser(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            await _userService.RemoveAsync(user);

            var account = _accountService.Where(x=>x.UserId == id).FirstOrDefault();
            if (account != null)
            {
                //kisiye bagli hesapta silinir
                await _accountService.RemoveAsync(account);
            }
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
