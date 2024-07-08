using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;

namespace NLayer.Repository.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "Ferhat",
                    LastName = "Cakmakoglu",
                    PhoneNumber = "12365478914",
                    Adress =  "X Mahallesi ",
                }, 
                new User
                {
                    Id = 2,
                    Name = "Ahmet",
                    LastName = "Tellioglu",
                    PhoneNumber = "96325874125",
                    Adress = "Y Mahallesi ",
                },
                new User
                {
                    Id = 3,
                    Name = "Kerem",
                    LastName = "Can",
                    PhoneNumber = "25874123654",
                    Adress = "Z Mahallesi ",
                },
                new User
                {
                    Id = 4,
                    Name = "Ali",
                    LastName = "Vurgun",
                    PhoneNumber = "58963214875",
                    Adress = "C Mahallesi ",
                },
                new User
                {
                    Id = 5,
                    Name = "Veli",
                    LastName = "Menur",
                    PhoneNumber = "98563210254",
                    Adress = "AA Mahallesi ",
                }
            ); 
        }
    }
}
