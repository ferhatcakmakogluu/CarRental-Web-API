﻿using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface ICarFeatureRepository : IGenericRepository<CarFeature>
    {
        Task<List<CarFeature>> GetCarFeatureWithCar();
        Task<CarFeature> GetCarFeatureWithCarById(int id);
    }
}
