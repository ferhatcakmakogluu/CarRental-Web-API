using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavedCarController : CustomBaseController
    {
        private readonly ISavedCarService _savedCarService;
        private readonly ICarService _carService;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public SavedCarController(ISavedCarService savedCarService, IMapper mapper, IAccountService accountService, ICarService carService)
        {
            _savedCarService = savedCarService;
            _mapper = mapper;
            _accountService = accountService;
            _carService = carService;
        }

        [ServiceFilter(typeof(NotFoundFilter<Account>))]
        [HttpGet]
        public async Task<IActionResult> GetAllSavedCars()
        {
            var savedCars = await _savedCarService.GetAllSavedCarsAsync();
            return CreateActionResult(CustomResponseDto<List<SavedCar>>.Success(200, savedCars));
        }

    [ServiceFilter(typeof(NotFoundFilter<Account>))]
        [HttpGet("[action]/{accountId}")]
        public async Task<IActionResult> GetSavedCarWithAccountId(int accountId)
        {
            var savedCar = await _savedCarService.GetSavedCarWithAccountId(accountId);
            return CreateActionResult(CustomResponseDto<List<SavedCar>>.Success(200, savedCar));
        }

        [HttpPost]
        public async Task<IActionResult> AddSaveCarToAccount(SavedCarDto savedCarDto)
        {
            //filter icin
            var car = await _carService.GetByIdAsync(savedCarDto.CarId);
            var account = await _accountService.GetByIdAsync(savedCarDto.AccountId);

            var savedCar = _mapper.Map<SavedCar>(savedCarDto);
            await _savedCarService.AddAsync(savedCar);
            return CreateActionResult(CustomResponseDto<SavedCar>.Success(201, savedCar));
        }

        [ServiceFilter(typeof (NotFoundFilter<SavedCar>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSavedCar(int id)
        {
            var savedCar = await _savedCarService.GetByIdAsync(id);
            await _savedCarService.RemoveAsync(savedCar);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
