using Microsoft.EntityFrameworkCore;
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

        public async Task<List<CarFeature>> GetCarFeatureWithCar()
        {
            return await _context.CarFeatures.Include(x=> x.Car).ToListAsync();
        }

        public async Task<CarFeature> GetCarFeatureWithCarById(int id)
        {
            return await _context.CarFeatures.Include(x => x.Car).Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
