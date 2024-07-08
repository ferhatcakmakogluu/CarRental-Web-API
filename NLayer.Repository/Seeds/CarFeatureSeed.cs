using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;
using NLayer.Core.Enums.EntityTypes;

namespace NLayer.Repository.Seeds
{
    public class CarFeatureSeed : IEntityTypeConfiguration<CarFeature>
    {
        public void Configure(EntityTypeBuilder<CarFeature> builder)
        {
            builder.HasData(
                new CarFeature
                {
                    Id = 1,
                    Color = "Kırmızı",
                    Km = "12500",
                    FuelType = CarFeatureEnum.FuelTypesEnum.HYBRID.ToString(),
                    BodyType = CarFeatureEnum.BodyTypesEnum.SEDAN.ToString(),
                    GearType = CarFeatureEnum.GearTypesEnum.SEMI_AUTOMATIC.ToString(),
                    CarId = 1
                },
                new CarFeature
                {
                    Id = 2,
                    Color = "Gri",
                    Km = "4500",
                    FuelType = CarFeatureEnum.FuelTypesEnum.DIESEL.ToString(),
                    BodyType = CarFeatureEnum.BodyTypesEnum.SUV.ToString(),
                    GearType = CarFeatureEnum.GearTypesEnum.AUTOMATIC.ToString(),
                    CarId = 2
                },
                new CarFeature
                {
                    Id = 3,
                    Color = "Mavi",
                    Km = "111000",
                    FuelType = CarFeatureEnum.FuelTypesEnum.GASOLINE.ToString(),
                    BodyType = CarFeatureEnum.BodyTypesEnum.CROSSOVER.ToString(),
                    GearType = CarFeatureEnum.GearTypesEnum.MANUEL.ToString(),
                    CarId = 3
                },
                new CarFeature
                {
                    Id = 4,
                    Color = "Yeşil",
                    Km = "2150",
                    FuelType = CarFeatureEnum.FuelTypesEnum.ELECTRIC.ToString(),
                    BodyType = CarFeatureEnum.BodyTypesEnum.SEDAN.ToString(),
                    GearType = CarFeatureEnum.GearTypesEnum.SEMI_AUTOMATIC.ToString(),
                    CarId = 4
                },
                new CarFeature
                {
                    Id = 5,
                    Color = "Turuncu",
                    Km = "65000",
                    FuelType = CarFeatureEnum.FuelTypesEnum.DIESEL.ToString(),
                    BodyType = CarFeatureEnum.BodyTypesEnum.CROSSOVER.ToString(),
                    GearType = CarFeatureEnum.GearTypesEnum.AUTOMATIC.ToString(),
                    CarId = 5
                },
                new CarFeature
                {
                    Id = 6,
                    Color = "Siyah",
                    Km = "35600",
                    FuelType = CarFeatureEnum.FuelTypesEnum.DIESEL.ToString(),
                    BodyType = CarFeatureEnum.BodyTypesEnum.CROSSOVER.ToString(),
                    GearType = CarFeatureEnum.GearTypesEnum.AUTOMATIC.ToString(),
                    CarId = 6
                }
            );
        }
    }
}
