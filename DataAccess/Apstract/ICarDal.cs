﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Apstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetAllCar(Expression<Func<CarDetailDto,bool>>filter=null);
        List<RentalFilterDto> GetAllFilterCar(Expression<Func<RentalFilterDto, bool>>filter=null);
    }
}
