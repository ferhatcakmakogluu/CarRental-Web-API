using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface ICarFeatureService : IService<CarFeature>
    {
        public Task<List<CarFeatureWithCarDto>> GetCarFeatureWithCar();
        public Task<CarFeatureWithCarDto> GetCarFeatureWithCarById(int id);
    }
}
