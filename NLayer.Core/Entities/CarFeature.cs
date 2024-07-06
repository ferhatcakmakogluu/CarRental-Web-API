using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Entities
{
    public class CarFeature
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public long Km { get; set; }
        public string FuelType { get; set; }
        public string BodyType { get; set; }
        public string GearType { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
