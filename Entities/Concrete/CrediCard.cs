using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class CrediCard:IEntity
    {
        [Key]
        public int CardId { get; set; }
        public int CustomerID { get; set; }
        public string CreditCardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
        public decimal Price { get; set; }

    }
}
