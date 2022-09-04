using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic; 
using System.Text;

namespace Business.Apstract
{
    public interface ICarService
    {
    
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetAll();
        IDataResult<List<Car>> GetByDailyPrice(decimal min,decimal max);
        IDataResult<List<CarDetailDto>> GetById(int id);
        IDataResult<List<CarDetailDto>> GetByBrand(int brandId);
        IDataResult<List<CarDetailDto>> GetByColor(int colorId);







    }
}
