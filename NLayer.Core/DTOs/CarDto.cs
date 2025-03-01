﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CarDto
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public List<string>? Photos { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string State { get; set; }
        public int UserId { get; set; }
    }
}
