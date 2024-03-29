﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Apstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
        IDataResult<List<Brand>>GetById(int id);
    }
}
