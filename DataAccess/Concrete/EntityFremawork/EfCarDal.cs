﻿using Core.DataAccess;
using DataAccess.Apstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFremawork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Context>, ICarDal
    {
        public List<CarDetailDto> GetAllCar(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join c1 in context.Colors
                             on c.ColorId equals c1.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 colorId = c1.ColorId,
                                 ColorName = c1.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 brandId = b.BrandId,
                                 CarName = b.BrandName,
                                 MinFindexScore = c.MinFindexScore,
                                 ImagePath = context.CarsImages.Where(w => w.CarId == c.CarId).FirstOrDefault().ImagePath,
                                 Capacity = c.Capacity,
                                 CarModel = c.CarModel,
                                 Description = c.Description,
                                 Fuel = c.Fuel,
                                 Gear=c.Gear,
                                 LuggageCapacity=c.LuggageCapacity,
                                 ModelYear=c.ModelYear,

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }

        public List<RentalFilterDto> GetAllFilterCar(Expression<Func<RentalFilterDto, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Rentals
                             on c.CarId equals r.CarId
                             select new RentalFilterDto
                             {
                                 CarId = c.CarId,
                                 CarName=b.BrandName,
                                 ImagePath = context.CarsImages.Where(w => w.CarId == c.CarId).FirstOrDefault().ImagePath,
                                 Capacity = c.Capacity,
                                 CarModel = c.CarModel,
                                 Fuel = c.Fuel,
                                 Gear = c.Gear,
                                 LuggageCapacity = c.LuggageCapacity,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate,
                                
                                 
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}
