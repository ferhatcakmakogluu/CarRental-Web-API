using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class CarFeatureRepository : GenericRepository<CarFeature>, ICarFeatureRepository
    {
        public CarFeatureRepository(AppDbContext context) : base(context)
        {
        }
    }
}
