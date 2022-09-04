using Business.Apstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Apstract;
using DataAccess.Concrete.EntityFremawork;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("Admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run();

            if (result!=null)
            {
                return result;
            }

            _carDal.Add(car);
            return new SuccessResult(CarMessages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(CarMessages.CarDeleted);
        }

        [CacheAspect]
        public IDataResult<List<CarDetailDto>> GetAll()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllCar());

        }

        [CacheAspect]
        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max));
        }
        [CacheAspect]
        public IDataResult<List<Car>> DateQuery()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        //[CacheRemoveAspect("ICarService.Get")]
        //  [PerformanceAspect(10)]
        [CacheAspect]
        public IResult Update(Car car)
        {

            _carDal.Update(car);
            return new SuccessResult(CarMessages.CarUpdated);
        }

        [CacheAspect]
        public IDataResult<List<CarDetailDto>> GetById(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllCar(p => p.CarId == id));
        }

        public IDataResult<List<CarDetailDto>> GetByBrand(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllCar(x=>x.brandId==brandId));

        }
        public IDataResult<List<CarDetailDto>> GetByColor(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllCar(x=>x.colorId==colorId));

        }
      
       
    }
}
