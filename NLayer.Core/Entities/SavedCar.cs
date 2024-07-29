using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Entities
{
    public class SavedCar
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CarId { get; set; }
        public DateTime SavedTime { get; set; }
        public Car Car { get; set; }
    }
}
