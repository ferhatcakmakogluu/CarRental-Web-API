using NLayer.Core.DTOs;

namespace NLayer.Web.Models
{
    public class CarFilterModel
    {
        public List<string> Brand { get; set; } = new List<string>();
        public List<string> BodyType { get; set; } = new List<string>();
        public List<string> FuelType { get; set; } = new List<string>();
        public List<string> GearType { get; set; } = new List<string>();
        public string? Location { get; set; }
        public string? State { get; set; }
        public string BrandOrModel { get; set; }
        public string? MaxKm { get; set; } = "0";
        public string? MinKm { get; set; } = "0";
        public List<string> Color { get; set; } = new List<string>();
        public List<CarFeatureWithCarDto> CarFeatureWithCars { get; set; }
        public IDictionary<string, int> CarBrandCounts { get; set; }
        public IDictionary<string, int> CarBodyTypeCounts { get; set; }
        public IDictionary<string, int> CarGearTypeCounts { get; set; }
        public IDictionary<string, int> CarColorTypeCounts { get; set; }
        public IDictionary<string, int> CarFuelTypeCounts { get; set; }

    }
}
