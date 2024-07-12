using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class CarController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICarService _carService;
        private readonly ICarFeatureService _carFeatureService;

        public CarController(IMapper mapper, ICarService carService, ICarFeatureService carFeatureService)
        {
            _mapper = mapper;
            _carService = carService;
            _carFeatureService = carFeatureService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            var cars = await _carService.GetAllAsync();
            var carDto = _mapper.Map<List<CarDto>>(cars);
            return CreateActionResult(CustomResponseDto<List<CarDto>>.Success(200, carDto));
        }

    [ServiceFilter(typeof(NotFoundFilter<Car>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarWithId(int id)
        {
            var car = await _carService.GetByIdAsync(id);
            var carDto = _mapper.Map<CarDto>(car);
            return CreateActionResult(CustomResponseDto<CarDto>.Success(200, carDto));
        }

        [HttpPost]
        public async Task<IActionResult> SaveCar(CarDto carDto)
        {
            var car = await _carService.AddAsync(_mapper.Map<Car>(carDto));
            return CreateActionResult(CustomResponseDto<CarDto>.Success(201, carDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(CarDto carDto)
        {
            await _carService.UpdateAsync(_mapper.Map<Car>(carDto));
            return CreateActionResult(CustomResponseDto<CarDto>.Success(204, carDto));
        }

    [ServiceFilter(typeof(NotFoundFilter<Car>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCar(int id)
        {
            var car = await _carService.GetByIdAsync(id);
            await _carService.RemoveAsync(car);

            //Aracın ozelliklerini de silmek icin
            var carFeature = _carFeatureService.Where(x=>x.CarId == id).FirstOrDefault();
            if (carFeature != null)
            {
                await _carFeatureService.RemoveAsync(carFeature);
            }
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }


    }
}
