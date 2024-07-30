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
    public class SavedCarRepository : GenericRepository<SavedCar>, ISavedCarRepository
    {
        public SavedCarRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<SavedCar>> GetAllSavedCars()
        {
            return await _context.SavedCar.Include(x => x.Account).Include(x => x.Car).ToListAsync();
        }

        public async Task<List<SavedCar>> GetSavedCarByAccountId(int accountId)
        {
            return await _context.SavedCar.Include(x => x.Account).Where(x => x.AccountId == accountId).Include(x => x.Car).ToListAsync();
        }
    }
}
