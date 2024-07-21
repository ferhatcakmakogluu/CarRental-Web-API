namespace NLayer.Web.Models
{
    public class CarFilterModel
    {
        public List<string> Brand {  get; set; } = new List<string>();
        public List<string> BodyType { get; set; } = new List<string>();
        public List<string> FuelType { get; set; } = new List<string>();
        public List<string> GearType { get; set; } = new List<string>();
        public string Location { get; set; }
        public List<string> Km { get; set; } = new List<string>();
        public List<string> Color { get; set; } = new List<string>();

    }
}
