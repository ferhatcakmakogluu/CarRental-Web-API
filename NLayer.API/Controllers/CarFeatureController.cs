using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;
using NLayer.Service.Exceptions;

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

    [ServiceFilter(typeof(NotFoundFilter<CarFeature>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarFeaturesById(int id)
        {
            var carFeature = await _carFeatureService.GetByIdAsync(id);
            var carFeatureDto = _mapper.Map<CarFeatureDto>(carFeature);
            return CreateActionResult(CustomResponseDto<CarFeatureDto>.Success(200, carFeatureDto));
        }

    [ServiceFilter(typeof(NotFoundFilter<CarFeature>))]
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCarFeatureWithCar()
        {
            var carFeatureWithCarDto = await _carFeatureService.GetCarFeatureWithCar();
            return CreateActionResult(CustomResponseDto<List<CarFeatureWithCarDto>>.Success(200, carFeatureWithCarDto));
        }

    [ServiceFilter(typeof (NotFoundFilter<CarFeature>))]
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetCarFeatureWithCarById(int id)
        {
            var carFeatureWithCarDto = await _carFeatureService.GetCarFeatureWithCarById(id);
            return CreateActionResult(CustomResponseDto<CarFeatureWithCarDto>.Success(200, carFeatureWithCarDto));
        }

        [HttpPost]
        public async Task<IActionResult> SaveCarFeature(CarFeatureDto carFeatureDto)
        {
            //araba var mı kontrol et
            //eger arac yoksa otomaitk hata fırlatır
            var car = await _carService.GetByIdAsync(carFeatureDto.CarId);

            await _carFeatureService.AddAsync(_mapper.Map<CarFeature>(carFeatureDto));
            return CreateActionResult(CustomResponseDto<CarFeatureDto>.Success(200, carFeatureDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCarFeature(CarFeatureDto carFeatureDto)
        {
            await _carFeatureService.UpdateAsync(_mapper.Map<CarFeature>(carFeatureDto));
            return CreateActionResult(CustomResponseDto<CarFeatureDto>.Success(204,carFeatureDto));
        }

    [ServiceFilter(typeof(NotFoundFilter<CarFeature>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarFeature(int id)
        {
            var carFeature = await _carFeatureService.GetByIdAsync(id);
            await _carFeatureService.RemoveAsync(carFeature);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        
        [ServiceFilter(typeof (NotFoundFilter<CarFeature>))]
        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteMergeCarFeatures(List<int> ids)
        {
            var carFeatures = await _carFeatureService.GetAllAsync();
            carFeatures = carFeatures.Where(x => ids.Contains(x.Id));

            await _carFeatureService.RemoveMergeAsync(carFeatures);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
