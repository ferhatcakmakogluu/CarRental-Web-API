using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.EntityConfigurations
{
    public class CarFeaturesConfiguration : IEntityTypeConfiguration<CarFeature>
    {
        public void Configure(EntityTypeBuilder<CarFeature> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Color).IsRequired().HasMaxLength(125);
            builder.Property(x => x.Km).IsRequired();
            builder.Property(x => x.FuelType).IsRequired();
            builder.Property(x => x.BodyType).IsRequired();
            builder.Property(x => x.GearType).IsRequired();
        }
    }
}
