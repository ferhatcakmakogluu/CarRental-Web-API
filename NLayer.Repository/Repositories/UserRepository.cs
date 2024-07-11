using Microsoft.EntityFrameworkCore;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<User>> GetUserWithCars()
        {
            return await _context.Users.Include(x=> x.Cars).ToListAsync();
        }

        public async Task<User> GetUserWithCarsById(int id)
        {
            return await _context.Users.Include(x => x.Cars).Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
