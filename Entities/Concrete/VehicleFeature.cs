using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class VehicleFeature:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string CarModel { get; set; }
        public int Capacity { get; set; }
        public int Gear { get; set; }
        public int LuggageCapacity { get; set; }
        public int Fuel { get; set; }
    }
}
