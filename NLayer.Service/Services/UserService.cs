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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class UserService : Service<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IGenericRepository<User> repository, IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<UserWithCarsDto>> GetUserWithCars()
        {
            var userWithCars = await _userRepository.GetUserWithCars();
            if (userWithCars == null)
            {
                throw new NotFoundException("Users not found!");
            }
            var userWithCarsDto = _mapper.Map<List<UserWithCarsDto>>(userWithCars);
            return userWithCarsDto;
        }

        public async Task<UserWithCarsDto> GetUserWithCarsById(int id)
        {
            var userWithCar = await _userRepository.GetUserWithCarsById(id);
            //otomatik filtreden kontrol ediyor
            /*if (userWithCar == null)
            {
                throw new NotFoundException($"User ({id}) not found!");
            }*/
            var userWithCarDto = _mapper.Map<UserWithCarsDto>(userWithCar);
            return userWithCarDto;
        }
    }
}
