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
    public class CarSeed : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(
                new Car
                {
                    Id = 1,
                    UserId = 1,
                    Brand = "BMW",
                    Model = "iX",
                    Price = 2300,
                    Location = "Türkiye",
                    State = "İstanbul",
                    Description = "Hızlı bir araba",
                    CreatedDate = DateTime.UtcNow
                },
                new Car
                {
                    Id = 2,
                    UserId = 1,
                    Brand = "Volvo",
                    Model = "XC90",
                    Price = 1950,
                    Location = "Türkiye",
                    State = "Ankara",
                    Description = "Yol tutuşu harika bir araba",
                    CreatedDate = DateTime.UtcNow
                },
                new Car
                {
                    Id = 3,
                    UserId = 2,
                    Brand = "Fiat",
                    Model = "Egea Multijet",
                    Price = 950,
                    Location = "Türkiye",
                    State = "İzmir",
                    Description = "Günlük içler için ideal",
                    CreatedDate = DateTime.UtcNow
                },
                new Car
                {
                    Id = 4,
                    UserId = 2,
                    Brand = "Mercedes",
                    Model = "E350",
                    Price = 1450,
                    Location = "Türkiye",
                    State = "Bursa",
                    Description = "Konfor harika",
                    CreatedDate = DateTime.UtcNow
                },
                new Car
                {
                    Id = 5,
                    UserId = 2,
                    Brand = "Peugeot",
                    Model = "3008 Gt",
                    Price = 2750,
                    Location = "Türkiye",
                    State = "Trabzon",
                    Description = "Yeni nesil tasarım",
                    CreatedDate = DateTime.UtcNow
                },
                new Car
                {
                    Id = 6,
                    UserId = 3,
                    Brand = "Audi",
                    Model = "A8 Long",
                    Price = 3000,
                    Location = "Türkiye",
                    State = "Zonguldak",
                    Description = "Modern, konforlu ve hızlı",
                    CreatedDate = DateTime.UtcNow
                }
            );
        }
    }
}
