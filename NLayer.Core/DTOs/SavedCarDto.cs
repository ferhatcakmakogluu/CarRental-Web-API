using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class SavedCarDto
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CarId { get; set; }
        public DateTime SavedTime { get; set; }
        //public Car Car { get; set; }
        //public Account Account { get; set; }
    }
}
