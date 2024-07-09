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
    public class CarService : Service<Car>, ICarService
    {
        public CarService(IGenericRepository<Car> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
