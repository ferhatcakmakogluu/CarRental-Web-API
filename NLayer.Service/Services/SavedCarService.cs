using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class SavedCarService : Service<SavedCar>, ISavedCarService
    {
        private readonly ISavedCarRepository _savedCar;
        private readonly IMapper _mapper;
        public SavedCarService(IGenericRepository<SavedCar> repository, IUnitOfWork unitOfWork, ISavedCarRepository savedCar, IMapper mapper) : base(repository, unitOfWork)
        {
            _savedCar = savedCar;
            _mapper = mapper;
        }

        public async Task<List<SavedCar>> GetAllSavedCarsAsync()
        {
            var savedCars = await _savedCar.GetAllSavedCars();
            //var savedCarsDto = _mapper.Map<List<SavedCarDto>>(savedCars);
            return savedCars;
        }

        public async Task<List<SavedCar>> GetSavedCarWithAccountId(int accountId)
        {
            var savedCar = await _savedCar.GetSavedCarByAccountId(accountId);
            //var savedCarDto = _mapper.Map<List<SavedCarDto>>(savedCar);
            return savedCar;
        }
    }
}
