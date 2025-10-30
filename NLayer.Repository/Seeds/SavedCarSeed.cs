using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class SavedCarSeed : IEntityTypeConfiguration<SavedCar>
    {
        public void Configure(EntityTypeBuilder<SavedCar> builder)
        {
            builder.HasData(
                new SavedCar
                {
                    Id = 1,
                    AccountId = 1,
                    CarId = 4,
                    SavedTime = DateTime.UtcNow,
                },
                new SavedCar
                {
                    Id = 2,
                    AccountId = 1,
                    CarId = 5,
                    SavedTime = DateTime.UtcNow,
                },
                new SavedCar
                {
                    Id = 3,
                    AccountId = 1,
                    CarId = 6,
                    SavedTime = DateTime.UtcNow,
                }
            );
        }
    }
}
