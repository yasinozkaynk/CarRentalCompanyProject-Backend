using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalFilterDto:IDto
    {
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public int Capacity { get; set; }
        public string Gear { get; set; }
        public int LuggageCapacity { get; set; }
        public string Fuel { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
