﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Apstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
        List<CustomerDto> GetCustomerDto();
    }
}
