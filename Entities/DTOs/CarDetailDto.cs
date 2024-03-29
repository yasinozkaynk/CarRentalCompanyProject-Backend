﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string ImagePath { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public string ColorName { get; set; }
        public int MinFindexScore { get; set; }
        public int brandId { get; set; }
        public int colorId { get; set; }
        public string CarModel { get; set; }
        public int Capacity { get; set; }
        public string Gear { get; set; }
        public int LuggageCapacity { get; set; }
        public string Fuel { get; set; }

    }

}
