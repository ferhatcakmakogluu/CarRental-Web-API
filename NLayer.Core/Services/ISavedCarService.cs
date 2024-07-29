using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface ISavedCarService : IService<SavedCar>
    {
        Task<List<SavedCar>> GetAllSavedCarsAsync();
        Task<List<SavedCar>> GetSavedCarWithAccountId(int accountId);
    }
}
