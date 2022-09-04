using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Payment:IEntity
    {
        public int PaymentId { get; set; }
        public string CardNameSurname { get; set; }
        public decimal AmountPaye { get; set; }
        public int CardExpiryDate { get; set; }
        public int CardCvv{ get; set; }
        public int CardNumber { get; set; }

    }
}
