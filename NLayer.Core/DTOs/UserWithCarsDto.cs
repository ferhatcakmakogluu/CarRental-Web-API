﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class UserWithCarsDto : UserDto
    {
        public List<CarDto> Cars { get; set; }
    }
}
