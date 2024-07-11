﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllAsync();
            var usersDto = _mapper.Map<List<UserDto>>(users);
            return CreateActionResult(CustomResponseDto<List<UserDto>>.Success(200, usersDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserWithId(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            var userDto = _mapper.Map<UserDto>(user);
            return CreateActionResult(CustomResponseDto<UserDto>.Success(200, userDto));
        }

        [HttpPost]
        public async Task<IActionResult> SaveUser(UserDto userDto)
        {
            await _userService.AddAsync(_mapper.Map<User>(userDto));
            return CreateActionResult(CustomResponseDto<UserDto>.Success(201, userDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UserDto userDto)
        {
            await _userService.UpdateAsync(_mapper.Map<User>(userDto));
            return CreateActionResult(CustomResponseDto<UserDto>.Success(204, userDto));
        }

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
