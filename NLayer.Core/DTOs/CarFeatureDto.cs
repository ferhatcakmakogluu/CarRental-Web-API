using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CarFeatureDto
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Km { get; set; }
        public string FuelType { get; set; }
        public string BodyType { get; set; }
        public string GearType { get; set; }
        public int CarId { get; set; }
    }
}
