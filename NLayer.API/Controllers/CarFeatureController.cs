using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class CarFeatureController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICarFeatureService _carFeatureService;
        private readonly ICarService _carService;

        public CarFeatureController(IMapper mapper, ICarFeatureService carFeatureService, ICarService carService)
        {
            _mapper = mapper;
            _carFeatureService = carFeatureService;
            _carService = carService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarFeatures()
        {
            var carFeatures = await _carFeatureService.GetAllAsync();
            var carFeaturesDto = _mapper.Map<List<CarFeatureDto>>(carFeatures);
            return CreateActionResult(CustomResponseDto<List<CarFeatureDto>>.Success(200, carFeaturesDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarFeaturesById(int id)
        {
            var carFeature = await _carFeatureService.GetByIdAsync(id);
            var carFeatureDto = _mapper.Map<CarFeatureDto>(carFeature);
            return CreateActionResult(CustomResponseDto<CarFeatureDto>.Success(200, carFeatureDto));
        }

        [HttpPost]
        public async Task<IActionResult> SaveCarFeature(CarFeatureDto carFeatureDto)
        {
            //araba var mı kontrol et
            var car = await _carService.GetByIdAsync(carFeatureDto.CarId);

            if (car == null)
            {
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404, "Car Not Found!"));
            }

            await _carFeatureService.AddAsync(_mapper.Map<CarFeature>(carFeatureDto));
            return CreateActionResult(CustomResponseDto<CarFeatureDto>.Success(200, carFeatureDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCarFeature(CarFeatureDto carFeatureDto)
        {
            await _carFeatureService.UpdateAsync(_mapper.Map<CarFeature>(carFeatureDto));
            return CreateActionResult(CustomResponseDto<CarFeatureDto>.Success(204,carFeatureDto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarFeature(int id)
        {
            var carFeature = await _carFeatureService.GetByIdAsync(id);
            await _carFeatureService.RemoveAsync(carFeature);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
