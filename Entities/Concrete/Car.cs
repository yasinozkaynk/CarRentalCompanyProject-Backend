using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        [Key]
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
        public int MinFindexScore { get; set; }
        public string CarModel { get; set; }
        public int Capacity { get; set; }
        public string Gear { get; set; }
        public int LuggageCapacity { get; set; }
        public string Fuel { get; set; }
    }
}
