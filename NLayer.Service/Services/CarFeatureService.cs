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
    public class CarFeatureService : Service<CarFeature>, ICarFeatureService
    {
        private readonly ICarFeatureRepository _carFeatureRepository;
        private readonly IMapper _mapper;

        public CarFeatureService(IGenericRepository<CarFeature> repository, IUnitOfWork unitOfWork, ICarFeatureRepository carFeatureRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _carFeatureRepository = carFeatureRepository;
            _mapper = mapper;
        }

        public async Task<List<CarFeatureWithCarDto>> GetCarFeatureWithCar()
        {
            var carFeatureWithCar = await _carFeatureRepository.GetCarFeatureWithCar();
            var carFeatureWithCarDto = _mapper.Map<List<CarFeatureWithCarDto>>(carFeatureWithCar);
            return carFeatureWithCarDto;
        }

        public async Task<CarFeatureWithCarDto> GetCarFeatureWithCarById(int id)
        {
            var carFeatureWithCar = await _carFeatureRepository.GetCarFeatureWithCarById(id);
            var carFeatureWithCarDto = _mapper.Map<CarFeatureWithCarDto>(carFeatureWithCar);
            return carFeatureWithCarDto;
        }
    }
}
